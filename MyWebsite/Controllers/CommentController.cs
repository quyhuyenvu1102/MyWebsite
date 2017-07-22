using Microsoft.AspNet.Identity;
using MyWebsite.Models;
using MyWebsite.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MyWebsite.Controllers
{
    [Route(Name ="/[controller]")]
    public class CommentController : Controller
    {
        public readonly ICommentService _service;

        public CommentController() : this(new DefaultCommentService()) { }

        public CommentController(ICommentService service) {
            _service = service;
        }

        [Authorize]
        public ActionResult Index() {
            ApplicationDbContext context = new ApplicationDbContext();
            var comments = context.Comments.ToArray();
            return Json(comments);
        }

        [HttpPost]
        [Authorize]
        [ActionName(nameof(Create))]
        public async Task<ActionResult> Create(Comment comment,Guid blogPostId,CancellationToken ct) {
            var userId = TempData["UserId"];
            var newComment = await _service.CreateCommentAsync(comment,blogPostId,userId.ToString(), ct);
            return Redirect(Request.UrlReferrer.ToString());
            
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult> Delete(Guid commentId, CancellationToken ct) {
            await _service.DeleteCommentByIdAsync(commentId, ct);

            return Redirect(Request.UrlReferrer.ToString());
        }
    }
}