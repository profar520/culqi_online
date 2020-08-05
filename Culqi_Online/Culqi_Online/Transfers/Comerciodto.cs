using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Culqi_Online.Transfers
{
    public class Comerciodto
    {
        public int ID_Comercio { get; set; }
        public int ID_Usuario { get; set; }
        public int ID_Ciudad { get; set; }
        public int ID_Giro_Negocio { get; set; }
        public string Llave_Publica { get; set; }
        public string Nombre_Comercial { get; set; }
        public string URL_Comercio { get; set; }
        public int Celular { get; set; }
        public int ID_Tipo_Documento { get; set; }
        public string Numero_Documento { get; set; }
    }
}