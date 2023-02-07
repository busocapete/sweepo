using GolfSweep.Data;
using GolfSweep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfSweep.Repositories.Interfaces
{
    public interface IScoreCardRepository : IRepository<ScoreCard>
    {
        Task<Course> GetCourseForScoreCard(Guid cardId);
        Task<Guid> GetEventIdForScoreCard(Guid cardId);

        PlayerCardDto CreatePlayerCardDto(ScoreCard scoreCard);


    }
}
