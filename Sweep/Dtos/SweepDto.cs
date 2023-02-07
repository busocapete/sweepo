using GolfSweep.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfSweep.Dtos
{
    public class SweepDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
        public int TotalEvents { get; set; }
        public List<EventDto> Events { get; set; }
        public bool UserIsMember { get; set; }
        public bool Approved { get; set; }
        public List<LeaderboardDto> OOM { get; set; }
        public List<PlayerDto> Members { get; set; }
        public List<PlayerDto> Requests { get; set; }
        public List<CourseDto> Courses { get; set; }
        public DateTimeOffset Created { get; set; }
        
    }

    public class SweepEntryDto
    {
        public Guid PlayerId { get; set; }
        public Guid SweepId { get; set; }
        public bool Approved { get; set; }
    }
}
