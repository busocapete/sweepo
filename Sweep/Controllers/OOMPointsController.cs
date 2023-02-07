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
    public class OOMPointsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IRepository<Player> _playerRepository;
        private readonly IRepository<Data.Sweep> _sweepRepository;
        private readonly IRepository<Event> _eventRepository;

        public OOMPointsController(ApplicationDbContext context,
            IRepository<Player> playerRepository,
            IRepository<Data.Sweep> sweepRepository,
            IRepository<Event> eventRepository)
        {
            _context = context;
            _playerRepository = playerRepository;
            _sweepRepository = sweepRepository;
            _eventRepository = eventRepository;
        }

        // GET: OOMPoints
        public async Task<IActionResult> Index()
        {

            return View(await _context.OOMPoints.ToListAsync());
        }

        // GET: OOMPoints/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oOMPoints = await _context.OOMPoints
                .FirstOrDefaultAsync(m => m.Id == id);
            if (oOMPoints == null)
            {
                return NotFound();
            }

            return View(oOMPoints);
        }

        // GET: OOMPoints/Create
        [Route("sweeps/{sweepId}/oomPoints/Create")]
        public async Task<IActionResult> Create(Guid sweepId)
        {
            var players = await _playerRepository.GetAll();
            var events = await _eventRepository.GetAll();
            ViewData["PlayerId"] = new SelectList(players, "Id", "FullName");
            ViewData["EventId"] = new SelectList(events, "Id", "Date");

            return View();
        }

        // POST: OOMPoints/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Route("sweeps/{sweepId}/oomPoints/Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Points,Position,Id,Created,PlayerId")]
            Guid sweepId, Guid eventId, OOMPoints oOMPoints, Guid playerId)
        {
            if (ModelState.IsValid)
            {
                oOMPoints.Id = Guid.NewGuid();
                oOMPoints.Created = DateTimeOffset.Now;
                oOMPoints.Sweep = await _sweepRepository.GetById(sweepId);

                var player = await _playerRepository.GetById(playerId);
                var @event = await _eventRepository.GetById(eventId);

                oOMPoints.Player = player;


               if (@event.OOMPoints == null)
                {
                    @event.OOMPoints = new List<OOMPoints>();
                }

                oOMPoints.Card = @event.Entries
                    .Where(e => e.ScoreCard.Player.Id == player.Id)
                    .Select(s => s.ScoreCard)
                    .FirstOrDefault();

                @event.OOMPoints.Add(oOMPoints);
               // _context.Add(oOMPoints);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            var players = await _playerRepository.GetAll();

            ViewData["PlayerId"] = new SelectList(players, "Id", "FullName");

            return View(oOMPoints);
        }

        // GET: OOMPoints/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oOMPoints = await _context.OOMPoints.FindAsync(id);
            if (oOMPoints == null)
            {
                return NotFound();
            }
            return View(oOMPoints);
        }

        // POST: OOMPoints/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Points,Position,Id,Created")] OOMPoints oOMPoints)
        {
            if (id != oOMPoints.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(oOMPoints);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OOMPointsExists(oOMPoints.Id))
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
            return View(oOMPoints);
        }

        // GET: OOMPoints/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oOMPoints = await _context.OOMPoints
                .FirstOrDefaultAsync(m => m.Id == id);
            if (oOMPoints == null)
            {
                return NotFound();
            }

            return View(oOMPoints);
        }






        // POST: OOMPoints/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var oOMPoints = await _context.OOMPoints.FindAsync(id);
            _context.OOMPoints.Remove(oOMPoints);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OOMPointsExists(Guid id)
        {
            return _context.OOMPoints.Any(e => e.Id == id);
        }
    }
}
