using naturGuiderna.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace naturGuiderna.Models
{
    public class Activity
    {
        [Key]
        public int Id { get; set; }

        public string PictureUrl { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public double Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public ActivityCategory ActivityCategory { get; set; }

        // Navigation properties (Relationsship between models)
        // Joint table Experience_Activity between Activity And Experience
        public List<Experience_Activity> Experience_Activities { get; set; }

        // Location one-to-many
        [ForeignKey("LocationId")]
        public int LocationId { get; set; }
        public Location Location { get; set; }


        // Guide one-to-many
        [ForeignKey("GuideId")]
        public int GuideId { get; set; }
        public Guide Guide { get; set; }




    }
}
