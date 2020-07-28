using Culqi_Online.Transfers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Culqi_Online.Models
{
    public partial class Lugar
    {
        public static IEnumerable<Lugardto> listar_lugar()
        {
            db_culqiEntities db = new db_culqiEntities();
            var listar_lugar = from l in db.Lugar
                               select new Lugardto()
                               {
                                   ID_Lugar = l.ID_Lugar,
                                   Lugar = l.Lugar1,
                               };
            return listar_lugar;
        }
    }
}