using GolfSweep.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfSweep.Repositories.Interfaces
{
    public interface IOOMPointsRepository : IRepository<OOMPoints>
    {
        int CalculateOOMPoints(int position, int entriesCount, SweepRules rules);
        Task DeleteEventOOMPoints(Event @event);
        void CreateEventOOMPoints(Event @event, List<Entry> entries, Data.Sweep sweep);

    }
}
