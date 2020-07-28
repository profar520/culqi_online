using Culqi_Online.Transfers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Culqi_Online.Models
{
    public partial class Tipo_Cuenta
    {
        public static IEnumerable<Tipo_Cuentadto> listar_tipo_cuenta()
        {
            db_culqiEntities db = new db_culqiEntities();
            var list = from b in db.Tipo_Cuenta
                           //from c in db.tarjeta


                       select new Tipo_Cuentadto()
                       {
                           ID_Tipo_cuenta = b.ID_Tipo_cuenta,
                           Cuenta = b.Cuenta,

                       };
            return list;
        }
    }
}