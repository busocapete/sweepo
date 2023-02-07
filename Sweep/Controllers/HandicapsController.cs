using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GolfSweep.Data;
using GolfSweep.Repositories.Interfaces;
using GolfSweep.Dtos;

namespace Sweep.Controllers
{
    public class HandicapsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IRepository<Player> _playerRepository;

        public HandicapsController(ApplicationDbContext context,
            IRepository<Handicap> repository,
            IRepository<Player> playerRepository)
        {
            _context = context;
            _playerRepository = playerRepository;
        }

        [HttpPost("api/handicaps")]
        public async Task<IActionResult> UpdatePlayerHandicap([FromBody] UpdateHandicapDto dto)
        {
            var player = await _playerRepository.GetById(dto.PlayerId);

            if (player == null)
            {
                return NotFound();
            }

            var playingHandicapInt = Math.Round(dto.Handicap, MidpointRounding.AwayFromZero);
            var playingHandicapToAdd = Convert.ToInt32(playingHandicapInt);
            var handicapToAdd = new Handicap()
            {
                Id = Guid.NewGuid(),
                Exact = dto.Handicap,
                Playing = playingHandicapToAdd,
                Created = DateTimeOffset.Now,
                PlayerId = dto.PlayerId,
                SweepId = dto.SweepId
            };

            _context.Handicaps.Add(handicapToAdd);

            if (! await _playerRepository.SaveChanges())
            {
                throw new Exception($"Failed to update handicap for playerId {player.Id}");
            }

            var handicapToReturn = new UpdateHandicapResponseDto()
            {
                PlayerId = player.Id,
                SweepId = dto.SweepId,
                CurrentExactHandicap = handicapToAdd.Exact,
                CurrentHandicap = handicapToAdd.Playing
            };

            return Ok(handicapToReturn);
        }

        // GET: Handicaps
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Handicaps.Include(h => h.Player);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Handicaps/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var handicap = await _context.Handicaps
                .Include(h => h.Player)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (handicap == null)
            {
                return NotFound();
            }

            return View(handicap);
        }

        // GET: Handicaps/Create
        [Route("Players/{playerId}/Handicaps/Create")]
        public IActionResult Create()
        {
            ViewData["PlayerId"] = new SelectList(_context.Players, "Id", "FullName");
            return View();
        }

        // POST: Handicaps/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Players/{playerId}/Handicaps/Create")]
        public async Task<IActionResult> Create(Guid playerId, [Bind("Id,Exact,Playing,Created,PlayerId")] Handicap handicap)
        {
            if (ModelState.IsValid)
            {
                handicap.Id = Guid.NewGuid();
                handicap.Created = DateTimeOffset.Now;

                var player = await _playerRepository.GetById(playerId);
                player.Handicaps.Add(handicap);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Players");
            }
            ViewData["PlayerId"] = new SelectList(_context.Players, "Id", "FullName", handicap.PlayerId);
            return View(handicap);
        }

        // GET: Handicaps/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var handicap = await _context.Handicaps.FindAsync(id);
            if (handicap == null)
            {
                return NotFound();
            }
            ViewData["PlayerId"] = new SelectList(_context.Players, "Id", "Id", handicap.PlayerId);
            return View(handicap);
        }

        // POST: Handicaps/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Exact,Playing,Created,PlayerId")] Handicap handicap)
        {
            if (id != handicap.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(handicap);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HandicapExists(handicap.Id))
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
            ViewData["PlayerId"] = new SelectList(_context.Players, "Id", "Id", handicap.PlayerId);
            return View(handicap);
        }

        // GET: Handicaps/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var handicap = await _context.Handicaps
                .Include(h => h.Player)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (handicap == null)
            {
                return NotFound();
            }

            return View(handicap);
        }

        // POST: Handicaps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var handicap = await _context.Handicaps.FindAsync(id);
            _context.Handicaps.Remove(handicap);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HandicapExists(Guid id)
        {
            return _context.Handicaps.Any(e => e.Id == id);
        }
    }
}
