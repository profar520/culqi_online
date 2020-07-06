using Culqi_Online.Transfers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Culqi_Online.Models
{
    public partial class Usuario
    {
        //Crear usuario para metodo get 
        public static int CrearUsuario2(Usuario usuario)
        {
            culqi_dbEntities db = new culqi_dbEntities();
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

        //Crear usuario para metodo post
        public static Usuariodto CrearUsuario(Usuario usuario)
        {
            culqi_dbEntities db = new culqi_dbEntities();
            db.Usuario.Add(usuario);
            try
            {
                db.SaveChanges();
                Usuariodto usuariodto = new Usuariodto();
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

        //Otro

    }
}