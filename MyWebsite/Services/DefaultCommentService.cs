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

        public DefaultCommentService():this(new ApplicationDbContext()){ }

        public DefaultCommentService(ApplicationDbContext context) {
            _context = context;
        }

        public async Task<Comment> CreateCommentAsync(Comment comment,Guid blogPostId,string userId, CancellationToken ct)
        {
            
            var blogPost = _context.BlogPosts.Where(r => r.Id == blogPostId).FirstOrDefault();
            if (blogPost == null)
                return null;
            comment.Author = _context.Users.Find(userId);
            var newComment = new CommentEntity
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTimeOffset.Now,
                ModifedAt = DateTimeOffset.Now,
                Content = comment.Content,
                BlogPostEntityId = blogPostId.ToString(),
                BlogPostEntity = blogPost,
                ApplicationUserId = userId
            };

             blogPost.Comments.Add(newComment);
            _context.Comments.Add(newComment);
            await _context.SaveChangesAsync();
            return comment;
        }

        public async Task<Comment> DeleteCommentByIdAsync(Guid commentId, CancellationToken ct)
        {
            var comment = _context.Comments.Where(r => r.Id == commentId).First();
            _context.Comments.Remove(comment);
            await _context.SaveChangesAsync();

            return null;
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