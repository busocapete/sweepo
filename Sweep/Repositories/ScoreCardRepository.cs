using GolfSweep.Data;
using GolfSweep.Models;
using GolfSweep.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfSweep.Repositories
{
    public class ScoreCardRepository : Repository<ScoreCard>, IScoreCardRepository
    {
        private readonly ApplicationDbContext _context;

        public ScoreCardRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Course> GetCourseForScoreCard(Guid cardId)
        {
            return await _context.Events
                .Where(e => e.Entries.Any(ev => ev.ScoreCard.Id == cardId))
                .Select(e => e.Course)
                .FirstOrDefaultAsync();
        }

        public async Task<Guid> GetEventIdForScoreCard(Guid cardId)
        {
            return await _context.Events
                .Where(e => e.Entries.Any(ev => ev.ScoreCard.Id == cardId))
                .Select(e => e.Id)
                .FirstOrDefaultAsync();
        }


        public PlayerCardDto CreatePlayerCardDto(ScoreCard scoreCard)
        {
            var dto = new PlayerCardDto()
            {
                Id = scoreCard.Id,
                Course = scoreCard.Course,
                First = scoreCard.Scores.Where(s => s.HoleNumber == 1).Select(s => s.Gross).FirstOrDefault(),
                Second = scoreCard.Scores.Where(s => s.HoleNumber == 2).Select(s => s.Gross).FirstOrDefault(),
                Third = scoreCard.Scores.Where(s => s.HoleNumber == 3).Select(s => s.Gross).FirstOrDefault(),
                Fourth = scoreCard.Scores.Where(s => s.HoleNumber == 4).Select(s => s.Gross).FirstOrDefault(),
                Fifth = scoreCard.Scores.Where(s => s.HoleNumber == 5).Select(s => s.Gross).FirstOrDefault(),
                Sixth = scoreCard.Scores.Where(s => s.HoleNumber == 6).Select(s => s.Gross).FirstOrDefault(),
                Seventh = scoreCard.Scores.Where(s => s.HoleNumber == 7).Select(s => s.Gross).FirstOrDefault(),
                Eighth = scoreCard.Scores.Where(s => s.HoleNumber == 8).Select(s => s.Gross).FirstOrDefault(),
                Ninth = scoreCard.Scores.Where(s => s.HoleNumber == 9).Select(s => s.Gross).FirstOrDefault(),
                Tenth = scoreCard.Scores.Where(s => s.HoleNumber == 10).Select(s => s.Gross).FirstOrDefault(),
                Eleventh = scoreCard.Scores.Where(s => s.HoleNumber == 11).Select(s => s.Gross).FirstOrDefault(),
                Twelwth = scoreCard.Scores.Where(s => s.HoleNumber == 12).Select(s => s.Gross).FirstOrDefault(),
                Thirteenth = scoreCard.Scores.Where(s => s.HoleNumber == 13).Select(s => s.Gross).FirstOrDefault(),
                Fourteenth = scoreCard.Scores.Where(s => s.HoleNumber == 14).Select(s => s.Gross).FirstOrDefault(),
                Fifteenth = scoreCard.Scores.Where(s => s.HoleNumber == 15).Select(s => s.Gross).FirstOrDefault(),
                Sixteenth = scoreCard.Scores.Where(s => s.HoleNumber == 16).Select(s => s.Gross).FirstOrDefault(),
                Seventeenth = scoreCard.Scores.Where(s => s.HoleNumber == 17).Select(s => s.Gross).FirstOrDefault(),
                Eithteenth = scoreCard.Scores.Where(s => s.HoleNumber == 18).Select(s => s.Gross).FirstOrDefault(),
                ScoreCard = scoreCard
            };

            return dto;
        }


    }
}
