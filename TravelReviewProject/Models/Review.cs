using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TravelReviewProject.Models
{
    public class Review
    {
        [Key]
        public int ID { get; set; }

        public string Title { get; set; }
        public string Author { get; set; }

        [Display(Name = "Ranch Name")]
        public string RanchName { get; set; }

        public string Comment { get; set; }

        [Display(Name = "Date of Stay")]
        [DisplayFormat(DataFormatString = "{0:MM/yyyy}")]
        public DateTime DateOfStay { get; set; }

        [Display(Name = "Length of Stay")]
        public string LengthOfStay { get; set; }

        [Display(Name = "Date Posted")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DatePosted { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        [ForeignKey("Location")]
        public int LocationID { get; set; }
        public virtual Location Location { get; set; }

    }
}