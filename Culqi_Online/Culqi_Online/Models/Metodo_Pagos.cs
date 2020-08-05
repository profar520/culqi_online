using Culqi_Online.Transfers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Culqi_Online.Models
{
    public partial class Metodo_Pago
    {
        public static IEnumerable<Metodo_Pagodto> ListarMetodosPago()
        {
            bd_culqiEntities db = new bd_culqiEntities();
            var lista_metodos_pago = from m in db.Metodo_Pago
                               select new Metodo_Pagodto()
                               {
                                   ID_Metodo_Pago = m.ID_Metodo_Pago,
                                   Metodo_Pago = m.Metodo_Pago1,
                               };
            return lista_metodos_pago;
        }
    }
}