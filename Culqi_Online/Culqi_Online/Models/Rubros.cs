using Culqi_Online.Transfers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Culqi_Online.Models
{
    public partial class Rubro
    {
        //Listar a los rubros segun a la categoria o giro de negocio que pertenece
        public static IEnumerable<Rubrodto> ListarRubroCategoria()
        {
            //Mostrar los rubros disponibles segun a la categoria que corresponda
            bd_culqiEntities db = new bd_culqiEntities();
            var lista_rubro_categoria = from cat in db.Rubro
                                        select new Rubrodto()
                                        {
                                            ID_Rubro = cat.ID_Rubro,
                                            Nombre_Rubro = cat.Nombre_Rubro,
                                            ID_Giro_Negocio = cat.ID_Giro_Negocio,
                                        };
            return lista_rubro_categoria;
        }
    }
}