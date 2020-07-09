﻿using Culqi_Online.Models;
using Culqi_Online.Transfers;
using System.Collections.Generic;
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
        [Route("api/afiliar_comerciante/registrar_usuario")]
        public Usuariodto RegistroUsuario(Usuariodto usuariodto)
        {
            if (!Usuario.BuscarCorreo(usuariodto.Correo))
            {
                return Usuario.CrearUsuario(usuariodto);
            }
            else
            {
                usuariodto.ID_Usuario = 0;
                return usuariodto;
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
