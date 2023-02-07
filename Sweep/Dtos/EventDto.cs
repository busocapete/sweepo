using GolfSweep.Data;
using GolfSweep.ViewModels;
using Sweep.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfSweep.Dtos
{
    public class EventDto
    {
        public Guid Id { get; set; }
        public DateTimeOffset Date { get; set; }
        public bool UserHasJoined { get; set; }
        public List<PlayerEntryResponseDto> PlayerNames { get; set; }
        public bool InFuture { get; set; }
        public string Winner { get; set; }
        public string Second { get; set; }
        public string Third { get; set; }
        public bool NotDrawn { get; set; }
        public bool Drawn { get; set; }
        public bool Complete { get; set; }
        public Guid SweepId { get; set; }
        public bool WinterHandicaps { get; set; }
        public CourseDto Course { get; set; }

        public IOrderedEnumerable<IGrouping<int?, EventEntryDto>> GroupedEntries { get; set; }

        public List<MatchResultDto> Results { get; set; }
        public List<PlayerDto> SweepMembers { get; set; }


    }

}
