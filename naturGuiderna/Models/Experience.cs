using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace naturGuiderna.Models
{
    public class Experience
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Bild URL-adress")]
        public string PictureUrl { get; set; }
        [Display(Name = "Upplevelser")]
        public string Name { get; set; }
        [Display(Name = "Beskrivning")]
        public string Description { get; set; }

        // Navigation properties (Relationsship between models)
        // Joint table Experience_Activity between Activity And Experience
        public List<Experience_Activity> Experience_Activities { get; set; }
    }
}
