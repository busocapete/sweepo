using GolfSweep.Data;
using GolfSweep.Dtos;
using GolfSweep.Repositories;
using GolfSweep.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfSweep.Repositories
{
    public class EventRepository : Repository<Event>, IEventRepository
    {
        private readonly ApplicationDbContext _context;

        public EventRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<bool> PlayerHasJoinedEvent(Guid eventId, Player player)
        {
            var @event = await GetById(eventId);

            return @event.Entries
                .Any(e => e.ScoreCard.Player.Id == player.Id);
        }

        public async Task<List<PlayerEntryResponseDto>> GetEventPlayerNames(Guid eventId)
        {
            var @event = await GetById(eventId);

            List<PlayerEntryResponseDto> playerNames = new List<PlayerEntryResponseDto>();

            foreach (var player in @event.Entries)
            {
                var playerToAdd = new PlayerEntryResponseDto()
                {
                    Id = player.Id,
                    Name = player.ScoreCard.Player.FullName
                };

                playerNames.Add(playerToAdd);
            }

            playerNames = playerNames.OrderBy(p => p.Name).ToList();

            return playerNames;
        }

    }
}
