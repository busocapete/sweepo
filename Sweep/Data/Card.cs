using GolfSweep.Data;
using GolfSweep.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GolfSweep.Data
{
    public class ScoreCard : BaseEntity
    {

        public virtual ICollection<Score> Scores { get; set; }
        
        public virtual Course Course { get; set; }
        public virtual Player Player { get; set; }
        public Guid PlayerId { get; set; }
        public int EventHandicap { get; set; }



        public int TotalPoints
        {
            get
            {
                return GetPoints(Scores.Where(s => s.HoleNumber <= 18).ToList());
            }
        }

        public int OutPoints
        {
            get
            {
                return GetPoints(Scores.Where(s => s.HoleNumber <= 9).ToList());
            }
        }

        public int InPoints
        {
            get
            {
                return GetPoints(Scores.Where(s => s.HoleNumber >= 10).ToList());
            }
        }

        public int LastSixPoints
        {
            get
            {
                return GetPoints(Scores.Where(s => s.HoleNumber >= 13).ToList());
            }
        }

        public int LastThreePoints
        {
            get
            {
                return GetPoints(Scores.Where(s => s.HoleNumber >= 16).ToList());
            }
        }

        public int TotalGross
        {
            get
            {
                return GetGross(Scores.Where(s => s.HoleNumber <= 18).ToList());
            }
        }

        public int OutGross
        {
            get
            {
                return GetGross(Scores.Where(s => s.HoleNumber <= 9).ToList());
            }
        }

        public int InGross
        {
            get
            {
                return GetGross(Scores.Where(s => s.HoleNumber >= 10).ToList());
            }
        }
        
        public int LastSixGross
        {
            get
            {
                return GetGross(Scores.Where(s => s.HoleNumber >= 13).ToList());
            }
        }

        public int LastThreeGross
        {
            get
            {
                return GetGross(Scores.Where(s => s.HoleNumber >= 16).ToList());
            }
        }

        public int TotalNett
        {
            get
            {
                return GetNett(Scores.Where(s => s.HoleNumber <= 18).ToList());
            }
        }

        public int OutNett
        {
            get
            {
                return GetNett(Scores.Where(s => s.HoleNumber <= 9).ToList());
            }
        }

        public int InNett
        {
            get
            {
                return GetNett(Scores.Where(s => s.HoleNumber >= 10).ToList());
            }
        }

        public int LastSixNett
        {
            get
            {
                return GetNett(Scores.Where(s => s.HoleNumber >= 13).ToList());
            }
        }


        public int LastThreeNett
        {
            get
            {
                return GetNett(Scores.Where(s => s.HoleNumber >= 16).ToList());
            }
        }


        public int GetPoints(ICollection<Score> Scores)
        {
            var totalPoints = 0;

            foreach (var score in Scores)
            {
                totalPoints = totalPoints + score.Points;
            }

            return totalPoints;
        }

        public int GetGross(ICollection<Score> Scores)
        {
            var totalGross = 0;

            foreach (var score in Scores)
            {
                totalGross = totalGross + score.Gross;
            }

            return totalGross;
        }



        public int GetNett(ICollection<Score> Scores)
        {
            var totalNett = 0;

            foreach (var score in Scores)
            {
                totalNett = totalNett + score.Nett;
            }

            return totalNett;
        }
    }

    
}
