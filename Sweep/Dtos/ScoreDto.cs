using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfSweep.Dtos
{
    public class ScoreDto
    {
        public Guid Id { get; set; }
        public int Gross { get; set; }
        public int Nett { get; set; }
        public int Points { get; set; }
        public int HoleNumber { get; set; }

        public int Par { get; set; }
        public int Index { get; set; }

        public CourseDto Course { get; set; }
        public Guid PlayerId { get; set; }
        public Guid CourseId { get; set; }
        public Guid CardId { get; set; }
    }
}
