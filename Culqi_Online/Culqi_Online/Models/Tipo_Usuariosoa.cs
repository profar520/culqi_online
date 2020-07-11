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
            bd_culqiEntities db = new bd_culqiEntities();
            var list = from b in db.Tipo_Usuario
                       //from c in db.tarjeta


                       select new Tipo_Usuariodto()
                       {
                           Valor = b.valor,
      
                      };
            return list;
        }
    }
}