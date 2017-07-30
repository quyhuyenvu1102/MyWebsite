using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyWebsite.Models
{
    public class MovieEntity
    {
        public Guid Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Genre { get; set; }

        [DefaultValue("#")]
        public string Image { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleasedDate { get; set; }
        
        public string Plot { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }
}