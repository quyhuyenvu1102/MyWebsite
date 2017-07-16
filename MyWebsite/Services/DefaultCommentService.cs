using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using MyWebsite.Models;

namespace MyWebsite.Services
{
    public class DefaultCommentService : ICommentService
    {
        public readonly ApplicationDbContext _context;

        public DefaultCommentService() {
            _context = new ApplicationDbContext();
        }

        public Task<Comment> CreateCommentAsync(Comment comment, CancellationToken ct)
        {
            throw new NotImplementedException();
        }

        public Task<Comment> DeleteCommentByIdAsync(Guid commentId, CancellationToken ct)
        {
            throw new NotImplementedException();
        }

        public Task<Comment> GetCommentByIdAsync(Guid commentId, CancellationToken ct)
        {
            throw new NotImplementedException();
        }

        public Task<Comment> UpdateCommentAsync(Guid commentId, Comment comment, CancellationToken ct)
        {
            throw new NotImplementedException();
        }
    }
}