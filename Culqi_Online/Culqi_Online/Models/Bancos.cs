using Culqi_Online.Transfers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Culqi_Online.Models
{
    public partial class Banco
    {
        //Listar los bancos disponibles BBVA, SCOTIABANK, BCP, MIBANCO
        public static IEnumerable<Bancodto> ListarBancos()
        {
            db_culqiEntities db = new db_culqiEntities();
            var lista_bancos = from ban in db.Banco
                               select new Bancodto()
                               {
                                    ID_Banco = ban.ID_Banco,
                                    Nombre_Banco = ban.Nombre_Banco,
                               };
            return lista_bancos;
        }
    }
}