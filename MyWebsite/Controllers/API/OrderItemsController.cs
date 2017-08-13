using MyWebsite.Models.API;
using MyWebsite.Repository.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace MyWebsite.Controllers.API
{
    [Route("api/orderitems",Name ="OrderItemRoute")]
    public class OrderItemsController : ApiController
    {
        public readonly IOrderItemService _service;
        
        public OrderItemsController():this(new DefaultOrderItemService()) { }

        public OrderItemsController(IOrderItemService service)
        {
            _service = service;
        }

        // GET: api/OrderItems
        public IEnumerable<OrderItem> Get()
            => _service.GetAll().ToList();

        // GET: api/OrderItems/5
        public async Task<IHttpActionResult> Get(int id, CancellationToken ct)
        {
            var item= await _service.Find(id, ct);

            if (item == null)
            {
                return NotFound();
            }
                
            return Ok(item);
        }

        // POST: api/OrderItems
        public IHttpActionResult Post([FromBody]OrderItem item, CancellationToken ct)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                _service.Add(item,ct);
            }
            catch
            {
                if(ItemExists(item.OrderItemId))
                {
                    return Conflict();
                }
                throw;
            }
            return CreatedAtRoute("DefaultApi", new { id = item.OrderItemId }, item);
        }

        // PUT: api/OrderItems/5
        public async Task<IHttpActionResult> Put(int id, [FromBody]OrderItem item, CancellationToken ct)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if(id!= item.OrderItemId)
            {
                return BadRequest();
            }

            try
            {
                await _service.Update(item, ct);
            }
            catch
            {
                if(!ItemExists(id))
                {
                    return NotFound();
                }
                throw;
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // DELETE: api/OrderItems/5
        public async Task<IHttpActionResult> Delete(int id,CancellationToken ct)
        {
            var item = await _service.Remove(id, ct);

            if (item == null)
                return NotFound();

            return Ok(item);
        }

        public bool ItemExists(int id)
            => _service.GetAll().Where(e => e.OrderItemId == id).Count() > 0;
    }
}
