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
    public class SweepRulesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IRepository<Data.Sweep> _sweepRepository;

        public SweepRulesController(ApplicationDbContext context,
            IRepository<Data.Sweep> sweepRepository)
        {
            _context = context;
            _sweepRepository = sweepRepository;
        }

        // GET: SweepRules
        public async Task<IActionResult> Index()
        {
            return View(await _context.Rules.ToListAsync());
        }

        // GET: SweepRules/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sweepRules = await _context.Rules
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sweepRules == null)
            {
                return NotFound();
            }

            return View(sweepRules);
        }

        // GET: SweepRules/Create
        [Route("Sweeps/{id}/Rules/Create")]
        public IActionResult Create(Guid id)
        {
            return View();
        }

        // POST: SweepRules/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Route("Sweeps/{id}/Rules/Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CutHandicaps,WinnerCut,SecondCut,ThirdCut,MinPointsForCut,OrderOfMerit,OOMEntriesScale")]
            Guid id, SweepRules sweepRules)
        {
            if (ModelState.IsValid)
            {

                var sweep = await _sweepRepository.GetById(id);
                sweepRules.Id = Guid.NewGuid();
                //_context.Add(sweepRules);

                sweep.Rules = new SweepRules();

                sweep.Rules.Id = sweepRules.Id;

                sweep.Rules = sweepRules;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sweepRules);
        }

        // GET: SweepRules/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sweepRules = await _context.Rules.FindAsync(id);
            if (sweepRules == null)
            {
                return NotFound();
            }
            return View(sweepRules);
        }

        // POST: SweepRules/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,CutHandicaps,WinnerCut,SecondCut,ThirdCut,MinPointsForCut,OrderOfMerit,OOMEntriesScale")] SweepRules sweepRules)
        {
            if (id != sweepRules.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sweepRules);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SweepRulesExists(sweepRules.Id))
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
            return View(sweepRules);
        }

        // GET: SweepRules/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sweepRules = await _context.Rules
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sweepRules == null)
            {
                return NotFound();
            }

            return View(sweepRules);
        }

        // POST: SweepRules/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var sweepRules = await _context.Rules.FindAsync(id);
            _context.Rules.Remove(sweepRules);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SweepRulesExists(Guid id)
        {
            return _context.Rules.Any(e => e.Id == id);
        }
    }
}
