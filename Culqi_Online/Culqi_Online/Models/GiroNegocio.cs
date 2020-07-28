using Culqi_Online.Transfers;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Culqi_Online.Models
{
    public partial class Categoria
    //Listar al solamente al giro de negocio 
    {
        public static IEnumerable<Giro_Negociodto> ListarCategoria()
        {
            db_culqiEntities db = new db_culqiEntities();
            //Mostrar las categorias disponibles
            var lista_categoria = from cat in db.Categoria
                                  select new Giro_Negociodto()
                                  {
                                      ID_Giro_Negocio = cat.ID_Giro_Negocio,
                                      Giro_Negocio = cat.Giro_Negocio
                                  };
            return lista_categoria;

        }
    }
}