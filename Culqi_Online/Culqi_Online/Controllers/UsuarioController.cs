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
    public class UsuarioController : ApiController
    {
        // GET: api/Usuario
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Usuario/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Usuario
        [HttpPost]
        [Route("api/registrar_usuario/crear_usuario")]
        public int RegistroUsuario(Usuariodto usuariodto)
        {
            if (!Usuario.BuscarCorreo(usuariodto.Correo) && usuariodto.Terminos_Condiciones == "1")
            {
                return Usuario.CrearUsuario(usuariodto);
            }
            else
            {
                return 0;
            }
        }

        // PUT: api/Usuario/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Usuario/5
        public void Delete(int id)
        {
        }
    }
}
