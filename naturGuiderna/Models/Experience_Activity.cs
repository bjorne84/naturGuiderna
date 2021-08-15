using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace naturGuiderna.Models
{
    public class Experience_Activity
    {
        public int ActivityId { get; set; }
        public NatureActivity Activity { get; set; }
        public int ExperienceId { get; set; }
        public Experience Experience { get; set; }
    }
}
