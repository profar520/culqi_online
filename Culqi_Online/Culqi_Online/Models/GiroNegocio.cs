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
            bd_culqiEntities db = new bd_culqiEntities();
            //Mostrar las categorias disponibles
            var lista_categoria = from cat in db.Categoria
                                  select new Giro_Negociodto()
                                  {
                                      ID_Giro_Negocio = cat.ID_Giro_Negocio,
                                      Giro_Negocio = cat.Giro_Negocio
                                  };
            return lista_categoria;

        }

        //Listar a los rubros segun a la categoria o giro de negocio que pertenece
        //public static IEnumerable<Giro_Negociodto> ListarRubroCategoria(int ID_Giro_Negocio)
        //{
        //    //Mostrar los rubros disponibles segun a la categoria que corresponda
        //    bd_culqiEntities db = new bd_culqiEntities();
        //    var lista_rubro_categoria = from cat in db.Categoria.Where(r => r.ID_Giro_Negocio == ID_Giro_Negocio)
        //                                select new Giro_Negociodto()
        //                                {
        //                                    ID_Giro_Negocio = cat.ID_Giro_Negocio,
        //                                    Giro_Negocio = cat.Giro_Negocio,
        //                                    id_categoria = cat.ID_Giro_Negocio,
        //                                };
        //    return lista_rubro_categoria;
        //}



    }

}