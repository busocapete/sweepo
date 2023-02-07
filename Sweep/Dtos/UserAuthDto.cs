using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfSweep.Dtos
{
    public class UserAuthDetailDto
    {
        public string Id { get; set; }
        public Guid PlayerId { get; set; }
        public List<Guid> SweepIds { get; set; }
    }

    public class UserAuthDto
    {
        public UserAuthDetailDto User { get; set; }
    }

    public class GuidDto
    {
        public Guid Id { get; set; }
    }
}
