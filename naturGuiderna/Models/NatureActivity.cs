using naturGuiderna.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace naturGuiderna.Models
{
    public class NatureActivity
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Bild")]
        public string PictureUrl { get; set; }
        [Display(Name = "Aktivitet")]
        public string Name { get; set; }
        [Display(Name = "Beskrining")]
        public string Description { get; set; }
        [Display(Name = "Pris")]
        public double Price { get; set; }
        [Display(Name = "Starttid")]
        public DateTime StartDate { get; set; }
        [Display(Name = "Sluttid")]
        public DateTime EndDate { get; set; }
        [Display(Name = "Antal deltagare")]
        public int NumberOfParticipants { get; set; }
        [Display(Name = "Tillgänglighet")]
        public bool Availability { get; set; }

        /*
        public ActivityCategory ActivityCategory { get; set; }
        */

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


        // Category one-to-many
        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }


    }
}
