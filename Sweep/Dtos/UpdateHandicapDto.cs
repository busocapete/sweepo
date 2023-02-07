using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfSweep.Dtos
{
    public class UpdateHandicapDto
    {
        public Guid PlayerId { get; set; }
        public double Handicap { get; set; }
        public Guid SweepId { get; set; }
    }

    public class UpdateHandicapResponseDto
    {
        public Guid PlayerId { get; set; }
        public Guid SweepId { get; set; }
        public int CurrentHandicap { get; set; }
        public double CurrentExactHandicap { get; set; }
    }
}
