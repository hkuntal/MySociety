using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HRS.Projects.MySociety.WebApp.Controllers
{
    public class FlatsController : ApiController
    {
        // GET api/flats
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/flats/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/flats
        public void Post([FromBody]string value)
        {
        }

        // PUT api/flats/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/flats/5
        public void Delete(int id)
        {
        }
    }
}
