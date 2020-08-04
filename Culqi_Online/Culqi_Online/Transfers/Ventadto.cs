using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Culqi_Online.Transfers
{
    public class Ventadto
    {
        public int ID_Venta { get; set; }
        public Nullable<int> ID_Cip { get; set; }
        public Nullable<int> ID_Metodo_Tarjeta { get; set; }
        public int ID_Comercio { get; set; }
        public System.DateTime Fecha_Pago { get; set; }
    }
}