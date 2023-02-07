using GolfSweep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfSweep.Data
{
    public class Score : BaseEntity
    {
        public int Gross { get; set; }
        public int Nett { get; set; }
        public int Points { get; set; }
        public int HoleNumber { get; set; }
    }
}
