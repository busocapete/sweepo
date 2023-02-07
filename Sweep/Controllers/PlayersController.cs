using GolfSweep.Data;
using GolfSweep.Dtos;
using GolfSweep.Repositories.Interfaces;
using GolfSweep.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sweep.Controllers
{
    public class PlayersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IRepository<Player> _repository;
        private readonly IPlayerRepository _playerRepository;
        private readonly IRepository<Event> _eventRepository;
        private readonly UserManager<ApplicationUser> _userManager;

        public PlayersController(ApplicationDbContext context,
            IRepository<Player> repository,
            IPlayerRepository playerRepository,
            IRepository<Event> eventRepository,
            UserManager<ApplicationUser> userManager
           )
        {
            _context = context;
            _repository = repository;
            _playerRepository = playerRepository;
            _eventRepository = eventRepository;
            _userManager = userManager;
        }


        [HttpGet("api/players/{id}")]
        public async Task<IActionResult> GetPlayerById(Guid id)
        {
            var player = await _repository.GetById(id);

            var playerToReturn = AutoMapper.Mapper.Map<PlayerDto>(player);

            return Ok(playerToReturn);
        }


        [HttpGet("api/player/getUserPlayer")]
        public async Task<IActionResult> GetUserPlayer()
        {
            var user = await _userManager.GetUserAsync(User);
            var userPlayer = await _playerRepository.GetUserPlayer(user.Id);
            var player = await _repository.GetById(userPlayer.Id);



            var playerToReturn = AutoMapper.Mapper.Map<PlayerDto>(player);

            playerToReturn.Handicaps = playerToReturn.Handicaps.OrderByDescending(h => h.Created).ToList();

            var entries = _context.Entries.Where(e => e.ScoreCard.Player.Id == player.Id)
                .OrderByDescending(e => e.Created);

            var playerEvents = _context.Events
                    //.Where(e => e.Date < DateTime.Now && e.Entries.Any(en => en.ScoreCard.Player.Id == player.Id))
                    .Where(e => e.Entries.Any(en => en.ScoreCard.Player.Id == player.Id))
                    .ToList();


            playerToReturn.Events = AutoMapper.Mapper.Map<IEnumerable<PlayerEventDto>>(playerEvents).ToList();

            playerToReturn.Events = playerToReturn.Events.OrderByDescending(e => e.Date).ToList();


            foreach (var @event in playerToReturn.Events)
            {
                var eventToReturn = await _eventRepository.GetById(@event.Id);
                var entry = eventToReturn.Entries.Where(e => e.ScoreCard.Player.Id == player.Id).FirstOrDefault();
                @event.Entry = AutoMapper.Mapper.Map<EntryDto>(entry);

                var oom = eventToReturn.OOMPoints.Where(e => e.Player.Id == player.Id).FirstOrDefault();
                @event.Points = AutoMapper.Mapper.Map<OOMPointsDto>(oom);
            }


            //var exactHandicap = _context.Handicaps.Where(h => h.Player.Id == player.Id)
            //    .OrderByDescending(h => h.Created).Select(h => h.Exact).FirstOrDefault();

            return Ok(playerToReturn);
        }



        // GET: Players
        public async Task<IActionResult> Index()
        {
            //var applicationDbContext = _context.Players.Include(p => p.User);
            //return View(await applicationDbContext.ToListAsync());7
            return View(await _repository.GetAll());
        }

        // GET: Players/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var player = await _repository.GetById(id.Value);

            var events = await _playerRepository.GetPlayerEvents(id.Value);

            if (player == null)
            {
                return NotFound();
            }

            var viewModel = new PlayerDetailsViewModel()
            {
                Player = player,
                Events = events.ToList()
            };

            return View(viewModel);
        }

        // GET: Players/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "FullName");
            return View();
        }

        // POST: Players/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId")] Player player)
        {
            if (ModelState.IsValid)
            {
                player.Id = Guid.NewGuid();
                
                _context.Add(player);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", player.UserId);
            return View(player);
        }

        // GET: Players/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var player = await _context.Players.FindAsync(id);
            if (player == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", player.UserId);
            return View(player);
        }

        // POST: Players/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,UserId")] Player player)
        {
            if (id != player.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(player);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlayerExists(player.Id))
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
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", player.UserId);
            return View(player);
        }

        // GET: Players/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var player = await _context.Players
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (player == null)
            {
                return NotFound();
            }

            return View(player);
        }

        // POST: Players/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var player = await _context.Players.FindAsync(id);
            _context.Players.Remove(player);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlayerExists(Guid id)
        {
            return _context.Players.Any(e => e.Id == id);
        }
    }
}
