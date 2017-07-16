using MyWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace MyWebsite.Services
{
    public interface IBlogPostService
    {
        Task<BlogPostEntity> CreatePostAsync(BlogPostEntity postEntity, CancellationToken ct);

        Task<BlogPost> UpdatePostAsync(Guid postId,BlogPost post,CancellationToken ct);

        Task<IEnumerable<BlogPostEntity>> GetPostsAsync(CancellationToken ct);

        Task<BlogPost> GetPostByIdAsync(Guid postId, CancellationToken ct);

        BlogPost GetPostById(Guid postId);

        Task<BlogPostEntity> RemovePostAsync(Guid postId, CancellationToken ct);
    }
}