using GolfSweep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfSweep.Data
{
    public class Handicap : BaseEntity
    {
            public double Exact { get; set; }
            public int Playing { get; set; }
            public virtual Player Player { get; set; }
            public Guid PlayerId { get; set; }

            public Guid? SweepId { get;set; }
            public Guid? EventId { get; set; }
    }
}
