using Culqi_Online.Transfers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Culqi_Online.Models
{
    public partial class Usuario
    {
        public static Usuariodto CrearUsuario(Usuariodto usuariodto)
        {
            culqi_dbEntities db = new culqi_dbEntities();
            Usuario usuario = new Usuario();
            usuario.ID_Tipo = usuariodto.ID_Tipo;
            usuario.ID_Tipo_Documento = usuariodto.ID_Tipo_Documento;
            usuario.Nombres = usuariodto.Nombres;
            usuario.Correo = usuariodto.Correo;
            usuario.Contrasenia = usuariodto.Contrasenia;
            db.Usuario.Add(usuario);
            try
            {
                db.SaveChanges();
                usuariodto.ID_Usuario = usuario.ID_Usuario;
                return usuariodto;
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

        internal static bool BuscarCorreo(string correo)
        {
            culqi_dbEntities db = new culqi_dbEntities();
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