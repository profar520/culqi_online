using Culqi_Online.Transfers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace Culqi_Online.Models
{
    public partial class Usuario
    {
        public static int CrearUsuario(Usuariodto usuariodto)
        {

            db_culqiEntities db = new db_culqiEntities();
            Usuario usuario = new Usuario();
            usuario.ID_Tipo = usuariodto.ID_Tipo;
            usuario.Nombres = usuariodto.Nombres;
            usuario.Correo = usuariodto.Correo;

            using (var sha256 = new SHA256Managed())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(usuariodto.Contrasenia));
                var hash = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
                usuario.Contrasenia = hash.Substring(0, 24);
            }
            usuario.ID_Canal = usuariodto.ID_Canal;
            usuario.Terminos_Condiciones = usuariodto.Terminos_Condiciones;
            db.Usuario.Add(usuario);
            try
            {
                db.SaveChanges();
                return usuario.ID_Usuario;
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                throw raise;
            }
        }

        public static bool BuscarCorreo(string correo)
        {
            db_culqiEntities db = new db_culqiEntities();
            try
            {
                var resultado = db.Usuario.Where(u => u.Correo.Contains(correo));
                if (resultado.Count() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                throw raise;
            }
        }
    }
}