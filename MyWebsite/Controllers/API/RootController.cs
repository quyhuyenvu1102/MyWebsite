using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyWebsite.Controllers.API
{
    public class RootController : ApiController
    {
        [ActionName("Index")]
        public IHttpActionResult GetRoot() {
            var response = new {
                Product = Url.Link("ProductsRoute", null),
                Sales = Url.Link("SalespersonRoute", null),
                OrderItem = Url.Link("OrderItemRoute", null),
                Order = Url.Link("OrderRoute",null),
                Customer = Url.Link("CustomerRoute",null)
            };
            return Ok(response);
        }
    }
}
