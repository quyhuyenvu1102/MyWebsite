using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyWebsite.Models
{
    public class CommentEntity
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(300)]
        public string Content { get; set; }


        public DateTimeOffset CreatedAt { get; set; }

        public DateTimeOffset ModifedAt { get; set; }

        [Required]
        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser User { get; set; }

        [Required]
        public string BlogPostEntityId { get; set; }
        public virtual BlogPostEntity BlogPostEntity { get; set; }

    }
}