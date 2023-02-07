using GolfSweep.Data;
using GolfSweep.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfSweep.Repositories.Interfaces
{
    public interface ISweepRepository : IRepository<Data.Sweep>
    {
        Task<IEnumerable<Data.Sweep>> GetSweeps();
        Task<Data.Sweep> GetSweep(Guid id);

        Task<Data.Sweep> GetSweepWithOwner(Guid Id);

        Task<List<LeaderboardDto>> GetLeaderboardForSweep(Guid id);
        Task<bool> UserIsSweepOwner(Guid id, ApplicationUser user);
        Task<IOrderedEnumerable<Player>> GetSweepMembers(Guid id);

        Task<double> GetPlayerCurrentExactSweepHandicap(Guid sweepId, Guid playerId);
        int GetPlayerCurrentPlayingSweepHandicap(double exact);
        Task<int> GetPlayerCurrentPlayingSweepHandicap(Guid sweepId, Guid playerId);

        Task<Guid> GetSweepIdFromEventId(Guid eventId);



        Task<IEnumerable<Player>> GetSweepRequestsToJoin(Guid sweepId);

        bool PlayerIsSweepMember(Guid id, Player player);
        bool PlayerIsApprovedForSweep(Guid id, Player player);


    }
}
