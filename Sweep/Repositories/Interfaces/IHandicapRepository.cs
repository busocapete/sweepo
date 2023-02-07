using GolfSweep.Data;
using GolfSweep.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfSweep.Repositories.Interfaces
{
    public interface IHandicapRepository : IRepository<Handicap>
    {
        double CalculateNewHandicapStandard(double currentExactHandicap, int currentPlayingHandicap, ScoreCard card,
            Course course, Data.Sweep sweep);

        double CalculateNewHandicapFromStableFordPoints(double currentHandicap, int totalPoints, int position, SweepRules rules);
        Task DeleteEventHandicaps(Guid @eventId);

        Task UpdateEventHandicaps(List<Entry> Entries, Event @event, Data.Sweep sweep);

        double CalculateNewHandicapFromGerrysRules(double currentHandicap, int totalPoints, int position, SweepRules rules);

    }
}
