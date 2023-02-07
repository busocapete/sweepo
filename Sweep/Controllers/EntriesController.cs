using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GolfSweep.Data;
using GolfSweep.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;
using GolfSweep.Dtos;
using AutoMapper;

namespace Sweep.Controllers
{
    public class EntriesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IRepository<Event> _eventRepository;
        private readonly IEntryRepository _entryRepository;
        private readonly IRepository<Player> _playersRepository;
        private readonly IRepository<Course> _courseRepository;
        private readonly IPlayerRepository _playerRepository;
        private readonly ISweepRepository _sweepRepository;
        private readonly UserManager<ApplicationUser> _userManager;

        public EntriesController(ApplicationDbContext context,
            IRepository<Event> eventRepository,
            IEntryRepository entryRepository,
            IRepository<Player> playersRepository,
            IRepository<Course> courseRepository,
            IPlayerRepository playerRepository,
            ISweepRepository sweepRepository,
            UserManager<ApplicationUser> userManager
           )
        {
            _context = context;
            _eventRepository = eventRepository;
            _entryRepository = entryRepository;
            _playersRepository = playersRepository;
            _courseRepository = courseRepository;
            _playerRepository = playerRepository;
            _sweepRepository = sweepRepository;
            _userManager = userManager;
        }

        [HttpPost("api/entries/delete/")]
        public async Task<IActionResult> DeletePlayerEntry([FromBody] PlayerEntryDto dto)
        {
            var player = await _playerRepository.GetById(dto.PlayerId);

            var @event = _context.Events.Where(e => e.Id == dto.EventId).FirstOrDefault();

            var entry = @event.Entries.Where(e => e.ScoreCard.Player.Id == dto.PlayerId).FirstOrDefault();

            var scoreCard = entry.ScoreCard;

            var scores = scoreCard.Scores;

            foreach (var score in scores)
            {
                _context.Score.Remove(score);
            }

            await _context.SaveChangesAsync();

            _context.ScoreCards.Remove(scoreCard);

            await _context.SaveChangesAsync();

            _context.Entries.Remove(entry);

            await _context.SaveChangesAsync();

            return Ok(dto);


        }


        [HttpPost("api/entries/player/enter")]
        public async Task<IActionResult> PlayerEventEntry([FromBody] PlayerEntryDto dto)
        {
            var player = await _playerRepository.GetById(dto.PlayerId);

            var alreadyEntered = _context.Events.Where(e => e.Id == dto.EventId)
                .Any(e => e.Entries.Any(en => en.ScoreCard.PlayerId == dto.PlayerId));

            if (alreadyEntered)
            {
                return null;
            }

            var entry = new Entry();
            entry.Id = Guid.NewGuid();
            entry.Created = DateTimeOffset.Now;
            entry.ScoreCard = new ScoreCard();
            entry.ScoreCard.Created = DateTimeOffset.Now;
            entry.ScoreCard.Player = player;


            //var sweepId = _context.Sweeps.Where(s => s.Events.Any(e => e.Id == dto.EventId))
            //    .Select(s => s.Id)
            //    .FirstOrDefault();

            var sweepId = await _sweepRepository.GetSweepIdFromEventId(dto.EventId);




            entry.ScoreCard.EventHandicap = await _sweepRepository.GetPlayerCurrentPlayingSweepHandicap(sweepId, player.Id);

            //var handicap = _context.Handicaps
            //        .Where(h => h.PlayerId == player.Id
            //        && h.SweepId == sweepId)
            //        .OrderByDescending(h => h.Created)
            //        .Select(h => h.Exact).FirstOrDefault();

            //var playerhCap = Math.Round(player.CurrentExactHandicap, MidpointRounding.AwayFromZero);

            //entry.ScoreCard.EventHandicap = Convert.ToInt32(playerhCap);

            var @event = await _eventRepository.GetById(dto.EventId);

            if (@event.WinterHandicaps)
            {
                entry.ScoreCard.EventHandicap = _entryRepository
                    .ConvertEventHandicapToWinter(entry.ScoreCard.EventHandicap, 0.75);
            }


            entry.ScoreCard.Course = @event.Course;

            var scores = new List<Score>();

            foreach (var hole in entry.ScoreCard.Course.Holes.ToList())
            {
                var score = new Score()
                {
                    Id = Guid.NewGuid(),
                    Gross = 0,
                    Nett = 0,
                    Points = 0,
                    HoleNumber = hole.Number,
                    Created = DateTimeOffset.Now
                };

                scores.Add(score);
                //entry.ScoreCard.Scores.Add(score);
            }

            entry.ScoreCard.Scores = scores;


            @event.Entries.Add(entry);

            if (!await _eventRepository.SaveChanges())
            {
                throw new Exception($"Failed to Add Entry for player {player.FullName}");
            }

            var playerToReturn = new PlayerEntryResponseDto()
            {
                Id = player.Id,
                Name = player.FullName
            };
            

            return Ok(playerToReturn);
        }



        [Route("api/entries/play/{id}")]
        public async Task<IActionResult> PlayEvent(Guid id)
        {
            var @event = await _eventRepository.GetById(id);
            var user = await _userManager.GetUserAsync(User);
            var player = await _playerRepository.GetUserPlayer(user.Id);

            var entry = @event.Entries.Where(e => e.ScoreCard.Player.Id == player.Id).FirstOrDefault();

            var playerScoreCard = entry.ScoreCard;
            var markerScoreCard = entry.Marker;

            var groupScoreCards = @event.Entries
                .Where(e => e.Group == entry.Group)
                .Select(e => e.ScoreCard);

            var groupPlayers = @event.Entries
                .Where(e => e.Group == entry.Group)
                .Select(e => e.ScoreCard.Player);

            var eventToReturn = Mapper.Map<EventDto>(@event);
            var groupPlayersToReturn = Mapper.Map<IEnumerable<PlayerDto>>(groupPlayers);
            var playerCardToReturn = Mapper.Map<ScoreCardDto>(playerScoreCard);
            var markerCardToReturn = Mapper.Map<ScoreCardDto>(markerScoreCard);

            var response = new PlayEventDto()
            {
                @Event = eventToReturn,
                PlayerCard = playerCardToReturn,
                MarkerCard = markerCardToReturn,
                GroupPlayers = groupPlayersToReturn.ToList()
            };


           return Ok(response);
        }

        // GET: Entries
        public async Task<IActionResult> Index()
        {
            return View(await _context.Entries.ToListAsync());
        }

        // GET: Entries/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entry = await _context.Entries
                .FirstOrDefaultAsync(m => m.Id == id);
            if (entry == null)
            {
                return NotFound();
            }

            return View(entry);
        }

        // GET: Entries/Create
        [Route("Events/{eventId}/Entries/Create")]
        public async Task<IActionResult> Create(Guid eventId)
        {
            var players = await _playersRepository.GetAll();
            var courses = await _courseRepository.GetAll();

            ViewData["PlayerId"] = new SelectList(players, "Id", "FullName");
            ViewData["CourseId"] = new SelectList(courses, "Id", "Name");

            return View();
        }

        [Route("api/entries/withdraw")]
        public async Task<IActionResult> WithDrawEntry([FromBody] EntryDto dto)
        {
            var user = await _userManager.GetUserAsync(User);
            var player = await _playerRepository.GetUserPlayer(user.Id);

            var @event = await _eventRepository.GetById(dto.Id);

            var entry = @event.Entries.Where(e => e.ScoreCard.PlayerId == player.Id).FirstOrDefault();

            _context.Entries.Remove(entry);
            
            if (!await _entryRepository.SaveChanges())
            {
                throw new Exception($"Failed to withdraw entry");
            }

            return Ok("Entry Withdrawn");
        }

        [Route("api/entries/enter")]
        public async Task<IActionResult> EnterEvent([FromBody] EntryDto dto)
        {
            var user = await _userManager.GetUserAsync(User);
            var player = await _playerRepository.GetUserPlayer(user.Id);

            var entry = new Entry();
            entry.Id = Guid.NewGuid();
            entry.Created = DateTimeOffset.Now;

            //var sweepId = _context.Sweeps.Where(s => s.Events.Any(e => e.Id == dto.Id))
            //    .Select(s => s.Id)
            //    .FirstOrDefault();

            var sweepId = await _sweepRepository.GetSweepIdFromEventId(dto.Id);

            entry.ScoreCard = new ScoreCard();
            entry.ScoreCard.Created = DateTimeOffset.Now;

            entry.ScoreCard.Player = player;

            entry.ScoreCard.EventHandicap = entry.ScoreCard.Player.CurrentHandicap;


            var @event = await _eventRepository.GetById(dto.Id);

            if (@event.WinterHandicaps)
            {
                entry.ScoreCard.EventHandicap = _entryRepository.ConvertEventHandicapToWinter(
                    entry.ScoreCard.EventHandicap, 0.75);
            }


            entry.ScoreCard.Course = @event.Course;

            var scores = new List<Score>();

            foreach (var hole in entry.ScoreCard.Course.Holes.ToList())
            {
                var score = new Score()
                {
                    Id = Guid.NewGuid(),
                    Gross = 0,
                    Nett = 0,
                    Points = 0,
                    HoleNumber = hole.Number
                };

                scores.Add(score);
                //entry.ScoreCard.Scores.Add(score);
            }

            entry.ScoreCard.Scores = scores;


            @event.Entries.Add(entry);

            if (! await _eventRepository.SaveChanges())
            {
                throw new Exception($"Failed to Add Entry for player {player.FullName}");
            }


            return Ok(entry);

        }


        // POST: Entries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Events/{eventId}/Entries/Create")]
        public async Task<IActionResult> Create(Guid eventId, Guid playerId, [Bind("Paid,Id,Created")] Entry entry)
        {
            if (ModelState.IsValid)
            {
                entry.Id = Guid.NewGuid();
                entry.Created = DateTimeOffset.Now;

                var sweepId = _context.Sweeps.Where(s => s.Events.Any(e => e.Id == eventId))
                    .Select(s => s.Id)
                    .FirstOrDefault();


                entry.ScoreCard = new ScoreCard();
                entry.ScoreCard.Created = DateTimeOffset.Now;

                entry.ScoreCard.Player = _context.Players.Where(p => p.Id == playerId).FirstOrDefault();


                var handicap = _context.Handicaps
                    .Where(h => h.PlayerId == entry.ScoreCard.Player.Id
                    && h.SweepId == sweepId)
                    .OrderByDescending(h => h.Created)
                    .Select(h => h.Playing)
                    .FirstOrDefault();

                //entry.ScoreCard.EventHandicap = entry.ScoreCard.Player.CurrentHandicap;


                entry.ScoreCard.EventHandicap = handicap;

                var @event = await _eventRepository.GetById(eventId);

                entry.ScoreCard.Course = @event.Course;

                if (@event.WinterHandicaps)
                {
                    double doubleHcap = entry.ScoreCard.EventHandicap * 0.75;
                    double roundedHcap = Math.Round(doubleHcap, MidpointRounding.AwayFromZero); 
                    entry.ScoreCard.EventHandicap = Convert.ToInt32(roundedHcap);
                }


                var scores = new List<Score>();

                foreach (var hole in entry.ScoreCard.Course.Holes.ToList())
                {
                    var score = new Score()
                    {
                        Id = Guid.NewGuid(),
                        Gross = 0,
                        Nett = 0,
                        Points = 0,
                        HoleNumber = hole.Number
                    };

                    scores.Add(score);
                    //entry.ScoreCard.Scores.Add(score);
                }

                entry.ScoreCard.Scores = scores;



                @event.Entries.Add(entry);
                await _context.SaveChangesAsync();
                //return RedirectToAction(nameof(Index));
                return RedirectToAction("Details", "Events", new { sweepId, id = eventId });
            }
            return View(entry);
        }

        // GET: Entries/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entry = await _context.Entries.FindAsync(id);
            if (entry == null)
            {
                return NotFound();
            }
            return View(entry);
        }

        // POST: Entries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Paid,Id,Created")] Entry entry)
        {
            if (id != entry.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(entry);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EntryExists(entry.Id))
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
            return View(entry);
        }

        // GET: Entries/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entry = await _context.Entries
                .FirstOrDefaultAsync(m => m.Id == id);
            if (entry == null)
            {
                return NotFound();
            }

            return View(entry);
        }

        // POST: Entries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var entry = await _context.Entries.FindAsync(id);
            _context.Entries.Remove(entry);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EntryExists(Guid id)
        {
            return _context.Entries.Any(e => e.Id == id);
        }
    }
}
