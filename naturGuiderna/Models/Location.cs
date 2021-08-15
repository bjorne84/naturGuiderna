using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace naturGuiderna.Models
{
    public class Location
    {
        [Key]
        public int Id { get; set; }
        public string PictureUrl { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        // Navigation properties (Relationsship between models)
        public List<Activity> Activities { get; set; }

    }
}
