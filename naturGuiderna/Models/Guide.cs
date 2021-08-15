using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace naturGuiderna.Models
{
    public class Guide
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePictureUrl { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public int GuideDescription { get; set; }

        // Navigation properties (Relationsship between models)
        public List<NatureActivity> Activities { get; set; }

    }
}
