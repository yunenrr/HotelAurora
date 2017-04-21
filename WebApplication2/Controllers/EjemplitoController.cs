using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication2.Controllers
{
    public class EjemplitoController : ApiController
    {
        // GET: api/Ejemplito
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Ejemplito/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Ejemplito
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Ejemplito/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Ejemplito/5
        public void Delete(int id)
        {
        }
    }
}
