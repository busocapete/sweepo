using GolfSweep.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfSweep.Repositories.Interfaces
{
    public interface IEntryRepository : IRepository<Entry>
    {
        int ConvertEventHandicapToWinter(int handicap, double percentage);
    }
}
