using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sweep.Dtos
{
    public class MatchResultDto
    {
        public string PlayerName { get; set; }
        public bool Won { get; set; }
        public bool Halved { get; set; }
        public int MatchResult { get; set; }
        public int Hole { get; set; }
    }


    public class VirtualMatchPlayResultsDto
    {
        public List<MatchResultDto> Results { get; set; }
    }

}
