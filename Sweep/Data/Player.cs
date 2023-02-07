using GolfSweep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfSweep.Data
{
    public class Player : BaseEntity
    {
        public virtual ApplicationUser User { get; set; }
        public string UserId { get; set; }
        public virtual ICollection<Handicap> Handicaps { get; set; }
        public virtual ICollection<Entry> Entries { get; set; }
        public virtual ICollection<SweepPlayer> Sweeps { get; set; }

        //public Player()
        //{
        //    Name = User.FirstName + " " + User.LastName;
        //}

        public string FullName
        {
            get
            {
                return $"{User.FirstName} {User.LastName}";
            }
        }

        public int CurrentHandicap
        {
            get
            {
                double playingHandicap;
                if (CurrentExactHandicap > 0)
                {
                    playingHandicap = Math.Round(CurrentExactHandicap, MidpointRounding.AwayFromZero);
                }
                else
                {
                    playingHandicap = Math.Round(CurrentExactHandicap, MidpointRounding.ToEven);
                }

                if (CurrentExactHandicap == -1.5)
                {
                    playingHandicap = 1;
                }


                int playingHandicapInt = Convert.ToInt32(playingHandicap);

                //return Handicaps.OrderByDescending(h => h.Created).Select(h => h.Playing).FirstOrDefault();
                return playingHandicapInt;
            }
        }

        public double CurrentExactHandicap
        {
            get
            {
                return Handicaps.OrderByDescending(h => h.Created).Select(h => h.Exact).FirstOrDefault();
            }
        }


    }
}
