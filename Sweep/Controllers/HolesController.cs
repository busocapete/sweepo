using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GolfSweep.Data;
using GolfSweep.Repositories.Interfaces;

namespace GolfSweep.Controllers
{
    public class HolesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IRepository<Course> _courseRepository;

        public HolesController(ApplicationDbContext context,
            IRepository<Course> courseRepository)
        {
            _context = context;
            _courseRepository = courseRepository;
        }

        // GET: Holes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Holes.OrderBy(h => h.Number).ToListAsync());
        }

        // GET: Holes/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hole = await _context.Holes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hole == null)
            {
                return NotFound();
            }

            return View(hole);
        }

        // GET: Holes/Create
        [Route("Courses/{courseId}/Holes/Create")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Holes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Courses/{courseId}/Holes/Create")]
        public async Task<IActionResult> Create(Guid courseId, [Bind("Id,Number,Index,Par,Score,Points")] Hole hole)
        {
            if (ModelState.IsValid)
            {
                hole.Id = Guid.NewGuid();
                hole.Created = DateTimeOffset.Now;

                var course = await _courseRepository.GetById(courseId);

                course.Holes.Add(hole);
                //_context.Add(hole);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Courses");
            }
            return View(hole);
        }

        // GET: Holes/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hole = await _context.Holes.FindAsync(id);
            if (hole == null)
            {
                return NotFound();
            }
            return View(hole);
        }

        // POST: Holes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Number,Index,Par,Score,Points")] Hole hole)
        {
            if (id != hole.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hole);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HoleExists(hole.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(hole);
        }

        // GET: Holes/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hole = await _context.Holes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hole == null)
            {
                return NotFound();
            }

            return View(hole);
        }

        // POST: Holes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var hole = await _context.Holes.FindAsync(id);
            _context.Holes.Remove(hole);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HoleExists(Guid id)
        {
            return _context.Holes.Any(e => e.Id == id);
        }
    }
}
