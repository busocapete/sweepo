using GolfSweep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfSweep.Data
{
    public class Hole : BaseEntity
    {
        public int Number { get; set; }
        public int Index { get; set; }
        public int Par { get; set; }
        //public string NumericName { get; set; }
        //public int Score { get; set; }
        //public int Points { get; set; }
    }
}
