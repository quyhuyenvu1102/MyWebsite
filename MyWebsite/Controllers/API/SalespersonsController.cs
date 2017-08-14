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
    [Route("api/Employees", Name ="SalespersonRoute")]
    public class SalespersonsController : ApiController
    {
        public readonly ISalespersonService _service;

        public SalespersonsController(ISalespersonService service) {
            _service = service;
        }
        // GET: api/Salespersons
        public IEnumerable<Salesperson> Get()
            => _service.GetAll().ToList();

        // GET: api/Salespersons/5
        public async Task<IHttpActionResult> Get(int id, CancellationToken ct)
        {
            var salesperson = await _service.Find(id, ct);
            if (salesperson == null)
                return NotFound();
            return Ok(salesperson);
        }


        // AddAsync Method doesn't work for no fking reason
        // POST: api/Salespersons
        public IHttpActionResult Post([FromBody]Salesperson person,CancellationToken ct)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                 _service.Add(person);
            }
            catch
            {
                if(SalespersonExists(person.SalespersonId))
                {
                    return Conflict();
                }
                throw;
            }

            return CreatedAtRoute("SalespersonRoute", new { id = person.SalespersonId }, person);
        }

        // PUT: api/Salespersons/5
        public async Task<IHttpActionResult> Put(int id, [FromBody]Salesperson person,CancellationToken ct)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id!= person.SalespersonId)
            {
                return BadRequest();
            }

            try
            {
                await _service.Update(person, ct);
            }
            catch
            {
                if (!SalespersonExists(id))
                {
                    return NotFound();
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // DELETE: api/Salespersons/5
        public async Task<IHttpActionResult> Delete(int id,CancellationToken ct)
        {
            if (!SalespersonExists(id))
            {
                return NotFound();
            }

            var response = await _service.Remove(id, ct);
            return Ok(response);
        }

        public bool SalespersonExists(int id)
            => _service.GetAll().Where(e => e.SalespersonId == id).Count() > 0;
    }
}
