using GolfSweep.Data;
using GolfSweep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfSweep.Data
{
    public class Course : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<Hole> Holes { get; set; }

        public int TotalPar
        {
            get
            {
                var totalPar = 0;

                foreach (var hole in Holes)
                {
                    totalPar = totalPar + hole.Par;
                }

                return totalPar;
            }
        }

    }
}
