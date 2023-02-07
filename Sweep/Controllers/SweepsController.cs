using AutoMapper;
using GolfSweep.Data;
using GolfSweep.Dtos;
using GolfSweep.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sweep.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfSweep.Controllers
{
    public class SweepsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IRepository<Data.Sweep> _repository;
        private readonly ISweepRepository _sweepRepository;
        private readonly IPlayerRepository _playerRepository;
        private readonly IEventRepository _eventRepository;

        public SweepsController(ApplicationDbContext context,
            UserManager<ApplicationUser> userManager,
            IRepository<Data.Sweep> repository,
            ISweepRepository sweepRepository,
            IPlayerRepository playerRepository,
            IEventRepository eventRepository)
        {
            _context = context;
            _userManager = userManager;
            _repository = repository;
            _sweepRepository = sweepRepository;
            _playerRepository = playerRepository;
            _eventRepository = eventRepository;

        }

        [Route("api/sweeps/{id}")]
        public async Task<IActionResult> GetSweep(Guid id)
        {
            var sweep = await _repository.GetById(id);

            var eventsToReturn = Mapper.Map<IEnumerable<EventDto>>(sweep.Events);

            var user = await _userManager.GetUserAsync(User);
            var userPlayer = await _playerRepository.GetUserPlayer(user.Id);

            foreach (var @event in eventsToReturn)
            {
                @event.UserHasJoined = await _eventRepository.PlayerHasJoinedEvent(@event.Id, userPlayer);

                @event.PlayerNames = await _eventRepository.GetEventPlayerNames(@event.Id);
            }

            var leaderBoard = await _sweepRepository.GetLeaderboardForSweep(id);

            var membersFromRepo = await _sweepRepository.GetSweepMembers(id);
            var members = Mapper.Map<IEnumerable<PlayerDto>>(membersFromRepo);

            foreach (var player in members)
            {
                player.CurrentExactHandicap = await _sweepRepository
                    .GetPlayerCurrentExactSweepHandicap(id, player.Id);

                player.CurrentHandicap = _sweepRepository
                    .GetPlayerCurrentPlayingSweepHandicap(player.CurrentExactHandicap);
            }


            var userIsOwner = await _sweepRepository.UserIsSweepOwner(id, user);

            var requests = new List<PlayerDto>();
            var courses = new List<CourseDto>();

            if (userIsOwner)
            {
                requests = Mapper.Map<IEnumerable<PlayerDto>>(await _sweepRepository
                    .GetSweepRequestsToJoin(id))
                    .ToList();

                courses = Mapper.Map<IEnumerable<CourseDto>>(_context.Courses)
                    .OrderBy(c => c.Name).ToList();
            }


            var sweepToReturn = new SweepDto()
            {
                Id = sweep.Id,
                Owner = sweep.Owner.FullName,
                Name = sweep.Name,
                TotalEvents = eventsToReturn.Count(),
                Events = eventsToReturn.OrderByDescending(e => e.Date).ToList(),
                OOM = leaderBoard,
                Members = members.ToList(),
                Requests = requests,
                Courses = courses
            };

            return Ok(sweepToReturn);
        }

        [Route("api/sweeps/admin")]
        public async Task<IActionResult> GetAdminSweeps()
        {
            var user = await _userManager.GetUserAsync(User);
            var sweeps = _context.Sweeps.Where(s => s.Owner.Id == user.Id);

            var sweepsToReturn = new List<SweepDto>();

            foreach (var sweep in sweeps)
            {
                var sweepToAdd = new SweepDto()
                {
                    Id = sweep.Id,
                    Name = sweep.Name,
                    Owner = sweep.Owner.FullName,
                    TotalEvents = sweep.Events.Count(),
                };

                sweepsToReturn.Add(sweepToAdd);

            }

            return Ok(sweepsToReturn);
        }

        [Route("api/sweeps")]
        public async Task<IActionResult> GetSweeps()
        {
            var user = await _userManager.GetUserAsync(User);
            var userPlayer = await _playerRepository.GetUserPlayer(user.Id);
            var sweeps = await _repository.GetAll();

            var sweepsToReturn = new List<SweepDto>();

            foreach (var sweep in sweeps)
            {
                var userIsMember = _sweepRepository.PlayerIsSweepMember(sweep.Id, userPlayer);

                bool approved = _sweepRepository.PlayerIsApprovedForSweep(sweep.Id, userPlayer);

                var sweepToAdd = new SweepDto()
                {
                    Id = sweep.Id,
                    Name = sweep.Name,
                    Owner = sweep.Owner.FullName,
                    TotalEvents = sweep.Events.Count(),
                    UserIsMember = userIsMember,
                    Approved = approved,
                    Created = sweep.Created
                };

                sweepsToReturn.Add(sweepToAdd);
            }

            return Ok(sweepsToReturn.OrderByDescending(s => s.Created));
        }

        [HttpPost("api/sweeps/join/{id}")]
        public async Task<IActionResult> EnterSweep(Guid id)
        {
            var user = await _userManager.GetUserAsync(User);
            var userPlayer = await _playerRepository.GetUserPlayer(user.Id);

            var sweepToJoin = await _repository.GetById(id);

            bool approved = false;

            if (sweepToJoin.Public)
            {
                approved = true;
            }

            var sweepEntry = new SweepPlayer()
            {
                SweepId = sweepToJoin.Id,
                PlayerId = userPlayer.Id,
                Approved = approved
            };

            var handicapToAdd = new Handicap()
            {
                Id = Guid.NewGuid(),
                Player = userPlayer,
                Playing = userPlayer.CurrentHandicap,
                Exact = userPlayer.CurrentExactHandicap,
                SweepId = id,
                Created = DateTimeOffset.Now
            };

            _context.Handicaps.Add(handicapToAdd);

            //_context.SweepPlayers.Add(sweepEntry);

            await _sweepRepository.AddEntity(sweepEntry);

            if (!await _repository.SaveChanges())
            {
                throw new Exception($"Failed to send Join Sweep Request for id {sweepToJoin.Id}");
            }

            var sweepEntryToReturn = Mapper.Map<SweepEntryDto>(sweepEntry);

            return Ok(sweepEntryToReturn);
        }

        [HttpPost("api/sweeps/approve")]
        public async Task<IActionResult> ApprovePlayer([FromBody] SweepApprovalDto dto)
        {
            var sweepPlayer = await _context.SweepPlayers
                .Where(s => s.PlayerId == dto.PlayerId
                && s.SweepId == dto.SweepId
                ).FirstOrDefaultAsync();

            sweepPlayer.Approved = true;

            if (!await _repository.SaveChanges())
            {
                throw new Exception($"Failed to approve playerId {dto.PlayerId}");
            }

            var player = await _playerRepository.GetById(sweepPlayer.PlayerId);

            var playerToReturn = Mapper.Map<PlayerDto>(player);


            return Ok(playerToReturn);
        }


        // GET: Sweeps
        public async Task<IActionResult> Index()
        {
            return View(await _repository.GetAll());
        }

        [HttpGet("api/sweeps/oom/{id}")]
        public async Task<IActionResult> GetOOMForSweep(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sweep = await _repository.GetById(id);

            if (sweep == null)
            {
                return NotFound();
            }

            var leaderBoard = await _sweepRepository.GetLeaderboardForSweep(id);

            return Ok(leaderBoard);
        }


        public async Task<IActionResult> OOM(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sweep = await _repository.GetById(id);

            if (sweep == null)
            {
                return NotFound();
            }

            var leaderBoard = await _sweepRepository.GetLeaderboardForSweep(id);

            return View(leaderBoard);
        }

        // GET: Sweeps/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var sweep = await _sweepRepository.GetSweep(id.Value);

            var sweep = await _repository.GetById(id.Value);

            var oom = new List<OOMPoints>();

            foreach (var @event in sweep.Events.ToList())
            {
                oom.AddRange(@event.OOMPoints);
            }

            oom.GroupBy(o => o.Player);

            //var sweep = await _sweepRepository.GetSweepWithOwner(id.Value);

            if (sweep == null)
            {
                return NotFound();
            }

            return View(sweep);
        }

        // GET: Sweeps/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sweeps/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Created")] Data.Sweep sweep)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(User);
                sweep.Owner = user;
                sweep.Created = DateTimeOffset.Now;
                sweep.Id = Guid.NewGuid();

                sweep.Rules = new SweepRules()
                {
                    Id = Guid.NewGuid(),
                    CutHandicaps = true,
                    WinnerCut = 1,
                    SecondCut = 1,
                    ThirdCut = 1,
                    MinPointsForCut = 36,
                    OrderOfMerit = true,
                    OOMEntriesScale = false

                };

                await _repository.AddEntity(sweep);
                //_context.Add(sweep);
                //await _context.SaveChangesAsync();
                if (await _repository.SaveChanges())
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(sweep);
        }


        [HttpPost("api/sweeps/createSweep")]
        public async Task<IActionResult> CreateSweepApi([FromBody] CreateSweepDto sweep)
        {
            var user = await _userManager.GetUserAsync(User);

            var sweepToAdd = new Data.Sweep()
            {
                Id = Guid.NewGuid(),
                Created = DateTimeOffset.Now,
                Owner = user,
                Name = sweep.Name
            };

            if (sweep.Public)
            {
                sweepToAdd.Public = sweep.Public;
            }

            var userPlayer = await _playerRepository.GetUserPlayer(user.Id);

            var sweepPlayerToAdd = new SweepPlayer()
            {
                PlayerId = userPlayer.Id,
                Player = userPlayer,
                Sweep = sweepToAdd,
                SweepId = sweepToAdd.Id,
                Approved = true
            };

            var handicapToAdd = new Handicap()
            {
                Id = Guid.NewGuid(),
                PlayerId = userPlayer.Id,
                SweepId = sweepToAdd.Id,
                Created = DateTimeOffset.Now,
                Exact = userPlayer.CurrentExactHandicap,
                Playing = userPlayer.CurrentHandicap
            };

            sweepToAdd.Rules = new SweepRules()
            {
                Id = Guid.NewGuid(),
                CutHandicaps = true,
                WinnerCut = 1,
                SecondCut = 1,
                ThirdCut = 1,
                MinPointsForCut = 36,
                OrderOfMerit = true,
                OOMEntriesScale = false

            };


            await _repository.AddEntity(sweepToAdd);
            _context.SweepPlayers.Add(sweepPlayerToAdd);
            _context.Handicaps.Add(handicapToAdd);
            //sweepToAdd.Members.Add(createSweepPlayer);



            if (!await _repository.SaveChanges())
            {
                throw new Exception($"Failed to create new sweep for user {user.Id}");
            }

            //var sweepFromRepo = await _repository.GetById(sweepToAdd.Id);
            //var sweepToReturn = Mapper.Map<SweepDto>(sweepFromRepo);

            var sweepToReturn = new SweepDto()
            {
                Id = sweepToAdd.Id,
                Name = sweepToAdd.Name,
                Owner = sweepToAdd.Owner.FullName,
                TotalEvents = 0,
                UserIsMember = true,
                Approved = true
            };

            return Ok(sweepToReturn);
        }

        // GET: Sweeps/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sweep = await _context.Sweeps.FindAsync(id);

            if (sweep == null)
            {
                return NotFound();
            }

            return View(sweep);
        }

        // POST: Sweeps/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Name,Created")] Data.Sweep sweep)
        {
            if (id != sweep.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sweep);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SweepExists(sweep.Id))
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
            return View(sweep);
        }




        // GET: Sweeps/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sweep = await _context.Sweeps
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sweep == null)
            {
                return NotFound();
            }

            return View(sweep);
        }

        // POST: Sweeps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var sweep = await _context.Sweeps.FindAsync(id);
            _context.Sweeps.Remove(sweep);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SweepExists(Guid id)
        {
            return _context.Sweeps.Any(e => e.Id == id);
        }


        public IActionResult AddPlayersToNewSweep()
        {
            var gerrysSweep = _context.Sweeps.Where(s => s.Id == new Guid("99f79f8d-9844-43bb-ba91-26f2b6567ec3")).FirstOrDefault();

            var newSweep = _context.Sweeps.Where(s => s.Id == new Guid("941F9FBE-FD15-4830-B5E1-91ABBCAEAF71")).FirstOrDefault();

            var players = gerrysSweep.Members;

            foreach (var player in players)
            {
                if (player.PlayerId != new Guid("54f76aa1-1876-463f-afb2-6f3c13fa25bc"))
                {
                    var sweepPlayerToAdd = new SweepPlayer()
                    {
                        PlayerId = player.PlayerId,
                        SweepId = newSweep.Id,
                        Approved = true
                    };

                    _context.SweepPlayers.Add(sweepPlayerToAdd);

                    _context.SaveChanges();
                }

            }

            return View();
            
        }
    }
}
