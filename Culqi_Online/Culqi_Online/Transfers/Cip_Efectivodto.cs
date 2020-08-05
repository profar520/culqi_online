using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Culqi_Online.Transfers
{
    public class Cip_Efectivodto
    {
        public int ID_Cip { get; set; }
        public int ID_Metodo_Pago { get; set; }
        public int Codigo { get; set; }
        public int ID_Comercio { get; set; }
        public String Cip_Fecha_T { get; set; }
        public String Cip_Fecha_V { get; set; }
    }
}