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
            ///var id_link2 = db.Link.Where(l => l.ID_Link == id_link);
            //insertar una nueva orden
            Orden orden = new Orden();
            orden.ID_Orden = ordendto.ID_Orden;
            orden.Correo = ordendto.Correo;
            orden.ID_Link = ordendto.ID_Link;

            try
            {
                db.SaveChanges();
                return orden.ID_Orden;
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