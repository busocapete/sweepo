using GolfSweep.Models;
using System;

namespace GolfSweep.Data
{
    public class Entry : BaseEntity
    {
        //public Guid Id { get; set; }
        public virtual ScoreCard ScoreCard { get; set; }
        public bool Paid { get; set; }
        public int? Group { get; set; }

        public virtual ScoreCard Marker { get; set; }
        //public virtual Player Player { get; set; }
    }
}