using Culqi_Online.Transfers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Culqi_Online.Models
{
    public partial class  Metodo_Pago
    {
        public static IEnumerable<Metodo_Pagodto> listar_metodo_pago()
        {
            db_culqiEntities db = new db_culqiEntities ();
            var list = from b in db.Metodo_Pago
                        


                       select new Metodo_Pagodto()
                       {
                           ID_Metodo_Pago = b.ID_Metodo_Pago,
                           Metodo_Pago = b.Metodo_Pago1,

                       };
            return list;
        }
    }
}