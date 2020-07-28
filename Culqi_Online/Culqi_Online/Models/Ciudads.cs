using Culqi_Online.Transfers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Culqi_Online.Models
{
    public partial class Ciudad
    {
        public static IEnumerable<Ciudaddto> listar_ciudad()
        {
            db_culqiEntities db = new db_culqiEntities();
            var list = from b in db.Ciudad

                       select new Ciudaddto()
                       {
                           ID_Ciudad = b.ID_Ciudad,
                           Nombre_Ciudad = b.Nombre_Ciudad,

                       };
            return list;
        }
    }
}