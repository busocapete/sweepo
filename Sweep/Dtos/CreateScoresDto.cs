using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfSweep.Dtos
{
    public class CreateScoresDto
    {
        public Guid Id { get; set; }
        public Guid CourseId { get; set; }
        public Guid PlayerId { get; set; }
    }
}
