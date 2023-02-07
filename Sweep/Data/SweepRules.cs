using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfSweep.Data
{
    public class SweepRules
    {
        public Guid Id { get; set; }

        public bool CutHandicaps { get; set; }
        public bool CutHandicapsByStableFordPoints { get; set; }

        public double WinnerCut { get; set; }
        public double SecondCut { get; set; }
        public double ThirdCut { get; set; }

        public int MinPointsForCut { get; set; }

        public bool OrderOfMerit { get; set; }
        public bool OOMEntriesScale { get; set; }
    }
}
