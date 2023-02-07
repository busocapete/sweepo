using AutoMapper;
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
using System.Threading;
using System.Threading.Tasks;

namespace GolfSweep.Controllers
{
    public class EventsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IEventRepository _repository;
        private readonly IRepository<Course> _courseRepository;
        private readonly ISweepRepository _sweepRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IPlayerRepository _playerRepository;
        private readonly IRepository<Entry> _entryRepository;
        private readonly IHandicapRepository _handicapRepository;
        private readonly IOOMPointsRepository _pointsRepository;

        public EventsController(ApplicationDbContext context,
            IEventRepository repository,
            IRepository<Course> courseRepository,
            ISweepRepository sweepRepository,
            UserManager<ApplicationUser> userManager,
            IPlayerRepository playerRepository,
            IRepository<Entry> entryRepository,
            IHandicapRepository handicapRepository,
            IOOMPointsRepository pointsRepository
            )
        {
            _context = context;
            _repository = repository;
            _courseRepository = courseRepository;
            _sweepRepository = sweepRepository;
            _userManager = userManager;
            _playerRepository = playerRepository;
            _entryRepository = entryRepository;
            _handicapRepository = handicapRepository;
            _pointsRepository = pointsRepository;
        }




        [HttpGet]
        [Route("api/events/{id}")]
        public async Task<IActionResult> GetEvent(Guid id)
        {
            var user = await _userManager.GetUserAsync(User);
            var userPlayer = await _playerRepository.GetUserPlayer(user.Id);
            var @event = await _repository.GetById(id);

            var sweep = _context.Sweeps.Where(s => s.Events.Any(e => e.Id == id)).FirstOrDefault();

            var eventToReturn = Mapper.Map<EventDto>(@event);

            eventToReturn.UserHasJoined = @event.Entries.Any(e => e.ScoreCard.Player.Id == userPlayer.Id);

            eventToReturn.SweepMembers = Mapper.Map<IEnumerable<PlayerDto>>(sweep.Members.Select(m => m.Player)).ToList();

            List<PlayerEntryResponseDto> playerNames = new List<PlayerEntryResponseDto>();

            if (@event.Entries.Any(e => e.Group != 0 && e.Group != null))
            {
                var entsToReturn = Mapper.Map<IEnumerable<EventEntryDto>>(@event.Entries);

                var updatedEntriesInGroups =
                    from entry in entsToReturn
                    group entry by entry.Group into newGroup
                    orderby newGroup.Key
                    select newGroup;

                eventToReturn.GroupedEntries = updatedEntriesInGroups;
            }
            else
            {
                foreach (var entry in @event.Entries)
                {
                    var playerEntry = new PlayerEntryResponseDto()
                    {
                        Id = entry.ScoreCard.Player.Id,
                        Name = entry.ScoreCard.Player.FullName,
                    };

                    //playerNames.Add(player.ScoreCard.Player.FullName);
                    playerNames.Add(playerEntry);
                }

                eventToReturn.PlayerNames = playerNames;
                eventToReturn.PlayerNames.OrderBy(p => p.Name);

            }




            eventToReturn.SweepId = sweep.Id;

            return Ok(eventToReturn);
        }

        [Route("api/events")]
        public async Task<IActionResult> GetEvents()
        {
            var events = await _repository.GetAll();
            //var events = await _repository.GetAll(true);
                var user = await _userManager.GetUserAsync(User);
                var userPlayer = await _playerRepository.GetUserPlayer(user.Id);


            var eventsToReturn = AutoMapper.Mapper.Map<IEnumerable<EventDto>>(events);

                foreach (var @event in eventsToReturn)
                {
                    var eventToCheck = events.Where(e => e.Id == @event.Id).FirstOrDefault();
                    @event.UserHasJoined = eventToCheck.Entries.Any(e => e.ScoreCard.Player.Id == userPlayer.Id);

                    if (eventToCheck.Entries.Any())
                    {
                        @event.NotDrawn = eventToCheck.Entries.Any(e => e.Group == 0);
                    } else
                    {
                        @event.NotDrawn = true;
                    }

                    
                    List<PlayerEntryResponseDto> playerNames = new List<PlayerEntryResponseDto>();

                    foreach (var entry in eventToCheck.Entries)
                    {
                        var playerToAdd = new PlayerEntryResponseDto()
                        {
                            Id = entry.ScoreCard.Player.Id,
                            Name = entry.ScoreCard.Player.FullName
                        };
                        playerNames.Add(playerToAdd); 
                    }

                    @event.PlayerNames = playerNames;
                    @event.PlayerNames.OrderBy(p => p.Name);
                    @event.InFuture = @event.Date > DateTimeOffset.Now.AddDays(1);

                if (!@event.InFuture)
                {
                    if (eventToCheck.Entries.Any() && eventToCheck.Entries.Count() > 3)
                    {
                        var entries = eventToCheck.Entries.OrderByDescending(e => e.ScoreCard.TotalPoints)
                            .ThenByDescending(e => e.ScoreCard.InPoints)
                            .ThenByDescending(e => e.ScoreCard.LastSixPoints)
                            .ThenByDescending(e => e.ScoreCard.LastThreePoints)
                            .Take(3)
                            .ToList();

                        @event.Winner = entries[0].ScoreCard.Player.FullName;
                        @event.Second = entries[1].ScoreCard.Player.FullName;
                        @event.Third = entries[2].ScoreCard.Player.FullName;
                    }

                }


            }


            return Ok(eventsToReturn.OrderByDescending(e => e.Date));
        }

        // GET: Events
        public async Task<IActionResult> Index()
        {
            return View(await _repository.GetAll());
            //return View(await _context.Events.ToListAsync());
        }


        [Route("api/leaderboard/{id}")]
        public async Task<IActionResult> GetLeaderboard(Guid id)
        {
            if (id == null)
                return NotFound();

            var @event = await _repository.GetById(id);

            if (@event == null)
                return NotFound();

            //var leaderboard = @event.Entries.

            var leaderboard = new List<LeaderboardDto>();

            var entries = @event.Entries.OrderByDescending(e => e.ScoreCard.TotalPoints)
                .ThenByDescending(e => e.ScoreCard.InPoints)
                .ThenByDescending(e => e.ScoreCard.LastSixPoints)
                .ThenByDescending(e => e.ScoreCard.LastThreePoints).ToList();

            for (int i = 0; i < entries.Count(); i++)
            {
                var currentHole = entries[i].ScoreCard.Scores.OrderByDescending(h => h.HoleNumber)
                    .Where(s => s.Gross != 0)
                    .Select(h => h.HoleNumber)
                    .FirstOrDefault();

                var playerToAdd = new LeaderboardDto()
                {
                    Id = entries[i].ScoreCard.PlayerId,
                    FullName = entries[i].ScoreCard.Player.FullName,
                    TotalPoints = entries[i].ScoreCard.TotalPoints,
                    ScoreCardId = entries[i].ScoreCard.Id,
                    Position = i + 1,
                    CurrentHole = currentHole
                };

                leaderboard.Add(playerToAdd);
            }

            //leaderboard.OrderByDescending(l => l.TotalPoints);

            return Ok(leaderboard);
            
        }

        // GET: Events/Details/5

        [Route("Sweeps/{sweepId}/Event/{id}/Entries")]
        public async Task<IActionResult> Details(Guid id, Guid sweepId)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @event = await _repository.GetById(id);

            if (@event == null)
            {
                return NotFound();
            }

            return View(@event);
        }


        [HttpGet("api/events/results/{id}")]
        public async Task<IActionResult> GetEventResults(Guid id)
        {
            var @event = await _repository.GetById(id);

            var user = await _userManager.GetUserAsync(User);
            var userPlayer = await _playerRepository.GetUserPlayer(user.Id);

            var oomPoints = @event.OOMPoints;

            var oomPointsToReturn = Mapper.Map<IEnumerable<OOMPointsDto>>(@event.OOMPoints);

            oomPointsToReturn = oomPointsToReturn
               .OrderByDescending(e => e.Card.TotalPoints)
               .ThenByDescending(e => e.Card.InPoints)
               .ThenByDescending(e => e.Card.LastSixPoints)
               .ThenByDescending(e => e.Card.LastThreePoints);

            var cards = new List<ScoreCard>();

            foreach (var entry in @event.Entries)
            {
                var cardToAdd = entry.ScoreCard;
                cards.Add(cardToAdd);
            }

            var cardsToReturn = Mapper.Map<IEnumerable<ScoreCardDto>>(cards);
            var course = @event.Course;

            cardsToReturn = cardsToReturn.OrderByDescending(e => e.TotalPoints)
             .ThenByDescending(e => e.InPoints)
             .ThenByDescending(e => e.LastSixPoints)
             .ThenByDescending(e => e.LastThreePoints).ToList();

            foreach (var card in cardsToReturn)
            {

                foreach (var score in card.Scores)
                {
                    var hole = course.Holes.Where(h => h.Number == score.HoleNumber).FirstOrDefault();
                    score.Par = hole.Par;
                    score.Index = hole.Index;
                }
                card.Scores = card.Scores.OrderBy(s => s.HoleNumber).ToList();

                card.FrontNine = card.Scores.Where(s => s.HoleNumber < 10)
                    .OrderBy(h => h.HoleNumber)
                    .ToList();
                card.BackNine = card.Scores.Where(s => s.HoleNumber > 9)
                    .OrderBy(h => h.HoleNumber)
                    .ToList();
            }


            var resultsToReturn = new EventResultsDto()
            {
                Id = @event.Id,
                Date = @event.Date,
                OOMPoints = oomPointsToReturn.ToList(),
                Cards = cardsToReturn.ToList()

            };


            return Ok(resultsToReturn);

        }

        [HttpGet("Events/EventResults/{id}")]
        public async Task<IActionResult> EventResults(Guid id)
        {
            var @event = await _repository.GetById(id);

            return View(@event);
        }

        [HttpGet("Events/{id}/Draw")]
        public async Task<IActionResult> Draw(Guid id)
        {
            var @event = await _repository.GetById(id);

            @event.Entries.GroupBy(e => e.Group);

            var entriesInGroups =
                from entry in @event.Entries
                group entry by entry.Group into newGroup
                orderby newGroup.Key
                select newGroup;

            var viewModel = new EventDrawViewModel()
            {
                Event = @event,
                GroupedEntries = entriesInGroups
            };

            return View(viewModel);
        }

        [HttpPost("api/events/draw/{id}")]
        public async Task<IActionResult> CreateDrawApi(Guid id)
        {
            var @event = await _repository.GetById(id);

            @event.Entries = @event.Entries.OrderBy(a => Guid.NewGuid()).ToList();

            foreach (var entry in @event.Entries)
            {
                if (entry.Marker != null)
                {
                    entry.Marker = null;
                    _context.Entries.Update(entry);
                }
            }

            _context.SaveChanges();

            int size = 4;

            var results = @event.Entries.Select((x, i) => new { Key = i / size, Value = x })
                                   .GroupBy(x => x.Key, x => x.Value, (k, g) => g.ToList())
                                   .ToList();

            var remainderResults = results.Count() % 4;

            int maxGroups = results.Count() / 4;

            var entriesRemainder = @event.Entries.Count() % 4;
            double totalEntries = Convert.ToDouble(@event.Entries.Count);

            double maxEntryGroups = Math.Round(totalEntries / 4, MidpointRounding.AwayFromZero);

            if (entriesRemainder > 0)
            {
                maxEntryGroups = maxEntryGroups + 1;

                if (entriesRemainder == 1)
                {
                    results[Convert.ToInt32(maxEntryGroups - 1)].Add(results[0][0]);
                    results[0].Remove(results[0][0]);
                }
            }

            for (int i = 0; i < results.Count(); i++)
            {
                int group = i + 1;

                for (int j = 0; j < results[i].Count(); j++)
                {
                    results[i][j].Group = group;
                    _context.Entries.Update(results[i][j]);
                }

            }


            _context.SaveChanges();


            var entriesInGroups =
                    from entry in @event.Entries
                    group entry by entry.Group into newGroup
                    orderby newGroup.Key
                    select newGroup;

            foreach (var group in entriesInGroups)
            {
                var groupEntries = group.ToList();

                if (group.Count() == 2)
                {
                    groupEntries[0].Marker = groupEntries[1].ScoreCard;
                    _context.Entries.Update(groupEntries[0]);
                    groupEntries[1].Marker = groupEntries[0].ScoreCard;
                    _context.Entries.Update(groupEntries[1]);
                }

                if (group.Count() == 3)
                {
                    groupEntries[0].Marker = groupEntries[2].ScoreCard;
                    groupEntries[1].Marker = groupEntries[0].ScoreCard;
                    groupEntries[2].Marker = groupEntries[1].ScoreCard;
                    _context.Entries.UpdateRange(groupEntries);
                }

                if (group.Count() == 4)
                {
                    groupEntries[0].Marker = groupEntries[2].ScoreCard;
                    groupEntries[1].Marker = groupEntries[3].ScoreCard;
                    groupEntries[2].Marker = groupEntries[1].ScoreCard;
                    groupEntries[3].Marker = groupEntries[0].ScoreCard;

                    _context.Entries.UpdateRange(groupEntries);
                }
            }



            var viewModel = new EventDrawViewModel()
            {
                Event = @event,
                GroupedEntries = entriesInGroups
            };


            @event.Drawn = true;

            _context.SaveChanges();

            var entsToReturn = Mapper.Map<IEnumerable<EventEntryDto>>(@event.Entries);

            var updatedEntriesInGroups =
                from entry in entsToReturn
                group entry by entry.Group into newGroup
                orderby newGroup.Key
                select newGroup;

            //foreach(var entry in upDatedEntriesInGroups)
            //{
            //    Mapper.Map<E>
            //}


            //var drawToReturn = new EventDrawDto()
            //{
            //    GroupedEntries = groupedEntriesToReturn
            //};

            return Ok(updatedEntriesInGroups);

        }


        [HttpPost("Events/{id}/Draw")]
        public async Task<IActionResult> CreateDraw(Guid id)
        {
            var @event = await _repository.GetById(id);

            @event.Entries = @event.Entries.OrderBy(a => Guid.NewGuid()).ToList();

            foreach (var entry in @event.Entries)
            {
                if (entry.Marker != null)
                {
                    entry.Marker = null;
                    _context.Entries.Update(entry);
                }
            }


            _context.SaveChanges();

            int size = 4;

            var results = @event.Entries.Select((x, i) => new { Key = i / size, Value = x })
                                   .GroupBy(x => x.Key, x => x.Value, (k, g) => g.ToList())
                                   .ToList();

            var remainderResults = results.Count() % 4;

            int maxGroups = results.Count() / 4;

            var entriesRemainder = @event.Entries.Count() % 4;
            double totalEntries = Convert.ToDouble(@event.Entries.Count);

            double maxEntryGroups = Math.Round(totalEntries / 4, MidpointRounding.AwayFromZero);

            if (entriesRemainder > 0)
            {
                maxEntryGroups = maxEntryGroups + 1;

                if (entriesRemainder == 1)
                {
                    results[Convert.ToInt32(maxEntryGroups - 1)].Add(results[0][0]);
                    results[0].Remove(results[0][0]);
                }
            }

            for (int i = 0; i < results.Count(); i++)
            {
                int group = i + 1;

                for (int j = 0; j < results[i].Count(); j++)
                {
                    results[i][j].Group = group;
                    _context.Entries.Update(results[i][j]);
                }

            }


            _context.SaveChanges();


            var entriesInGroups =
                    from entry in @event.Entries
                    group entry by entry.Group into newGroup
                    orderby newGroup.Key
                    select newGroup;

            foreach(var group in entriesInGroups)
            {
                    var groupEntries = group.ToList();

                    if (group.Count() == 2)
                    {
                        groupEntries[0].Marker = groupEntries[1].ScoreCard;
                        _context.Entries.Update(groupEntries[0]);
                        groupEntries[1].Marker = groupEntries[0].ScoreCard;
                        _context.Entries.Update(groupEntries[1]);
                    }

                    if (group.Count() == 3)
                    {
                        groupEntries[0].Marker = groupEntries[2].ScoreCard;
                        groupEntries[1].Marker = groupEntries[0].ScoreCard;
                        groupEntries[2].Marker = groupEntries[1].ScoreCard;
                        _context.Entries.UpdateRange(groupEntries);
                    }

                    if (group.Count() == 4)
                    {
                        groupEntries[0].Marker = groupEntries[2].ScoreCard;
                        groupEntries[1].Marker = groupEntries[3].ScoreCard;
                        groupEntries[2].Marker = groupEntries[1].ScoreCard;
                        groupEntries[3].Marker = groupEntries[0].ScoreCard;

                        _context.Entries.UpdateRange(groupEntries);
                }
            }

            @event.Drawn = true;

            _context.SaveChanges();



            return RedirectToAction("Draw", new { id });
        }

        [HttpPost("api/events/close/{id}")]
        public async Task<IActionResult> CloseEventApi(Guid id){
            var @event = await _repository.GetById(id);

            var entries = @event.Entries.OrderByDescending(e => e.ScoreCard.TotalPoints)
                .ThenByDescending(e => e.ScoreCard.InPoints)
                .ThenByDescending(e => e.ScoreCard.LastSixPoints)
                .ThenByDescending(e => e.ScoreCard.LastThreePoints).ToList();

            var sweep = _context.Sweeps.Where(s => s.Events.Any(e => e.Id == @event.Id)).FirstOrDefault();



            if (@event.Complete)
            {
                await _pointsRepository.DeleteEventOOMPoints(@event);
                await _handicapRepository.DeleteEventHandicaps(@event.Id);
            }


            await _handicapRepository
                .UpdateEventHandicaps(entries, @event, sweep);

            _pointsRepository.CreateEventOOMPoints(@event, entries, sweep);

            @event.Complete = true;

            if (! await _repository.SaveChanges())
            {
                throw new Exception($"Failed to close event id {@event.Id}");
            }

            var eventToReturn = Mapper.Map<EventDto>(@event);

            return Ok(eventToReturn);
        }


        [HttpPost("Sweeps/{sweepId}/Event/{id}/Entries")]
        public async Task<IActionResult> CloseEvent(Guid id, Guid sweepId)
        {
            var @event = await _repository.GetById(id);

            var entries = @event.Entries.OrderByDescending(e => e.ScoreCard.TotalPoints)
                .ThenByDescending(e => e.ScoreCard.InPoints)
                .ThenByDescending(e => e.ScoreCard.LastSixPoints)
                .ThenByDescending(e => e.ScoreCard.LastThreePoints).ToList();

            var sweep = await _sweepRepository.GetById(sweepId);

            var oomList = new List<OOMPoints>();
            var newHandicapList = new List<Handicap>();

            if (@event.Complete)
            {
                await _handicapRepository.DeleteEventHandicaps(@event.Id);
            }

            //var handicapsAlreadyChanged = _context.Handicaps.Where(h => h.EventId == @event.Id);

            //if (handicapsAlreadyChanged.Any())
            //{
            //    foreach(var handicap in handicapsAlreadyChanged.ToList())
            //    {
            //        _context.Handicaps.Remove(handicap);
            //    }

            //    _context.SaveChanges();
            //}

            for (int i = 0; i < entries.Count(); i++)
            {
                int position = i + 1;
                //var points = CalculateOOMPoints(position, entries.Count());

                var points = _pointsRepository
                    .CalculateOOMPoints(position, entries.Count(), sweep.Rules);

                var oomPoints = new OOMPoints()
                {
                    Id = Guid.NewGuid(),
                    Player = entries[i].ScoreCard.Player,
                    Card = entries[i].ScoreCard,
                    Position = position,
                    Points = points,
                    Sweep = sweep,
                    Created = DateTimeOffset.Now

                };


                @event.OOMPoints.Add(oomPoints);

                //var newHandicap = CalculateNewHandicap(entries[i].ScoreCard.Player.CurrentExactHandicap,
                //    entries[i].ScoreCard.TotalPoints, position);


                //var currentExactHandicap = _context.Handicaps.Where(h => h.PlayerId == entries[i].ScoreCard.Player.Id
                //        && h.SweepId == sweep.Id)
                //        .OrderByDescending(h => h.Created)
                //        .Select(h => h.Exact)
                //        .FirstOrDefault();

                var currentExactHandicap = await _sweepRepository.GetPlayerCurrentExactSweepHandicap(sweep.Id, entries[i].ScoreCard.Player.Id);
                var currentPlayingHandicap = await _sweepRepository.GetPlayerCurrentPlayingSweepHandicap(sweep.Id, entries[i].ScoreCard.Player.Id);
                double newHandicap = 0;

                    if (sweep.Rules.CutHandicaps)
                    {
                        if (sweep.Rules.CutHandicapsByStableFordPoints)
                        {
                        //newHandicap = _handicapRepository.CalculateNewHandicapFromStableFordPoints(
                        //    currentExactHandicap,
                        //    entries[i].ScoreCard.TotalPoints, position, sweep.Rules);

                        newHandicap = _handicapRepository.CalculateNewHandicapFromGerrysRules(
                            currentExactHandicap,
                            entries[i].ScoreCard.TotalPoints, position, sweep.Rules);

                    }
                    else
                        {
                            newHandicap = _handicapRepository.CalculateNewHandicapStandard(currentExactHandicap,
                                currentPlayingHandicap, entries[i].ScoreCard, entries[i].ScoreCard.Course, sweep);
                        }
                    }



                if (newHandicap != currentExactHandicap)
                {
                    var handicapToAdd = new Handicap()
                    {
                        Player = entries[i].ScoreCard.Player,
                        Exact = newHandicap,
                        Playing = Convert.ToInt32(Math.Round(newHandicap)),
                        Created = DateTimeOffset.Now,
                        SweepId = sweep.Id,
                        EventId = @event.Id

                    };

                    //_context.Handicaps.Add(handicapToAdd);
                    newHandicapList.Add(handicapToAdd);
                }

            }


            _context.Handicaps.AddRange(newHandicapList);

            @event.Complete = true;

            await _context.SaveChangesAsync();

            return RedirectToAction("EventResults", "Events", new { id = @event.Id } );

        }


        public double CalculateNewHandicap(double currentHandicap, int totalPoints, int position)
        {
            double newHandicap = 0;
            double cutRate = 0;

            if (position <= 3)
            {
                if (totalPoints < 38)
                {
                    totalPoints = 38;
                }
            }


            if (currentHandicap <= 5.4)
            {
                cutRate = 0.1;
            }

            if (currentHandicap >= 5.5 && currentHandicap <= 12.4)
            {
                cutRate = 0.2;
            }

            if (currentHandicap >= 12.5 && currentHandicap <= 30)
            {
                cutRate = 0.3;
            }

            if (totalPoints <= 35)
            {
                newHandicap = currentHandicap + 0.1;
            }

            if (totalPoints >= 37)
            {
                var change = totalPoints - 36;
                if (position == 1)
                {
                    var c = Math.Round((change * cutRate) * 2, 1);
                    newHandicap = currentHandicap - c;
                }
                if (position == 2 || position == 3)
                {
                    var c = Math.Round((change * cutRate) * 1.5, 1);
                    newHandicap = currentHandicap - c;
                }
                if (position >= 4)
                {
                    var c = Math.Round((change * cutRate), 1);
                    newHandicap = currentHandicap - c;
                }
            }


            newHandicap = Math.Round(newHandicap, 1);

            return newHandicap;
        }

        public int CalculateOOMPoints(int position, int entries)
        {
            var points = 0;

            if (entries <= 10)
            {
                switch (position)
                {
                    case 1:
                        points = 10;
                        break;
                    case 2:
                        points = 8;
                        break;
                    case 3:
                        points = 7;
                        break;
                    case 4:
                        points = 6;
                        break;
                    case 5:
                        points = 5;
                        break;
                    case 6:
                        points = 4;
                        break;
                    case 7:
                        points = 3;
                        break;
                    case 8:
                        points = 2;
                        break;
                    default:
                        points = 1;
                        break;
                }
            }

            if (entries >= 11 && entries <= 15)
            {
                switch (position)
                {
                    case 1:
                        points = 15;
                        break;
                    case 2:
                        points = 12;
                        break;
                    case 3:
                        points = 10;
                        break;
                    case 4:
                        points = 8;
                        break;
                    case 5:
                        points = 7;
                        break;
                    case 6:
                        points = 6;
                        break;
                    case 7:
                        points = 5;
                        break;
                    case 8:
                        points = 4;
                        break;
                    case 9:
                        points = 3;
                        break;
                    case 10:
                        points = 2;
                        break;

                    default:
                        points = 1;
                        break;
                }
            }

            if (entries >= 16 && entries <= 20)
            {
                switch (position)
                {
                    case 1:
                        points = 20;
                        break;
                    case 2:
                        points = 16;
                        break;
                    case 3:
                        points = 13;
                        break;
                    case 4:
                        points = 11;
                        break;
                    case 5:
                        points = 9;
                        break;
                    case 6:
                        points = 8;
                        break;
                    case 7:
                        points = 7;
                        break;
                    case 8:
                        points = 6;
                        break;
                    case 9:
                        points = 5;
                        break;
                    case 10:
                        points = 4;
                        break;
                    case 11:
                        points = 3;
                        break;
                    case 12:
                        points = 2;
                        break;
                    
                    default:
                        points = 1;
                        break;
                }
            }


            if (entries >= 21 && entries <= 25)
            {
                switch (position)
                {
                    case 1:
                        points = 25;
                        break;
                    case 2:
                        points = 20;
                        break;
                    case 3:
                        points = 16;
                        break;
                    case 4:
                        points = 13;
                        break;
                    case 5:
                        points = 11;
                        break;
                    case 6:
                        points = 10;
                        break;
                    case 7:
                        points = 9;
                        break;
                    case 8:
                        points = 8;
                        break;
                    case 9:
                        points = 7;
                        break;
                    case 10:
                        points = 6;
                        break;
                    case 11:
                        points = 5;
                        break;
                    case 12:
                        points = 4;
                        break;
                    case 13:
                        points = 3;
                        break;
                    case 14:
                        points = 2;
                        break;
                    default:
                        points = 1;
                        break;
                }
            }


            if (entries >= 26 && entries <= 30)
            {
                switch (position)
                {
                    case 1:
                        points = 30;
                        break;
                    case 2:
                        points = 24;
                        break;
                    case 3:
                        points = 19;
                        break;
                    case 4:
                        points = 15;
                        break;
                    case 5:
                        points = 13;
                        break;
                    case 6:
                        points = 12;
                        break;
                    case 7:
                        points = 11;
                        break;
                    case 8:
                        points = 10;
                        break;
                    case 9:
                        points = 9;
                        break;
                    case 10:
                        points = 9;
                        break;
                    case 11:
                        points = 8;
                        break;
                    case 12:
                        points = 7;
                        break;
                    case 13:
                        points = 6;
                        break;
                    case 14:
                        points = 5;
                        break;
                    case 15:
                        points = 4;
                        break;
                    case 16:
                        points = 3;
                        break;
                    case 17:
                        points = 2;
                        break;

                    default:
                        points = 1;
                        break;
                }
            }


            if (entries >= 31 && entries <= 35)
            {
                switch (position)
                {
                    case 1:
                        points = 35;
                        break;
                    case 2:
                        points = 28;
                        break;
                    case 3:
                        points = 22;
                        break;
                    case 4:
                        points = 17;
                        break;
                    case 5:
                        points = 15;
                        break;
                    case 6:
                        points = 14;
                        break;
                    case 7:
                        points = 13;
                        break;
                    case 8:
                        points = 12;
                        break;
                    case 9:
                        points = 11;
                        break;
                    case 10:
                        points = 10;
                        break;
                    case 11:
                        points = 9;
                        break;
                    case 12:
                        points = 8;
                        break;
                    case 13:
                        points = 7;
                        break;
                    case 14:
                        points = 6;
                        break;
                    case 15:
                        points = 5;
                        break;
                    case 16:
                        points = 4;
                        break;
                    case 17:
                        points = 3;
                        break;
                    case 18:
                        points = 2;
                        break;


                    default:
                        points = 1;
                        break;
                }
            }


            if (entries >= 36 && entries <= 40)
            {
                switch (position)
                {
                    case 1:
                        points = 40;
                        break;
                    case 2:
                        points = 32;
                        break;
                    case 3:
                        points = 25;
                        break;
                    case 4:
                        points = 19;
                        break;
                    case 5:
                        points = 17;
                        break;
                    case 6:
                        points = 16;
                        break;
                    case 7:
                        points = 15;
                        break;
                    case 8:
                        points = 14;
                        break;
                    case 9:
                        points = 13;
                        break;
                    case 10:
                        points = 12;
                        break;
                    case 11:
                        points = 11;
                        break;
                    case 12:
                        points = 10;
                        break;
                    case 13:
                        points = 9;
                        break;
                    case 14:
                        points = 8;
                        break;
                    case 15:
                        points = 7;
                        break;
                    case 16:
                        points = 6;
                        break;
                    case 17:
                        points = 5;
                        break;
                    case 18:
                        points = 4;
                        break;
                    case 19:
                        points = 3;
                        break;
                    case 20:
                        points = 2;
                        break;

                    default:
                        points = 1;
                        break;
                }
            }


            return points;
        }


        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var @event = await _context.Events
            //    .FirstOrDefaultAsync(m => m.Id == id);

            var @event = await _repository.GetById(id.Value);

            if (@event == null)
            {
                return NotFound();
            }

            return View(@event);
        }

        // GET: Events/Create
        [Route("Sweeps/{sweepId}/Events/Create")]
        public IActionResult Create(Guid sweepId)
        {
            ViewData["CourseId"] = new SelectList(_context.Courses, "Id", "Name");
            return View();
        }

        // POST: Events/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Sweeps/{sweepId}/Events/Create")]
        public async Task<IActionResult> Create(Guid sweepId, Guid courseId, [Bind("Id,Date,WinterHandicaps")] Event @event)
        {
            if (ModelState.IsValid)
            {
                @event.Id = Guid.NewGuid();



                var sweep = _context.Sweeps.Where(s => s.Id == sweepId).FirstOrDefault();

                @event.Course = await _courseRepository.GetById(courseId);

                sweep.Events.Add(@event);
                //_context.Add(@event);

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CourseId"] = new SelectList(_context.Courses, "Id", "Name");

            return View(@event);
        }


        [HttpPost("api/events")]
        public async Task<IActionResult> CreateEventApi([FromBody] CreateEventDto @event)
        {

            var eventToAdd = new Event();

            eventToAdd.Id = Guid.NewGuid();
            eventToAdd.Created = DateTimeOffset.Now;
            eventToAdd.WinterHandicaps = @event.WinterHandicaps;
            eventToAdd.Date = @event.Date;

            var sweep = await _sweepRepository.GetById(@event.SweepId);
            eventToAdd.Course = await _courseRepository.GetById(@event.CourseId);

            sweep.Events.Add(eventToAdd);

            if (! await _repository.SaveChanges())
            {
                throw new Exception($"Failed to create event for sweep Id {sweep.Id}");
            }

            var eventFromRepo = await _repository.GetById(eventToAdd.Id);

            if (eventFromRepo == null)
            {
                return NotFound();
            }

            var eventToReturn = Mapper.Map<EventDto>(eventFromRepo);
            eventToReturn.PlayerNames = new List<PlayerEntryResponseDto>();

            return Ok(eventToReturn);
        }

        // GET: Events/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @event = await _context.Events.FindAsync(id);
            if (@event == null)
            {
                return NotFound();
            }
            return View(@event);
        }

        // POST: Events/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Date,WinterHandicaps")] Event @event)
        {
            if (id != @event.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(@event);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EventExists(@event.Id))
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
            return View(@event);
        }

        // GET: Events/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @event = await _context.Events
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@event == null)
            {
                return NotFound();
            }

            return View(@event);
        }

        // POST: Events/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var @event = await _context.Events.FindAsync(id);
            _context.Events.Remove(@event);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EventExists(Guid id)
        {
            return _context.Events.Any(e => e.Id == id);
        }
    }


}
