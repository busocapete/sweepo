using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GolfSweep.Data
{
    public class SweepPlayer
    {
        [Required]
        public Guid SweepId { get; set; }
        public virtual Sweep Sweep { get; set; }
        [Required]
        public Guid PlayerId { get; set; }
        public virtual Player Player { get; set; }

        public bool Approved { get; set; }

        public bool IsAdmin { get; set; }
    }
}
