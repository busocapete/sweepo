using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfSweep.Dtos
{
    public class PlayerEntryDto
    {
        public Guid PlayerId { get; set; }
        public Guid EventId { get; set; }
    }

    public class PlayerEntryResponseDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
