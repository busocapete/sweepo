using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfSweep.Dtos
{
    public class ScoreCardDto 
    {
        public Guid Id { get; set; }
        public List<ScoreDto> Scores { get; set; }
        public List<ScoreDto> FrontNine { get; set; }
        public List<ScoreDto> BackNine { get; set; }
        public PlayerDto Player { get; set; }
        public int TotalPoints { get; set; }
        public int OutPoints { get; set; }
        public int InPoints { get; set; }
        public int LastSixPoints { get; set; }
        public int LastThreePoints { get; set; }

        public int TotalGross { get; set; }
        public int OutGross { get; set; }
        public int InGross { get; set; }
        public int LastSixGross { get; set; }
        public int LastThreeGross { get; set; }

        public int TotalNett { get; set; }
        public int OutNett { get; set; }
        public int InNett { get; set; }
        public int LastSixNett { get; set; }
        public int LastThreeNett { get; set; }

        public string CourseName { get; set; }
        public CourseDto Course { get; set; }
        public Guid EventId { get; set; }

    }

    public class FullCardDto
    {
        public int First { get; set; }
        public int Second { get; set; }
        public int Third { get; set; }
        public int Fourth { get; set; }
        public int Fifth { get; set; }
        public int Sixth { get; set; }
        public int Seventh { get; set; }
        public int Eighth { get; set; }
        public int Ninth { get; set; }
        public int Tenth { get; set; }
        public int Eleventh { get; set; }
        public int Twelfth { get; set; }
        public int Thirteenth { get; set; }
        public int Fourteenth { get; set; }
        public int Fifteenth { get; set; }
        public int Sixteenth { get; set; }
        public int Seventeenth { get; set; }
        public int Eighteenth { get; set; }
        public Guid Id { get; set; }
        public Guid CourseId { get; set; }
        public Guid PlayerId { get; set; }
    }
}
