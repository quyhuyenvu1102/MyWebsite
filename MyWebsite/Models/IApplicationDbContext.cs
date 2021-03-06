﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace MyWebsite.Models
{
    public interface IApplicationDbContext
    {
        IDbSet<BlogPostEntity> BlogPosts { get; set; }

        IDbSet<CommentEntity> Comments { get; set; }

        IDbSet<MovieEntity> Movies { get; set; }

        int SaveChanges();

        Task<int> SaveChangesAsync(CancellationToken ct);
    }
}