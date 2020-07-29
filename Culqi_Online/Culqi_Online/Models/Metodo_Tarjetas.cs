using Culqi_Online.Transfers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Culqi_Online.Models
{
    public partial class Metodo_Tarjeta
    {
        public static int RegistrarPagoTarjeta(Metodo_Tarjetadto metodo_tarjetadto)
        {
            bd_culqiEntities db = new bd_culqiEntities();
            Metodo_Tarjeta metodo_tarjeta = new Metodo_Tarjeta();
            metodo_tarjeta.ID_Metodo_Pago = metodo_tarjetadto.ID_Metodo_Pago;
            metodo_tarjeta.Numero_Tarjeta = metodo_tarjetadto.Numero_Tarjeta;
            metodo_tarjeta.Mes_Año = metodo_tarjetadto.Mes_Año;
            metodo_tarjeta.CVV = metodo_tarjetadto.CVV;
            db.Metodo_Tarjeta.Add(metodo_tarjeta);
            try
            {
                db.SaveChanges();
                return metodo_tarjeta.ID_Metodo_Tarjeta;
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