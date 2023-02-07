using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfSweep.Dtos
{
    public class SweepApprovalDto
    {
        public Guid PlayerId { get; set; }
        public Guid SweepId { get; set; }
    }
}
