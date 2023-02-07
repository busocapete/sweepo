using GolfSweep.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfSweep.Repositories.Interfaces
{
    public interface IScoreRepository : IRepository<Score>
    {
        int CalculatePoints(int nett, int par);
        int CalculateNettScore(int gross, Hole hole, int eventHandicap);
    }
}
