using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebRazor1.Utility;

namespace WebRazor1.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [Display(Name ="Title")]
        [Required(ErrorMessage =SD.REQUIRED)]
        public string Title { get; set; }

        [Display(Name ="ReleaseDate")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = SD.REQUIRED)]
        public DateTime ReleaseDate { get; set; }

        [Display(Name ="Genre")]
        public string Genre { get; set; }

        [Required(ErrorMessage = SD.REQUIRED)]
        [Display(Name ="Price")]
        public decimal Price { get; set; }
    }
}
