using Culqi_Online.Transfers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Culqi_Online.Models
{
    public partial class Orden
    {

        public static int CrearOrden(Ordendto ordendto)
        {
            bd_culqiEntities db = new bd_culqiEntities();

            //insertar una nueva orden
            Orden orden = new Orden();
            //orden.ID_Orden = ordendto.ID_Orden;
            orden.Correo = ordendto.Correo;
            orden.ID_Metodo_Pago = ordendto.ID_Metodo_Pago;
            orden.ID_Link = ordendto.ID_Link;
            db.Orden.Add(orden);
            try
            {
                db.SaveChanges();
                return (int)orden.ID_Metodo_Pago;
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

        //otro


    }
}