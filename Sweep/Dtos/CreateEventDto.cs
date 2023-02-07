using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GolfSweep.Dtos
{
    public class CreateEventDto
    {
        public Guid CourseId { get; set; }
        public Guid SweepId { get; set; }
        public bool WinterHandicaps { get; set; }
        [DataType(DataType.Date)]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{MM/DD/YY}")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTimeOffset Date { get; set; }
    }
}
