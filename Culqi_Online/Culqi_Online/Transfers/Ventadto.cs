using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Culqi_Online.Transfers
{
    public class Ventadto
    {
        public int ID_Venta { get; set; }
        public int ID_Comercio { get; set; }
        public int ID_referencia { get; set; }
        public int ID_Tarjeta { get; set; }
        public int ID_Deposito { get; set; }
        public string Nombre_Comercio { get; set; }
        public Nullable<double> Monto { get; set; }
        public string Correo { get; set; }
        public string Estado { get; set; }
    }
}