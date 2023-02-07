using GolfSweep.Data;
using GolfSweep.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfSweep.Repositories
{
    public class HandicapRepository : Repository<Handicap>, IHandicapRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly ISweepRepository _sweepRepository;

        public HandicapRepository(ApplicationDbContext context,
            ISweepRepository sweepRepository) : base(context)
        {
            _context = context;
            _sweepRepository = sweepRepository;
        }

        private double GetCutRateForHandicap(double currentHandicap)
        {
            double cutRate = 0;

            if (currentHandicap <= 5.4)
                cutRate = 0.1;

            if (currentHandicap >= 5.5 && currentHandicap <= 12.4)
                cutRate = 0.2;
            if (currentHandicap >= 12.5 && currentHandicap <= 20.4)
                cutRate = 0.3;
            if (currentHandicap >= 20.5 && currentHandicap <= 28.4)
                cutRate = 0.4;
            if (currentHandicap >= 28.5)
                cutRate = 0.5;

            return cutRate;

        }

        private int GetBufferForHandicap(double currentHandicap)
        {
            var buffer = 1;

            if (currentHandicap <= 5.4)
                return buffer;

            if (currentHandicap >= 5.5 && currentHandicap <= 12.4)
                buffer = 2;
            if (currentHandicap >= 12.5 && currentHandicap <= 20.4)
                buffer = 3;
            if (currentHandicap >= 20.5 && currentHandicap <= 28.4)
                buffer = 4;
            if (currentHandicap >= 28.5)
                buffer = 5;
            return buffer;

        }

        private int GetPlayerStrokesForHole(int playingHandicap, Hole hole)
        {
            var playerShots = 0;
            var extraShots = 0;

            if (hole.Index <= playingHandicap)
            {
                playerShots = 1;
            }

            if (playingHandicap > 18)
            {
                extraShots = playingHandicap - 18;

                if (hole.Index <= extraShots)
                {
                    playerShots = 2;
                }
            }

            return playerShots;
        }

        public int CalculateAdjustedGrossScore(ScoreCard card, Course course, int currentPlayingHandicap)
        {
            var totalAdjustedScore = 0;

            foreach (var score in card.Scores)
            {
                var hole = course.Holes.Where(h => h.Number == score.HoleNumber).FirstOrDefault();

                var strokesForHole = GetPlayerStrokesForHole(currentPlayingHandicap, hole);

                var adjustedScore = score.Gross - strokesForHole;

                if (score.Gross == 0 || adjustedScore > hole.Par + strokesForHole + 2)
                {
                    adjustedScore = hole.Par + strokesForHole + 2;
                }

                totalAdjustedScore = totalAdjustedScore + adjustedScore;
            }

            return totalAdjustedScore;
        }


        public double CalculateNewHandicapStandard(double currentExactHandicap, int currentPlayingHandicap, ScoreCard card,
            Course course, Data.Sweep sweep)
        {
            if (!sweep.Rules.CutHandicaps)
            {
                return currentExactHandicap;
            }

            //var cutRate = GetCutRateForHandicap(currentExactHandicap);
            var totalAdjustedGross = CalculateAdjustedGrossScore(card, course, currentPlayingHandicap);
            var buffer = GetBufferForHandicap(currentExactHandicap);

            var shotDifference = totalAdjustedGross - course.TotalPar;

            if (totalAdjustedGross < course.TotalPar)
            {
                var difference = course.TotalPar - totalAdjustedGross;

                for (int i = 0; i < difference; i++)
                {
                    var cutRate = GetCutRateForHandicap(currentExactHandicap);
                    currentExactHandicap = currentExactHandicap - cutRate;
                }
            }

            if (totalAdjustedGross > course.TotalPar + buffer)
            {
                currentExactHandicap = currentExactHandicap + 0.1;
            }

            currentExactHandicap = Math.Round(currentExactHandicap, 1);

            return currentExactHandicap;
        }


        public double CalculateNewHandicapFromGerrysRules(double currentHandicap, int totalPoints, int position, SweepRules rules)
        {
            if (!rules.CutHandicaps)
            {
                return currentHandicap;
            }

            double newHandicap = 0;
            double cutRate = 0;

            if (position <= 3)
            {
                if (totalPoints < rules.MinPointsForCut)
                {
                    totalPoints = rules.MinPointsForCut;
                }
            }


            if (totalPoints <= 35)
            {
                newHandicap = currentHandicap + 0.1;
            }

            if (totalPoints == 36)
            {
                newHandicap = currentHandicap;
            }

            if (totalPoints >= 37)
            {
                var change = totalPoints - 36;

                newHandicap = currentHandicap;



                for (int i = 0; i < change; i++)
                {
                    if (newHandicap <= 5.4)
                    {
                        cutRate = 0.1;
                    }

                    if (newHandicap >= 5.5 && newHandicap <= 12.4)
                    {
                        cutRate = 0.2;
                    }

                    if (newHandicap >= 12.5 && newHandicap <= 30)
                    {
                        cutRate = 0.3;
                    }


                    if (position == 1)
                    {
                        newHandicap = currentHandicap - (cutRate * rules.WinnerCut);
                    }

                    if (position == 2)
                    {
                        newHandicap = currentHandicap - (cutRate * rules.SecondCut);
                    }

                    if (position == 3)
                    {
                        newHandicap = currentHandicap - (cutRate * rules.ThirdCut);
                    }

                    if (position >= 4)
                    {
                        newHandicap = currentHandicap - cutRate;
                    }
                }
            }


            newHandicap = Math.Round(newHandicap, 1);

            return newHandicap;

        }

        public double CalculateNewHandicapFromStableFordPoints(double currentHandicap, int totalPoints, int position, SweepRules rules)
        {

            if (!rules.CutHandicaps)
            {
                return currentHandicap;
            }


            double newHandicap = 0;
            double cutRate = 0;

            if (position <= 3)
            {
                if (totalPoints < rules.MinPointsForCut)
                {
                    totalPoints = rules.MinPointsForCut;
                }
            }

            if (currentHandicap <= 5.4)
            {
                cutRate = 0.1;
            }

            if (currentHandicap >= 5.5 && currentHandicap <= 12.4)
            {
                cutRate = 0.2;
            }

            if (currentHandicap >= 12.5 && currentHandicap <= 30)
            {
                cutRate = 0.3;
            }

            if (totalPoints <= 35)
            {
                newHandicap = currentHandicap + 0.1;
            }

            if (totalPoints == 36)
            {
                newHandicap = currentHandicap;
            }

            if (totalPoints >= 37)
            {
                var change = totalPoints - 36;

                if (position == 1)
                {
                    var c = Math.Round((change * cutRate) * rules.WinnerCut, 1);
                    newHandicap = currentHandicap - c;
                }
                if (position == 2)
                {
                    var c = Math.Round((change * cutRate) * rules.SecondCut, 1);
                    newHandicap = currentHandicap - c;
                }

                if (position == 3)
                {
                    var c = Math.Round((change * cutRate) * rules.ThirdCut, 1);
                    newHandicap = currentHandicap - c;
                }
                if (position >= 4)
                {
                    var c = Math.Round((change * cutRate), 1);
                    newHandicap = currentHandicap - c;
                }
            }


            newHandicap = Math.Round(newHandicap, 1);

            return newHandicap;

        }


        public async Task UpdateEventHandicaps(List<Entry> entries, Event @event, Data.Sweep sweep)
        {
            var newHandicapList = new List<Handicap>();

            for (int i = 0; i < entries.Count(); i++)
            {
                int position = i + 1;

                var currentExactHandicap = await _sweepRepository.GetPlayerCurrentExactSweepHandicap(sweep.Id, entries[i].ScoreCard.Player.Id);
                var currentPlayingHandicap = await _sweepRepository.GetPlayerCurrentPlayingSweepHandicap(sweep.Id, entries[i].ScoreCard.Player.Id);
                double newHandicap = 0;

                if (sweep.Rules.CutHandicaps)
                {
                    if (sweep.Rules.CutHandicapsByStableFordPoints)
                    {
                        newHandicap = CalculateNewHandicapFromStableFordPoints(
                            currentExactHandicap,
                            entries[i].ScoreCard.TotalPoints, position, sweep.Rules);
                    }
                    else
                    {
                        newHandicap = CalculateNewHandicapStandard(currentExactHandicap,
                            currentPlayingHandicap, entries[i].ScoreCard, entries[i].ScoreCard.Course, sweep);
                    }
                }


                if (newHandicap != currentExactHandicap)
                {
                    var handicapToAdd = new Handicap()
                    {
                        Player = entries[i].ScoreCard.Player,
                        Exact = newHandicap,
                        Playing = Convert.ToInt32(Math.Round(newHandicap)),
                        Created = DateTimeOffset.Now,
                        SweepId = sweep.Id,
                        EventId = @event.Id
                    };

                    //_context.Handicaps.Add(handicapToAdd);
                    newHandicapList.Add(handicapToAdd);
                }

            }

            _context.Handicaps.AddRange(newHandicapList);

        }


        public async Task DeleteEventHandicaps(Guid @eventId)
        {
            var handicapsToChange = await GetWhere(h => h.EventId == @eventId);

            foreach (var handicap in handicapsToChange)
            {
                await Remove(handicap);
            }
        }
    }
}
