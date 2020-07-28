using Culqi_Online.Transfers;
using System;
using Culqi_Online.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI.WebControls;

namespace Culqi_Online.Models
{
    public partial class Cip_Efectivo
    {

        public static int registrarcip (Cip_Efectivodto cip_efectivodto)
        {
            int numero = new Random().Next(0, 99999999);

            db_culqiEntities db = new db_culqiEntities();
            Cip_Efectivo cip_efectivo = new Cip_Efectivo();
            cip_efectivo.ID_Metodo_Pago = cip_efectivodto.ID_Metodo_Pago;
            //Generar Cip Aleatorio
            
            cip_efectivo.Codigo = numero;  
            db.Cip_Efectivo.Add(cip_efectivo);
            


            try
            {
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

        /*
        public static IEnumerable<Cip_Efectivodto> listar_cip()
        {
            db_culqiEntities db = new db_culqiEntities();
            var list = from b in db.Cip_Efectivo

                       select new Cip_Efectivodto()
                       {
                          
                           Codigo = b.Codigo

                       };
            return list;
        }

        */




        public static DateTime generar_fecha()
        {  
            DateTime dateTime = DateTime.UtcNow.Date;
            DateTime Hoy = DateTime.Today;
            return Hoy;
        }
       


    }
}
 