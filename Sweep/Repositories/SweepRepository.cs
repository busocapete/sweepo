using AutoMapper;
using GolfSweep.Data;
using GolfSweep.Dtos;
using GolfSweep.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfSweep.Repositories
{
    public class SweepRepository : Repository<Data.Sweep>, ISweepRepository
    {
        private readonly ApplicationDbContext _context;

        public SweepRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public Task<Data.Sweep> GetSweepWithOwner(Guid id) => FirstOrDefault(s => s.Id == id);

        public async Task<IEnumerable<Data.Sweep>> GetSweeps()
        {
            return await _context.Sweeps
                .Include(m => m.Owner)
                .ToListAsync();
        }

        public async Task<Data.Sweep> GetSweep(Guid id)
        {
            return await _context.Sweeps
                .Include(m => m.Owner)
                .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<Guid> GetSweepIdFromEventId(Guid eventId)
        {
            return await _context.Sweeps.Where(s => s.Events
                .Any(e => e.Id == eventId))
                .Select(s => s.Id)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<IGrouping<Player, OOMPoints>>> GetOOMPointsForSweep(Guid id)
        {
            var sweep = await GetById(id);

            var oom = new List<OOMPoints>();

            foreach (var @event in sweep.Events.ToList())
            {
                oom.AddRange(@event.OOMPoints);
            }

            var oomPointsToReturn = oom.GroupBy(o => o.Player);

            return oomPointsToReturn;
        }

        public async Task<bool> UserIsSweepOwner(Guid id, ApplicationUser user)
        {
            var sweep = await GetById(id);
            var userIsOwner = false;

            if (sweep.Owner == user)
            {
                userIsOwner = true;
            }

            return userIsOwner;
        }

        public async Task<IOrderedEnumerable<Player>> GetSweepMembers(Guid id)
        {
            var sweep = await GetById(id);

            var members = sweep.Members.Where(m => m.Approved)
                .Select(m => m.Player)
                .OrderBy(m => m.FullName);

            return members;
        }

        public async Task<double> GetPlayerCurrentExactSweepHandicap(Guid sweepId, Guid playerId)
        {
            return await _context.Handicaps
                .Where(h => h.PlayerId == playerId
                && h.SweepId == sweepId)
                .OrderByDescending(h => h.Created)
                .Select(h => h.Exact)
                .FirstOrDefaultAsync();
        }


        public int GetPlayerCurrentPlayingSweepHandicap(double exact)
        {
            double handicap;

            if (exact > 0)
            {
                handicap = Math.Round(exact, MidpointRounding.AwayFromZero);
            }
            else
            {
                handicap = Math.Round(exact, MidpointRounding.ToEven);
            }

            return Convert.ToInt32(handicap);
        }

        public async Task<int> GetPlayerCurrentPlayingSweepHandicap(Guid sweepId, Guid playerId)
        {
            var exact = await GetPlayerCurrentExactSweepHandicap(sweepId, playerId);
            return GetPlayerCurrentPlayingSweepHandicap(exact);
        }



        public async Task<IEnumerable<Player>> GetSweepRequestsToJoin(Guid sweepId)
        {
            var sweep = await GetById(sweepId);

            return sweep.Members.Where(m => !m.Approved)
                .Select(m => m.Player);
        }




        public bool PlayerIsSweepMember(Guid id, Player player)
        {
            return _context.SweepPlayers
                .Any(s => s.PlayerId == player.Id
                && s.SweepId == id);
        }

        public bool PlayerIsApprovedForSweep(Guid id, Player player)
        {
            bool approved = false;

            var member = _context.SweepPlayers
                .Where(s => s.PlayerId == player.Id && s.SweepId == id)
                .FirstOrDefault();

            if (member == null)
                return approved;

            if (member.Approved)
                approved = true;

            return approved;
        }




        public async Task<List<LeaderboardDto>> GetLeaderboardForSweep(Guid id)
        {
            var sweep = await GetById(id);

            var oomPoints = await GetOOMPointsForSweep(id);

            var leaderBoard = new List<LeaderboardDto>();

            foreach (var player in oomPoints)
            {
                var totalPoints = 0;
                var i = 1;

                foreach (var points in player)
                {

                    totalPoints = totalPoints + points.Points;

                    if (i == player.Count())
                    {
                        //var played = sweep.Events
                        //    .Where(e => e.Complete == true && e.Entries.Any(en => en.ScoreCard.Player.Id == points.Player.Id)).ToList();

                        var played = _context.OOMPoints
                            .Where(o => o.Player.Id == points.Player.Id
                            && o.Sweep.Id == id);

                        var playedToReturn = Mapper.Map<IEnumerable<OOMForLeaderBoardDto>>(played);

                        var events = new List<OOMForLeaderBoardDto>();

                        foreach (var @event in played.ToList())
                        {
                            var ev = _context.Events.Where(e => e.OOMPoints.Any(om => om.Id == @event.Id)).FirstOrDefault();

                            if (ev != null)
                            {
                                var eventToAdd = new EventForLeaderBoardDto()
                                {
                                    SweepName = sweep.Name,
                                    Date = ev.Date
                                };

                                var oomEventToAdd = new OOMForLeaderBoardDto
                                {
                                    Points = @event.Points,
                                    Position = @event.Position,
                                    Event = eventToAdd
                                };
                                events.Add(oomEventToAdd);
                            }
                        }
                        var leaderBoardEntryToAdd = new LeaderboardDto()
                        {
                            Id = points.Player.Id,
                            FullName = points.Player.FullName,
                            TotalPoints = totalPoints,
                            Played = events.Count(),
                            Events = events.OrderByDescending(e => e.Event.Date).ToList()
                        };

                        leaderBoard.Add(leaderBoardEntryToAdd);
                        i = 1;
                    }
                    i++;
                }
            }

            leaderBoard = leaderBoard.OrderByDescending(l => l.TotalPoints).ToList();

            for (int i = 0; i < leaderBoard.Count(); i++)
            {
                leaderBoard[i].Position = i + 1;
            }

            return leaderBoard;
        }
    }
}
