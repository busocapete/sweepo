using GolfSweep.Data;
using GolfSweep.Repositories;
using GolfSweep.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfSweep.Repositories
{
    public class ScoreRepository : Repository<Score>, IScoreRepository
    {
        private readonly ApplicationDbContext _context;

        public ScoreRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public int CalculatePoints(int nett, int par)
        {
            var points = 0;

            if (nett == 0)
            {
                return points;
            }

            if (nett == (par - 1))
            {
                points = 3;
            }
            else if (nett == (par - 2))
            {
                points = 4;
            }
            else if (nett == (par - 3))
            {
                points = 5;
            }
            else if (nett == par)
            {
                points = 2;
            }
            else if (nett == (par + 1))
            {
                points = 1;
            }
            else
            {
                points = 0;
            }

            return points;

        }


        public int CalculateNettScore(int gross, Hole hole, int eventHandicap)
        {
            var nettScore = gross;

            if (gross == 0)
            {
                nettScore = 0;
                return nettScore;
            }

            var handicap = eventHandicap;
            var index = hole.Index;

            if (handicap == -1)
            {
                if (index == 18)
                {
                    nettScore = gross + 1;
                }
                else
                {
                    nettScore = gross;
                }

            }

            if (handicap == -2)
            {
                if (index == 18)
                {
                    nettScore = gross + 1;
                }
                else if (index == 17)
                {
                    nettScore = gross + 1;
                }
                else 
                {
                    nettScore = gross;
                }

            }


            if (handicap == -3)
            {
                if (index == 18)
                {
                    nettScore = gross + 1;
                }
                else if (index == 17)
                {
                    nettScore = gross + 1;
                }
                else if (index == 16)
                {
                    nettScore = gross + 1;
                }
                else
                {
                    nettScore = gross;
                }

            }




            if (handicap <= 18 && handicap >= 0)
            {
                if (index <= handicap)
                {
                    nettScore = gross - 1;
                }
            }

            if (handicap > 18)
            {
                var extraShots = handicap - 18;

                if (index <= extraShots)
                {
                    nettScore = gross - 2;
                }
                else
                {
                    nettScore = gross - 1;
                }
            }

            return nettScore;

        }


    }
}
