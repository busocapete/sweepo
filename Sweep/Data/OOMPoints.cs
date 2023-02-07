using GolfSweep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfSweep.Data
{
    public class OOMPoints : BaseEntity
    {
        public virtual Sweep Sweep { get; set; }
        public int Points { get; set; }
        public int Position { get; set; }
        public virtual Player Player { get; set; }
        public virtual ScoreCard Card { get; set; }
    }
}
