using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebsite.Models
{
    public class Comment
    {
        public string Content { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        public DateTimeOffset ModifedAt { get; set; }

        public ApplicationUser Author { get; set; }

        public Guid Id { get; set; }
    }
}