using Culqi_Online.Transfers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Culqi_Online.Models
{
    public partial class Tipo_Documento
    {
        //Listar el tipo de documento existen DNI, RUC, CARNE EXTRANJERIA
        public static IEnumerable<Tipo_Documentodto> ListarDocumento()
        {
            db_culqiEntities db = new db_culqiEntities();
            //Mostrar los tipos de documentos disponibles
            var lista_documento = from doc in db.Tipo_Documento
                    select new Tipo_Documentodto()
                    {
                        ID_Tipo_Documento = doc.ID_Tipo_Documento,
                        valor = doc.valor
                    };
            
            try
            {
                return lista_documento;
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