using Culqi_Online.Transfers;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;

namespace Culqi_Online.Models
{
    public partial class Comerciosoa
    {
        public static Comerciodto CrearComercio(Comercio comercio)
        {
            culqi_dbEntities db = new culqi_dbEntities();
            //Generador GUID para Llave publica Comercio
            Guid guid = Guid.NewGuid();
            var llave = guid.ToString().Substring(9);
            comercio.Llave_Publica = llave;
            db.Comercio.Add(comercio);
            try
            {
                db.SaveChanges();
                Comerciodto comerciodto = new Comerciodto();
                comerciodto.ID_Comercio = comercio.ID_Comercio;
                comerciodto.Llave_Publica = llave;
                //comerciodto.URL_Comercio = comercio.URL_Comercio;
                //comerciodto.ID_Giro_Negn = comercio.ID_Giro_Negn;
                //comerciodto.Direccion = comercio.Direccion;
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