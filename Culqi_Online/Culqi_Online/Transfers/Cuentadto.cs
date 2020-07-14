using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Culqi_Online.Transfers
{
    public class Cuentadto
    {
        public int ID_Cuenta { get; set; }
        public int ID_Banco { get; set; }
        public int ID_Usuario { get; set; }
        public int ID_Tipo_Cuenta { get; set; }
        public int ID_Moneda { get; set; }
        public int ID_Lugar { get; set; }
        public string Numero_Cuenta { get; set; }
    }
}