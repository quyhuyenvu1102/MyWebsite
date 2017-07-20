using MyWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace MyWebsite.Services
{
    public interface ICommentService
    {
        Task<Comment> CreateCommentAsync(Comment comment,Guid BlogPostId, CancellationToken ct);

        Task<Comment> UpdateCommentAsync(Guid commentId, Comment comment, CancellationToken ct);

        Task<Comment> GetCommentByIdAsync(Guid commentId, CancellationToken ct);

        Task<Comment> DeleteCommentByIdAsync(Guid commentId, CancellationToken ct);
        

    }
}