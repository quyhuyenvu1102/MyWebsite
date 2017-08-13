using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using MyWebsite.Models;
using MyWebsite.Models.API;
using System.Threading.Tasks;
using System.Threading;
using MyWebsite.Repository.API;

namespace MyWebsite.Controllers.API
{
    [Route("api/Products", Name = "ProductsRoute")]
    public class ProductsController : ApiController
    {
        public readonly IProductAPIService _service;

        public ProductsController(IProductAPIService service) {
            _service = service;     
        }

        //public IHttpActionResult Index() {
        //    var response = new {
        //        Products = Url.Link(nameof(GetProducts), null)
        //    };
        //    return Ok(response);
        //}

        // GET: api/Products
        public IEnumerable<Product> GetProducts()
            => _service.GetAll().ToList();

        // GET: api/Products/5
        //[ResponseType(typeof(Product))]
        public async Task<IHttpActionResult> GetProduct(string id, CancellationToken ct)
        {
            var response = await _service.Find(id,ct);
            if (response == null)
            {
                return NotFound();
            }

            return Ok(response);
        }

        // PUT: api/Products/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutProduct(string id, [FromBody]Product product,CancellationToken ct)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != product.ProductId)
            {
                return BadRequest();
            }

            try
            {
                await _service.Update(product, ct);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Products
        public async Task<IHttpActionResult> PostProduct([FromBody]Product product, CancellationToken ct)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
               await _service.Add(product,ct);
            }
            catch (DbUpdateException)
            {
                if (ProductExists(product.ProductId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = product.ProductId }, product);
        }

        // DELETE: api/Products/5
        [ResponseType(typeof(Product))]
        public async Task<IHttpActionResult> DeleteProduct(string id,CancellationToken ct)
        {
            if (!ProductExists(id))
            {
                return NotFound();
            }

            var product = await _service.Remove(id, ct);

            return Ok(product);
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        private bool ProductExists(string id)
        {
            return _service.GetAll().Count(e => e.ProductId == id) > 0;
        }
    }
}