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

        public readonly IBlogPostService _service;

        public BlogController() : this(new DefaultBlogPostService()) { }

        public BlogController(IBlogPostService service) {
            _service = service;
        }

        // GET: Blog
        public async Task<ActionResult> Index(CancellationToken ct)
        {
            var posts = await _service.GetPostsAsync(ct);
            return View(posts);
        }


        // GET: Blog/Details/5
        public async Task<ActionResult> Details(Guid id,CancellationToken ct)
        {
            //TODO: create helper method to display Image inside the Model
            var post = await _service.GetPostByIdAsync(id, ct);

            if (post == null) return new HttpStatusCodeResult(HttpStatusCode.NotFound);

            
            return View(post);
        }

        // GET: Blog/Create
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Blog/Create
        [HttpPost]
        [Authorize]
        public async Task<ActionResult> Create(BlogPostEntity postEntity,CancellationToken ct)
        {
            try
            {
                //if (ModelState.IsValid)
                {
                     postEntity.Id = Guid.NewGuid();
                     postEntity.ApplicationUserId = User.Identity.GetUserId();

                     var createdPost = await _service.CreatePostAsync(postEntity, ct);

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
        [Authorize]
        public ActionResult Edit(Guid id)
        {
            //TODO: use Automapper to clean up the code
            var post = _service.GetPostById(id);
            
            return View(post);
        }

        // POST: Blog/Edit/5
        [HttpPost]
        [Authorize]
        public async Task<ActionResult> Edit(Guid id, BlogPost post, CancellationToken ct)
        {
            try
            {
                var updatedPost =await _service.UpdatePostAsync(id,post, ct);

                return View("Details", updatedPost);
            }
            catch
            {
                return View();
            }
        }

        // GET: Blog/Delete/5
        [HttpGet]
        [Authorize]
        public ActionResult Delete(Guid id)
        {
            var post = _service.GetPostById(id);

            return View(post);
        }

        // POST: Blog/Delete/5
        [HttpPost]
        [Authorize]
        public async Task<ActionResult> Delete(Guid id, CancellationToken ct)
        {
            try
            {
                await _service.RemovePostAsync(id,ct);
                
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
