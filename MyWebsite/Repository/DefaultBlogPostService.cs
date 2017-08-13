using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using MyWebsite.Models;
using System.Data.Entity;
using System.Collections.ObjectModel;

namespace MyWebsite.Services
{
    public class DefaultBlogPostService : IBlogPostService
    {
        public readonly IApplicationDbContext _context;

        //public DefaultBlogPostService():this(new ApplicationDbContext()) { }

        public DefaultBlogPostService(IApplicationDbContext context) {
            _context = context;
        }

        public async Task<BlogPostEntity> CreatePostAsync(BlogPost post,string userId,CancellationToken ct)
        {
            var postEntity = new BlogPostEntity() {
                ApplicationUserId = userId,
                Content = post.Content,
                Id = Guid.NewGuid(),
                Image = post.Image,
                Title = post.Title,
                CreatedDate = DateTimeOffset.Now,
                ModifiedDate = DateTimeOffset.Now,
                Comments = new Collection<CommentEntity>()
            };
            _context.BlogPosts.Add(postEntity);
            await _context.SaveChangesAsync(ct);

            return postEntity;
        }

        public BlogPost GetPostById(Guid postId)
        {
            var postEntity = _context.BlogPosts.Where(r => r.Id == postId).FirstOrDefault();
            if (postEntity == null) return null;
            //TODO: use automapper to clean up the code
            var post = new BlogPost()
            {
                Title = postEntity.Title,
                Content = postEntity.Content,
                CreatedDate = postEntity.CreatedDate,
                ModifiedDate = postEntity.ModifiedDate,
                Image = postEntity.Image,
                Author = postEntity.User,
                Comments = new List<Comment>()
            };

            foreach (var commentEntity in postEntity.Comments)
            {
                var comment = new Comment()
                {
                    Author = commentEntity.User,
                    Content = commentEntity.Content
                };
                post.Comments.Add(comment);
            }
            return post;
        }
 


        
        public async Task<BlogPost> GetPostByIdAsync(Guid postId, CancellationToken ct)
        {
            var post = await _context.BlogPosts.SingleOrDefaultAsync(r => r.Id == postId,ct);
            if (post == null) return null;

            //TODO: use AutoMapper to clean up the code

            var response = new BlogPost()
            {
                Title = post.Title,
                Content = post.Content,
                Image = post.Image,
                CreatedDate = post.CreatedDate,
                ModifiedDate = post.ModifiedDate,
                Comments = new List<Comment>(),
                Author = post.User
            };

            //TODO: use AutoMapper to clean up the code

            foreach (var commentEntity in post.Comments)
            {
                response.Comments.Add(new Comment()
                {
                    CreatedAt = commentEntity.CreatedAt,
                    ModifedAt = commentEntity.ModifedAt,
                    Id = commentEntity.Id,
                    Author = commentEntity.User,
                    Content = commentEntity.Content
                });
            }
            return response;

        }

        public async Task<IEnumerable<BlogPostEntity>> GetPostsAsync(CancellationToken ct)
        {
            return await _context.BlogPosts.ToArrayAsync();
        }

        public async Task<BlogPostEntity> RemovePostAsync(Guid postId, CancellationToken ct)
        {
            var post = await _context.BlogPosts.SingleOrDefaultAsync(r => r.Id == postId, ct);
            _context.BlogPosts.Remove(post);
            await _context.SaveChangesAsync(ct);
            return post;
        }

        public async Task<BlogPost> UpdatePostAsync(Guid postId, BlogPost post, CancellationToken ct)
        {
            var postEntity = await _context.BlogPosts.SingleOrDefaultAsync(r => r.Id == postId, ct);
            if (postEntity == null) return null;

            postEntity.Title = post.Title;
            postEntity.Content = post.Content;
            postEntity.Image = post.Image;
            postEntity.ModifiedDate = DateTimeOffset.Now;

            post.Author = postEntity.User;
            post.CreatedDate = postEntity.CreatedDate;
            post.ModifiedDate = postEntity.ModifiedDate;

            await _context.SaveChangesAsync(ct);
            return post;
        }
    }
}