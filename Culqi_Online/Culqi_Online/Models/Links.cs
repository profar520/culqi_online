using Culqi_Online.Transfers;
using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace Culqi_Online.Models
{
    public partial class Link
    {

        //crear link
        public static string GenerarLink(Linkdto linkdto)
        {
            bd_culqiEntities db = new bd_culqiEntities();
            //regla 1: monto mayor 0 
            var monto = db.Link.Where(m => m.Monto > 0);
            //regla 2: crear un link
            Link link = new Link();
            link.ID_Link = linkdto.ID_Link;
            link.Monto = linkdto.Monto;
            link.Concepto = linkdto.Concepto;
            link.ID_Moneda = linkdto.ID_Moneda;
            //regla 3: crear token aleatorio
            Guid miGuid = Guid.NewGuid();
            string token = Convert.ToBase64String(miGuid.ToByteArray());
            token = token.Replace("=", "").Replace("+", "").Replace("/", "");
            link.Url = token.Substring(0, 8);
            db.Link.Add(link);

            try
            {
                db.SaveChanges();
                return link.Url;
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