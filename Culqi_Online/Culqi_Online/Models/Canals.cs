﻿using Culqi_Online.Transfers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Culqi_Online.Models
{
    public partial class Canal
    {
        public static IEnumerable<Canaldto> listar_canal()
        {
            db_culqiEntities db = new db_culqiEntities();
            var list = from b in db.Canal
                           //from c in db.tarjeta


                       select new Canaldto()
                       {
                           ID_Canal = b.ID_Canal,
                           Nombre_Canal = b.Nombre_Canal,

                       };
            return list;
        }
    }
}