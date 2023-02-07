using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfSweep.Data
{
    public class Result
    {
        public Guid Id { get; set; }
        public virtual ScoreCard Winner { get; set; }
        public virtual ScoreCard Second { get; set; }
        public virtual ScoreCard Third { get; set; }
        public virtual Event Event { get; set; }
        public virtual Guid EventId { get; set; }
    }
}
