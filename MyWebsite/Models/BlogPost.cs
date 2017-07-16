using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebsite.Models
{
    public class BlogPost
    {
        public string Title { get; set; }

        public string Image { get; set; }

        public string Content { get; set; }


        //public DateTimeOffset CreatedDate { get; set; }

        //public DateTimeOffset ModifiedDate { get; set; }

        public ApplicationUser Author { get; set; }

        public ICollection<Comment> Comments { get; set; }

    }
}