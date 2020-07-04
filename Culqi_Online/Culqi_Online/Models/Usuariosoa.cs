using Culqi_Online.Transfers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Culqi_Online.Models
{
    public partial class Usuariosoa
    {
        public static int CrearUsuario(Usuario usuario)
        {
            culqi_dbEntities db = new culqi_dbEntities();
            db.Usuario.Add(usuario);
            db.SaveChanges();
            return usuario.ID_Usuario;
        }
    }
}