using Culqi_Online.Transfers;
using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Security.Policy;

namespace Culqi_Online.Models
{
    public partial class Link
    {

        //crear link
        public static int GenerarLink(Linkdto linkdto)
        {
            bd_culqiEntities db = new bd_culqiEntities();

            //regla 1: crear un link
            Link link = new Link();
            link.ID_Link = linkdto.ID_Link;
            link.Monto = linkdto.Monto;
            link.Concepto = linkdto.Concepto;
            link.ID_Moneda = linkdto.ID_Moneda;
            //regla 2: crear token aleatorio
            Guid miGuid = Guid.NewGuid();
            string token = Convert.ToBase64String(miGuid.ToByteArray());
            token = token.Replace("=", "").Replace("+", "").Replace("/", "");
            link.Url = token.Substring(0, 8);
            db.Link.Add(link);

            try
            {
                db.SaveChanges();
                return link.ID_Link;
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

        //Listar enlace
        public static IEnumerable<Linkdto> ListarEnlace()
        {
            bd_culqiEntities db = new bd_culqiEntities();
            var lista_url = from url in db.Link
                               select new Linkdto()
                               {
                                  ID_Link = url.ID_Link,
                                   Url = "http://localhost:65160/Ordens"+"/" + url.Url,
                               }; 
            return lista_url;
        }
    }
}