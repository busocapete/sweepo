using GolfSweep.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GolfSweep.Models
{
    public class PlayerCardDto
    {
        public Guid Id { get; set; }
        [Display(Name = "1")]
        public virtual int First { get; set; }
        [Display(Name = "2")]
        public virtual int Second { get; set; }
        [Display(Name = "3")]
        public virtual int Third { get; set; }
        [Display(Name = "4")]
        public virtual int Fourth { get; set; }
        [Display(Name = "5")]
        public virtual int Fifth { get; set; }
        [Display(Name = "6")]
        public virtual int Sixth { get; set; }
        [Display(Name = "7")]
        public virtual int Seventh { get; set; }
        [Display(Name = "8")]
        public virtual int Eighth { get; set; }
        [Display(Name = "9")]
        public virtual int Ninth { get; set; }
        [Display(Name = "10")]
        public virtual int Tenth { get; set; }
        [Display(Name = "11")]
        public virtual int Eleventh { get; set; }
        [Display(Name = "12")]
        public virtual int Twelwth { get; set; }
        [Display(Name = "13")]
        public virtual int Thirteenth { get; set; }
        [Display(Name = "14")]
        public virtual int Fourteenth { get; set; }
        [Display(Name = "15")]
        public virtual int Fifteenth { get; set; }
        [Display(Name = "16")]
        public virtual int Sixteenth { get; set; }
        [Display(Name = "17")]
        public virtual int Seventeenth { get; set; }
        [Display(Name = "18")]
        public virtual int Eithteenth { get; set; }

        public Guid PlayerId { get; set; }
        public DateTimeOffset Created { get; set; }
        public ScoreCard ScoreCard { get; set; }

        public Course Course { get; set; }
    }
}
