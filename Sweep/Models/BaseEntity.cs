using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfSweep.Models
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTimeOffset Created { get; set; }
    }
}
