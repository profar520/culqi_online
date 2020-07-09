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
        public int ID_Giro_Negocio { get; set; }
        public string Llave_Publica { get; set; }
        public string Nombre_Comercio { get; set; }
        public string URL_Comercio { get; set; }
        public int celular { get; set; }
        public string Pais { get; set; }
        public bool Terminos_condiciones { get; set; }
        public string Rubro { get; set; }
    }
}