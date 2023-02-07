using GolfSweep.Data;
using GolfSweep.Dtos;
using GolfSweep.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfSweep.Repositories.Interfaces
{
    public interface IEventRepository : IRepository<Event>
    {
        Task<bool> PlayerHasJoinedEvent(Guid eventId, Player player);
        Task<List<PlayerEntryResponseDto>> GetEventPlayerNames(Guid eventId);

    }
}
