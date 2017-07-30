using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebsite.Models
{
    public class MovieViewModel
    {
        public string Title { get; set; }

        public string Genre { get; set; }

        public string Image { get; set; }

        public DateTime ReleasedDate { get; set; }

        public string Plot { get; set; }

        public decimal Price { get; set; }
    }
}