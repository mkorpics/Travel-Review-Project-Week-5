using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelReviewProject.Models
{
    public class Location
    {
        [Key]
        [Display(Name = "Location")]
        public int ID { get; set; }
        
        public string City { get; set; }
        public string State { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
    }
}