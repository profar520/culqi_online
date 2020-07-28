using Culqi_Online.Transfers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Culqi_Online.Models
{
    public partial class Comercio
    {
        public static Comerciodtoresponse CrearComercio(Comerciodto comerciodto)
        {
            db_culqiEntities db = new db_culqiEntities();
            //Generador GUID para Llave publica Comercio
            Comercio comercio = new Comercio();

            Guid guid = Guid.NewGuid();
            var llave = guid.ToString();
            comercio.Llave_Publica = llave;
            comercio.ID_Giro_Negocio = comerciodto.ID_Giro_Negocio;
            comercio.ID_Usuario = comerciodto.ID_Usuario;
            comercio.Nombre_Comercial = comerciodto.Nombre_Comercial;
            comercio.URL_Comercio = comerciodto.URL_Comercio;
            comercio.ID_Ciudad = comerciodto.ID_Ciudad;
            comercio.Celular = comerciodto.Celular;
            db.Comercio.Add(comercio);
            try
            {
                db.SaveChanges();
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

            Usuario usuario = db.Usuario.Find(comerciodto.ID_Usuario);
            usuario.ID_Tipo_Documento = comerciodto.ID_Tipo_Documento;
            usuario.Numero_Documento = comerciodto.Numero_Documento;
            db.Entry(usuario).State = System.Data.Entity.EntityState.Modified;
            try
            {
                db.SaveChanges();
                Comerciodtoresponse comerciodtoresponse = new Comerciodtoresponse();
                comerciodtoresponse.ID_Comercio = comercio.ID_Comercio;
                comerciodtoresponse.Llave_Publica = llave;
                return comerciodtoresponse;
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

        public static bool BuscarNombreComercial(string Nombre_Comercial)
        {
            db_culqiEntities db = new db_culqiEntities();
            try
            {
                var resultado = db.Comercio.Where(u => u.Nombre_Comercial.Contains(Nombre_Comercial));
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