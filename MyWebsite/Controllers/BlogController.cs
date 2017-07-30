using Microsoft.AspNet.Identity;
using MyWebsite.Models;
using MyWebsite.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MyWebsite.Controllers
{
    public class BlogController : Controller
    {
        //TODO: update createdAt properties

        public readonly IBlogPostService _postService;
        public readonly ICommentService _commentService;
        
        public BlogController() : this(new DefaultBlogPostService(), new DefaultCommentService()) { }

        public BlogController(IBlogPostService postService, ICommentService commentService) {
            _postService = postService;
            _commentService = commentService;
        }

        // GET: Blog
        public async Task<ActionResult> Index(CancellationToken ct)
        {
            var posts = await _postService.GetPostsAsync(ct);
            return View(posts);
        }
        
        // GET: Blog/Details/5
        public async Task<ActionResult> Details(Guid id,CancellationToken ct)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            
            ViewBag.blogPostId = id;
            TempData["UserId"] = User.Identity.GetUserId();
            //TODO: create helper method to display Image inside the Model
            var post = await _postService.GetPostByIdAsync(id, ct);

            if (post == null) return new HttpStatusCodeResult(HttpStatusCode.NotFound);

            
            return View(post);
        }

        /*[Authorize]
        [HttpPost]
        [ActionName("Details")]
        public async Task<ActionResult> Details(Comment comment, CancellationToken ct) {
            await _commentService.CreateCommentAsync(comment, ct);
            return Redirect(Request.UrlReferrer.ToString());
        }*/

        // GET: Blog/Create
        [Authorize(Roles ="Admin")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Blog/Create
        [HttpPost]
        [Authorize(Roles ="Admin")]
        public async Task<ActionResult> Create(BlogPost post,CancellationToken ct)
        {
            try
            {
                //if (ModelState.IsValid)
                {
                    var userId = User.Identity.GetUserId();
                     var createdPost = await _postService.CreatePostAsync(post,userId, ct);

                     return RedirectToAction("Details", new { id = createdPost.Id });
                }
                //return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Blog/Edit/5
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(Guid id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            //TODO: use Automapper to clean up the code
            var post = _postService.GetPostById(id);

            if (post == null)
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            return View(post);
        }

        // POST: Blog/Edit/5
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> Edit(Guid id, BlogPost post, CancellationToken ct)
        {
            try
            {
                await _postService.UpdatePostAsync(id,post, ct);

                return RedirectToAction("Details", new { id = id });
            }
            catch
            {
                return View();
            }
        }

        // GET: Blog/Delete/5
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(Guid id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var post = _postService.GetPostById(id);
            if (post == null)
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);

            return View(post);
        }

        // POST: Blog/Delete/5
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> Delete(Guid id, CancellationToken ct)
        {
            try
            {
                if (id == null)
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

                await _postService.RemovePostAsync(id,ct);
                
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
