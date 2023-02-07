using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfSweep.Dtos
{
    public class PlayerDto
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public string FullName { get; set; }
        public int CurrentHandicap { get; set; }
        public double CurrentExactHandicap { get; set; }
        public List<HandicapDto> Handicaps { get; set; }
        public List<PlayerEventDto> Events { get; set; }
        //public List<EntryDto> Entires { get; set; }
        //public List<EventDto> Events { get; set; }
    }

    public class PlayerEventDto
    {
        public Guid Id { get; set; }
        public DateTimeOffset Date { get; set; }
        public EntryDto Entry { get; set; }
        public CourseDto Course { get; set; }
        public OOMPointsDto Points { get; set; }
        public bool WinterHandicaps { get; set; }
    }
}
