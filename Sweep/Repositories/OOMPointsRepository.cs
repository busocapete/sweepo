using GolfSweep.Data;
using GolfSweep.Repositories;
using GolfSweep.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfSweep.Repositories
{
    public class OOMPointsRepository : Repository<OOMPoints>, IOOMPointsRepository
    {
        private readonly ApplicationDbContext _context;

        public OOMPointsRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public int CalculateOOMPoints(int position, int entriesCount, SweepRules rules)
        {
            var points = 0;

            if (!rules.OOMEntriesScale)
            {
                if (entriesCount <= 10)
                {
                    points = SwitchForOOM10(position);
                }
                else
                {
                    points = SwitchForOOM15(position);
                }
            }
            else
            {
                if (entriesCount <= 10)
                {
                    points = SwitchForOOM10(position);
                }
                if (entriesCount >=11 && entriesCount <= 15)
                {
                    points = SwitchForOOM15(position);
                }
                if (entriesCount >=16 && entriesCount <= 20)
                {
                    points = SwitchForOOM20(position);
                }
                if (entriesCount >=21 && entriesCount <= 25)
                {
                    points = SwitchForOOM25(position);
                }
                if (entriesCount >= 26 && entriesCount <= 30)
                {
                    points = SwitchForOOM30(position);
                } 
                if (entriesCount >= 31 && entriesCount <= 35)
                {
                    points = SwitchForOOM35(position);
                }
                if (entriesCount >= 36)
                {
                    points = SwitchForOOM40(position);
                }
            }

            return points;
        }


        private int SwitchForOOM15(int position)
        {
            var points = 0;

            switch (position)
            {
                case 1:
                    points = 15;
                    break;
                case 2:
                    points = 12;
                    break;
                case 3:
                    points = 10;
                    break;
                case 4:
                    points = 8;
                    break;
                case 5:
                    points = 7;
                    break;
                case 6:
                    points = 6;
                    break;
                case 7:
                    points = 5;
                    break;
                case 8:
                    points = 4;
                    break;
                case 9:
                    points = 3;
                    break;
                case 10:
                    points = 2;
                    break;

                default:
                    points = 1;
                    break;
            }

            return points;
        }


        private int SwitchForOOM10(int position)
        {
            var points = 0;
            switch (position)
            {
                case 1:
                    points = 10;
                    break;
                case 2:
                    points = 8;
                    break;
                case 3:
                    points = 7;
                    break;
                case 4:
                    points = 6;
                    break;
                case 5:
                    points = 5;
                    break;
                case 6:
                    points = 4;
                    break;
                case 7:
                    points = 3;
                    break;
                case 8:
                    points = 2;
                    break;
                default:
                    points = 1;
                    break;
            }

            return points;
        }

        private int SwitchForOOM20(int position)
        {
            var points = 0;

            switch (position)
            {
                case 1:
                    points = 20;
                    break;
                case 2:
                    points = 16;
                    break;
                case 3:
                    points = 13;
                    break;
                case 4:
                    points = 11;
                    break;
                case 5:
                    points = 9;
                    break;
                case 6:
                    points = 8;
                    break;
                case 7:
                    points = 7;
                    break;
                case 8:
                    points = 6;
                    break;
                case 9:
                    points = 5;
                    break;
                case 10:
                    points = 4;
                    break;
                case 11:
                    points = 3;
                    break;
                case 12:
                    points = 2;
                    break;

                default:
                    points = 1;
                    break;
            }
            return points;
        }


        private int SwitchForOOM25(int position)
        {
            var points = 0;
            switch (position)
            {
                case 1:
                    points = 25;
                    break;
                case 2:
                    points = 20;
                    break;
                case 3:
                    points = 16;
                    break;
                case 4:
                    points = 13;
                    break;
                case 5:
                    points = 11;
                    break;
                case 6:
                    points = 10;
                    break;
                case 7:
                    points = 9;
                    break;
                case 8:
                    points = 8;
                    break;
                case 9:
                    points = 7;
                    break;
                case 10:
                    points = 6;
                    break;
                case 11:
                    points = 5;
                    break;
                case 12:
                    points = 4;
                    break;
                case 13:
                    points = 3;
                    break;
                case 14:
                    points = 2;
                    break;
                default:
                    points = 1;
                    break;
            }

            return points;
        }

        private int SwitchForOOM30(int position)
        {
            var points = 0;

            switch (position)
            {
                case 1:
                    points = 30;
                    break;
                case 2:
                    points = 24;
                    break;
                case 3:
                    points = 19;
                    break;
                case 4:
                    points = 15;
                    break;
                case 5:
                    points = 13;
                    break;
                case 6:
                    points = 12;
                    break;
                case 7:
                    points = 11;
                    break;
                case 8:
                    points = 10;
                    break;
                case 9:
                    points = 9;
                    break;
                case 10:
                    points = 9;
                    break;
                case 11:
                    points = 8;
                    break;
                case 12:
                    points = 7;
                    break;
                case 13:
                    points = 6;
                    break;
                case 14:
                    points = 5;
                    break;
                case 15:
                    points = 4;
                    break;
                case 16:
                    points = 3;
                    break;
                case 17:
                    points = 2;
                    break;

                default:
                    points = 1;
                    break;
            }

            return points;

        }

        private int SwitchForOOM35(int position)
        {
            var points = 0;

            switch (position)
            {
                case 1:
                    points = 35;
                    break;
                case 2:
                    points = 28;
                    break;
                case 3:
                    points = 22;
                    break;
                case 4:
                    points = 17;
                    break;
                case 5:
                    points = 15;
                    break;
                case 6:
                    points = 14;
                    break;
                case 7:
                    points = 13;
                    break;
                case 8:
                    points = 12;
                    break;
                case 9:
                    points = 11;
                    break;
                case 10:
                    points = 10;
                    break;
                case 11:
                    points = 9;
                    break;
                case 12:
                    points = 8;
                    break;
                case 13:
                    points = 7;
                    break;
                case 14:
                    points = 6;
                    break;
                case 15:
                    points = 5;
                    break;
                case 16:
                    points = 4;
                    break;
                case 17:
                    points = 3;
                    break;
                case 18:
                    points = 2;
                    break;


                default:
                    points = 1;
                    break;
            }

            return points;
        }

        private int SwitchForOOM40(int position)
        {
            var points = 0;

            switch (position)
            {
                case 1:
                    points = 40;
                    break;
                case 2:
                    points = 32;
                    break;
                case 3:
                    points = 25;
                    break;
                case 4:
                    points = 19;
                    break;
                case 5:
                    points = 17;
                    break;
                case 6:
                    points = 16;
                    break;
                case 7:
                    points = 15;
                    break;
                case 8:
                    points = 14;
                    break;
                case 9:
                    points = 13;
                    break;
                case 10:
                    points = 12;
                    break;
                case 11:
                    points = 11;
                    break;
                case 12:
                    points = 10;
                    break;
                case 13:
                    points = 9;
                    break;
                case 14:
                    points = 8;
                    break;
                case 15:
                    points = 7;
                    break;
                case 16:
                    points = 6;
                    break;
                case 17:
                    points = 5;
                    break;
                case 18:
                    points = 4;
                    break;
                case 19:
                    points = 3;
                    break;
                case 20:
                    points = 2;
                    break;

                default:
                    points = 1;
                    break;
            }

            return points;

        }

        public async Task DeleteEventOOMPoints(Event @event)
        {
            foreach (var oomPoints in @event.OOMPoints.ToList())
            {
                await Remove(oomPoints);
            }
        }

        public void CreateEventOOMPoints(Event @event, List<Entry> entries, Data.Sweep sweep)
        {
            var oomList = new List<OOMPoints>();

            for (int i = 0; i < entries.Count(); i++)
            {
                int position = i + 1;

                var points = CalculateOOMPoints(position, entries.Count(), sweep.Rules);

                var oomPoints = new OOMPoints()
                {
                    Id = Guid.NewGuid(),
                    Player = entries[i].ScoreCard.Player,
                    Card = entries[i].ScoreCard,
                    Position = position,
                    Points = points,
                    Sweep = sweep,
                    Created = DateTimeOffset.Now

                };

                @event.OOMPoints.Add(oomPoints);
            }

        }


    }
}
