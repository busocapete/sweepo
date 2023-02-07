using GolfSweep.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GolfSweep.Data
{
    public class Event : BaseEntity
    {
        //public Guid Id { get; set; }
        //[JsonConverter(typeof(DateTimeConverter))]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTimeOffset Date { get; set; }
        public virtual ICollection<Entry> Entries { get; set; }
        public virtual Course Course { get; set; }

        public virtual ICollection<OOMPoints> OOMPoints { get; set; }

        public bool WinterHandicaps { get; set; }
        public bool Drawn { get; set; }
        public bool Complete { get; set; }

       // public virtual ICollection<ScoreCard> Cards { get; set; }

        public EventType EventType { get; set; }

        public virtual Result Result { get; set; }

        public Event()
        {
            Created = DateTimeOffset.Now;
        }
    }

    //public class EventRules
    //{
    //    public Guid Id { get; set; }
        
    //}

    public enum EventType
    {
        Stableford,
        Stroke,
        Sixes,
        Match
    }
}
