using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfSweep.Dtos
{
    public class LeaderboardDto
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public int Position { get; set; }
        public int TotalPoints { get; set; }
        public int CurrentHole { get; set; }
        public Guid ScoreCardId { get; set; }
        public int Played { get; set; }

        public List<OOMForLeaderBoardDto> Events { get; set; }
    }
}
