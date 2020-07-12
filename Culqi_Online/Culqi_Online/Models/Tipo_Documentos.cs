using Culqi_Online.Transfers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Culqi_Online.Models
{
    public partial class Tipo_Documento
    {
        //Listar el tipo de documento existen DNI, RUC, CARNE EXTRANJERIA
        public static IEnumerable<Tipo_Documentodto> ListarDocumento()
        {
            bd_culqiEntities db = new bd_culqiEntities();
            //Mostrar los tipos de documentos disponibles
            var lista_documento = from doc in db.Tipo_Documento
                    select new Tipo_Documentodto()
                    {
                        ID_Tipo_Documento = doc.ID_Tipo_Documento,
                        valor = doc.valor
                    };
            return lista_documento;
        }

    }
}