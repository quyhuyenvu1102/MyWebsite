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
    [Route("api/customers", Name ="CustomerRoute")]
    public class CustomerController : ApiController
    {
        public ICustomerAPIService _service;

        //public CustomerController():this(new DefaultCustomerService()) { }

        public CustomerController(ICustomerAPIService service) {
            _service = service;
        }
        // GET: api/Customer
        public IEnumerable<Customer> Get()
        => _service.GetAll().ToList();


        // GET: api/Customer/5
        public async Task<IHttpActionResult> Get(int id,CancellationToken ct)
        {
            var customer = await _service.Find(id, ct);

            if (customer == null)
                NotFound();

            return Ok(customer);
        }

        // POST: api/Customer
        public async Task<IHttpActionResult> PostAsync([FromBody]Customer customer, CancellationToken ct)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                await _service.Add(customer, ct);
            }
            catch {
                if (CustomerExists(customer.CustomerId))
                {
                    return Conflict();
                }
                else
                    throw;
            }

            return CreatedAtRoute("CustomerRoute",new { id = customer.CustomerId }, customer);
        }

        // PUT: api/Customer/5
        public async Task<IHttpActionResult> Put(int id, [FromBody]Customer customer,CancellationToken ct)
        {
            if (!ModelState.IsValid) {
                return BadRequest();
            }

            if (id != customer.CustomerId)
                return BadRequest();
            try
            {
                await _service.Update(customer, ct);
            }
            catch {
                if (!CustomerExists(id))
                {
                    NotFound();
                }
                else {
                    throw;
                }
            }
            return StatusCode(HttpStatusCode.NoContent);

        }

        // DELETE: api/Customer/5
        public async Task<IHttpActionResult> Delete(int id,CancellationToken ct)
        {
            if (!CustomerExists(id)) {
                NotFound();
            }

            var customer = await _service.Remove(id, ct);

            return Ok(customer);
        }

        public bool CustomerExists(int id) {
            return _service.GetAll().Where(e => e.CustomerId == id).Count() > 0;
        }
    }
}
