using GolfSweep.Data;
using GolfSweep.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfSweep.Repositories.Interfaces
{
    public interface IPlayerRepository : IRepository<Player>
    {
        Task<IEnumerable<Event>> GetPlayerEvents(Guid playerId);
        Task<Player> GetUserPlayer(string userId);

        Task<List<Guid>> GetSweepIdsWherePlayerIsAdmin(Guid playerId);
    }
}
