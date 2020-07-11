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
    public class CuentaController : ApiController
    {
        // GET: api/Cuenta
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Cuenta/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Cuenta
        [HttpPost]
        [Route("api/afiliar_cuenta/registrar_cuenta")]
        public bool AfiliarCuenta(Cuentadto cuentadto)
        {
            if (cuentadto.Numero_Cuenta.Length == 20)
            {
                if (Cuenta.RegistrarCuenta(cuentadto) == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

        // PUT: api/Cuenta/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Cuenta/5
        public void Delete(int id)
        {
        }
    }
}
