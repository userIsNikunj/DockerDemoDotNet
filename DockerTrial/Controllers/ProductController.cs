using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DockerTrial.Controllers
{
    [RoutePrefix("api/v1")]
    public class ProductController : ApiController
    {
        [Route("products")]
        public IHttpActionResult Get()
        {
            List<String> products = new List<String> { 
            "Football",
            "Clothes",
            "Toys"
            };

            return Ok(products);
        }
    }
}
