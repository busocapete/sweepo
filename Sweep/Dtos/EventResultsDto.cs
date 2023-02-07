using GolfSweep.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfSweep.Dtos
{
    public class EventResultsDto
    {
        public Guid Id { get; set; }
        public DateTimeOffset Date { get; set; }
        public bool UserHasJoined { get; set; }
        public List<OOMPointsDto> OOMPoints { get; set; }
        public List<EntryDto> Entries { get; set; }
        public List<ScoreCardDto> Cards { get; set; }

    }

    public class OOMPointsDto
    {
        public int Points { get; set; }
        public int Position { get; set; }
        public PlayerDto Player { get; set; }
        public ScoreCardDto Card { get; set; }
    }

    public class OOMForLeaderBoardDto
    {
        public int Points { get; set; }
        public int Position { get; set; }
        public EventForLeaderBoardDto Event { get; set; }
    }

    public class EventForLeaderBoardDto
    {
        public string SweepName { get; set; }
        public DateTimeOffset Date { get; set; }
    }
}
