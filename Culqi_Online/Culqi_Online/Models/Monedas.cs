using Culqi_Online.Transfers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Culqi_Online.Models
{
    public partial class Moneda
    {
        public static IEnumerable<Monedadto> listar_moneda()
        {
            bd_culqiEntities db = new bd_culqiEntities();
            var listar_moneda = from m in db.Tipo_Moneda
                               select new Monedadto()
                               {
                                   ID_Moneda = m.ID_Moneda,
                                   Moneda = m.Moneda,
                               };
            return listar_moneda;
        }
    }
}