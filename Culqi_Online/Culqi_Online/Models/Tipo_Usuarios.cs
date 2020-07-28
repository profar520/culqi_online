using Culqi_Online.Transfers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Culqi_Online.Models
{
    public partial class Tipo_Usuario
    {
        public static IEnumerable<Tipo_Usuariodto> listar_tipo_usuario()
        {
            db_culqiEntities db = new db_culqiEntities();
            var list = from b in db.Tipo_Usuario
                           //from c in db.tarjeta


                       select new Tipo_Usuariodto()
                       {
                           ID_Usuario = b.ID_Tipo,
                           Valor = b.valor,

                       };
            return list;

        }
    }
}