using Culqi_Online.Transfers;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;

namespace Culqi_Online.Models
{
    public partial class Comercio
    {
        public static Comerciodto CrearComercio(Comerciodto comerciodto)
        {
            culqi_dbEntities db = new culqi_dbEntities();
            //Generador GUID para Llave publica Comercio
            Comercio comercio = new Comercio();
            Guid guid = Guid.NewGuid();
            var llave = guid.ToString();
            comercio.Llave_Publica = llave;
            comercio.ID_Giro_Negocio = comerciodto.ID_Giro_Negocio;
            comercio.ID_Usuario = comerciodto.ID_Usuario;
            comercio.Nombre_Comercio = comerciodto.Nombre_Comercio;
            comercio.Rubro = comerciodto.Rubro;
            comercio.URL_Comercio = comerciodto.URL_Comercio;
            comercio.Terminos_condiciones = comerciodto.Terminos_condiciones;
            comercio.Pais = comerciodto.Pais;
            comercio.celular = comerciodto.celular;
            db.Comercio.Add(comercio);
            try
            {
                db.SaveChanges();
                comerciodto.ID_Comercio = comercio.ID_Comercio;
                comerciodto.Llave_Publica = llave;
                return comerciodto;
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