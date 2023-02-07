using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfSweep.Dtos
{
    public class HandicapDto
    {
        public Guid Id { get; set; }
        public DateTimeOffset Created { get; set; }
        public int Playing { get; set; }
        public double Exact { get; set; }
    }
}
