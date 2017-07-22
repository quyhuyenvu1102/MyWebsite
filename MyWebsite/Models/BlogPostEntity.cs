using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyWebsite.Models
{
    public class BlogPostEntity
    {
        public Guid Id { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public DateTimeOffset ModifiedDate { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [DefaultValue("https://source.unsplash.com/_Ajm-ewEC24")]
        public string Image { get; set; }

        [Required]
        public string Content { get; set; }
        
        [Required]
        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser User { get; set; }

        public virtual ICollection<CommentEntity> Comments { get; set; }
    }
}