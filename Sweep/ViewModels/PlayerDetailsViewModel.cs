using GolfSweep.Data;
using GolfSweep.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfSweep.ViewModels
{
    public class PlayerDetailsViewModel
    {
        public Player Player { get; set; }
        public List<Event> Events { get; set; }
    }

    public class EventDrawViewModel
    {
        public Event Event { get; set; }
        //public Entry[][] Results { get; set; }
        public List<List<Entry>> Results { get; set; }
        public IOrderedEnumerable<IGrouping<int?,Entry>> GroupedEntries { get; set; }
    }


    public class EventDrawDto
    {
        public IOrderedEnumerable<IGrouping<int?, EventEntryDto>> GroupedEntries { get; set; }
    }


    public class EventEntryDto
    {
        public Guid Id { get; set; }
        public ScoreCardDto ScoreCard { get; set; }
        public bool Paid { get; set; }
        public int? Group { get; set; }
        public ScoreCardDto Marker { get; set; }
    }
}
