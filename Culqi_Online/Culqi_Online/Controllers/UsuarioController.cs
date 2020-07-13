using Culqi_Online.Models;
using Culqi_Online.Transfers;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Culqi_Online.Controllers
{
    [EnableCors(origins: "*", "*", "*")]
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
        public bool RegistroUsuario(Usuariodto usuariodto)
        {
            if (!Usuario.BuscarCorreo(usuariodto.Correo) && usuariodto.Terminos_Condiciones == "1")
            {
                if (Usuario.CrearUsuario(usuariodto) == 1)
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
