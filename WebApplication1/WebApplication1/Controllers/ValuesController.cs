using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Controllers.Models;

namespace WebApplication1.Controllers
{
    [RoutePrefix("api")]
    public class ValuesController : ApiController
    {
        [Route("values")]
        [HttpGet]
        public  IHttpActionResult GetValues()
        {
            var resutl = new string[]
            {
                "Hello World",
                "Բարեւ Արցախ"
            };

            return Ok(resutl);
        }


        [Route("values")]
        [HttpPost]
        public IHttpActionResult SendValues(Person model)
        {
            if (model == null)
            {
                return BadRequest("model is null");
            }
            model.Age++;
            model.Name += "!";

            if (model.Age < 18)
            {
                return BadRequest();
            }

            return Ok(model);
        }

    }
}
