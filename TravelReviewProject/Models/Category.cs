using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelReviewProject.Models
{
    public class Category
    {
        [Key]
        [Display(Name = "Type Ranch")]
        public int ID { get; set; }

        public string Type { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }
    }
}