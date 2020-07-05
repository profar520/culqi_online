using Culqi_Online.Models;
using Culqi_Online.Transfers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Culqi_Online.Controllers
{
    public class ComercioController : ApiController
    {
        // GET: api/Comercio
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Comercio/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Comercio
        [HttpPost]
        [Route("api/afiliar_comerciante/crear_comercio")]
        public Comerciodto CrearComercio(Comercio comercio)
        {
            return Comerciosoa.CrearComercio(comercio);
        }

        // PUT: api/Comercio/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Comercio/5
        public void Delete(int id)
        {
        }
    }
}
