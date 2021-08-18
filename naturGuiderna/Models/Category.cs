using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace naturGuiderna.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Bild")]
        public string PictureUrl { get; set; }
        [Display(Name = "Namn")]
        public string Name { get; set; }

        // Navigation properties (Relationsship between models)
        public List<NatureActivity> Activities { get; set; }
    }
}
