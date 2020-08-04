using Culqi_Online.Transfers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Culqi_Online.Models
{
    public partial class Cip_Efectivo
    {

        public static int registrarcip(Cip_Efectivodto cip_efectivodto)
        {
            int numero = new Random().Next(0, 99999999);

            bd_culqiEntities db = new bd_culqiEntities();
            Cip_Efectivo cip_efectivo = new Cip_Efectivo();
            cip_efectivo.ID_Metodo_Pago = cip_efectivodto.ID_Metodo_Pago;
            //Generar Cip Aleatorio

            cip_efectivo.Codigo = numero;
            db.Cip_Efectivo.Add(cip_efectivo);

            try
            {
                db.SaveChanges();
                Venta venta = new Venta();
                venta.ID_Cip = cip_efectivo.ID_Cip;
                venta.ID_Comercio = cip_efectivodto.ID_Comercio;
                venta.Fecha_Pago = DateTime.Now;
                db.Venta.Add(venta);
                db.SaveChanges();
                return (int)cip_efectivo.Codigo;
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