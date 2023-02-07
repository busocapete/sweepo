using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfSweep.Dtos
{
    public class PlayEventDto
    {
        public EventDto Event { get; set; }
        public ScoreCardDto PlayerCard { get; set; }
        public ScoreCardDto MarkerCard { get; set; }

        public List<PlayerDto> GroupPlayers { get; set; }
    }
}
