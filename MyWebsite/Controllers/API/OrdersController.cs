using AutoMapper;
using AutoMapper.QueryableExtensions;
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
    [Route("api/Orders", Name ="OrderRoute")]
    public class OrdersController : ApiController
    {
        public readonly IOrderApiService _service;

        //public OrdersController() : this(new DefaultOrderService()) { }

        public OrdersController(IOrderApiService service) {
            _service = service;
        }
        // GET: api/Orders
        public IEnumerable<Order> Get()
        {
            //Mapper.Initialize(cfg => cfg.CreateMap<Order,OrderModel>()
            //.ForMember(dest=>dest.TotalDue, opt=> opt.MapFrom(src=> src.TotalDue/100m)));


            //var orders = _service.GetAll().ProjectTo<OrderModel>();
            
            return _service.GetAll().ToList(); 
        }

        // GET: api/Orders/5
        public async Task<IHttpActionResult> Get(int id,CancellationToken ct)
        {
            var order = await _service.Find(id, ct);
            if(order == null)
            {
                NotFound();
            }
            return Ok(order);
        }

        // POST: api/Orders
        public async Task<IHttpActionResult> Post([FromBody]Order order,CancellationToken ct)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
               await _service.Add(order, ct);
            }
            catch {
                if (OrderExists(order.OrderId)) {
                    return Conflict();
                }
                throw;
            }
            return CreatedAtRoute("DefaultApi", new { id = order.OrderId }, order);
        }

        // PUT: api/Orders/5
        public async Task<IHttpActionResult> Put(int id, [FromBody]Order order,CancellationToken ct)
        {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            if (id != order.OrderId) {
                return BadRequest();
            }

            try
            {
                await _service.Update(order, ct);
            }

            catch {
                if(!OrderExists(id))
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

        // DELETE: api/Orders/5
        public async Task<IHttpActionResult> Delete(int id,CancellationToken ct)
        {
            if(!OrderExists(id))
            {
                return NotFound();
            }
            var order = await _service.Remove(id, ct);
            return Ok(order);
        }

        public bool OrderExists(int id)
            => _service.GetAll().Where(e => e.OrderId == id).Count() > 0;
    }
}
