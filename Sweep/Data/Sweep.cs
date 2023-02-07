using GolfSweep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfSweep.Data
{
    public class Sweep : BaseEntity
    {
        //public Guid Id { get; set; }
        public string Name { get; set; }
        //public DateTimeOffset Created { get; set; }
        public virtual ApplicationUser Owner { get; set; }

        public virtual SweepRules Rules { get; set; }


        public bool Public { get; set; }

        public virtual ICollection<Event> Events { get; set; }
        public virtual ICollection<SweepPlayer> Members { get; set; }

        //public virtual List<ApplicationUser> Admins { get; set; }
    }
}
