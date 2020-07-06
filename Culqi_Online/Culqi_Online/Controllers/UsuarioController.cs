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

        // post: api/Usuario/5
        [HttpPost]
        [Route("api/afiliar_comerciante/registrar_usuario2")]
        public int RegistroUsuario2(Usuario usuario)
        {
            return Usuario.CrearUsuario2(usuario);
        }

        // POST: api/Usuario
        [HttpPost]
        [Route("api/afiliar_comerciante/registrar_usuario")]
        public Usuariodto RegistroUsuario(Usuario usuario)
        {
            return Usuario.CrearUsuario(usuario);
        }

        // PUT: api/Usuario/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Usuario/5
        public void Delete(int id)
        {
        }
    }
}
