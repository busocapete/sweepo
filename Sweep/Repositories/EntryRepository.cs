using GolfSweep.Data;
using GolfSweep.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfSweep.Repositories
{
    public class EntryRepository : Repository<Entry>, IEntryRepository
    {
        private readonly ApplicationDbContext _context;

        public EntryRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }


        public int ConvertEventHandicapToWinter(int handicap, double percentage)
        {
            double doubleHcap = handicap * percentage;
            double roundedHcap = Math.Round(doubleHcap, MidpointRounding.AwayFromZero);
            return Convert.ToInt32(roundedHcap);
        }
    }
}
