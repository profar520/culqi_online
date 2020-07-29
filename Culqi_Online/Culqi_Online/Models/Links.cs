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
            link.Url = "http://localhost:65160/Ordens?ID_Link=";
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
                                   Url = url.Url + url.ID_Link,
                               }; 
            return lista_url;
        }
    }
}