using GolfSweep.Data;
using GolfSweep.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfSweep.Repositories
{
    public class PlayerRepository : Repository<Player>, IPlayerRepository
    {
        private readonly ApplicationDbContext _context;

        public PlayerRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Event>> GetPlayerEvents(Guid playerId)
        {
            var events = _context.Events
                .Where(e => e.Entries.Any(en => en.ScoreCard.PlayerId == playerId));

            return await events.ToListAsync();
        }

        public Task<Player> GetUserPlayer(string userId)
            => FirstOrDefault(p => p.UserId == userId);

        

        public async Task<List<Guid>> GetSweepIdsWherePlayerIsAdmin(Guid playerId)
        {
            return await _context.SweepPlayers
                .Where(sp => sp.PlayerId == playerId && sp.IsAdmin)
                .Select(sp => sp.SweepId).ToListAsync();
        }


    }
}
