﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebsite.Models
{
    public class CommentsViewModel {
        public IEnumerable<Comment> Comments { get; set; }
    }
}