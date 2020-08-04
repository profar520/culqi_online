using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Culqi_Online.Transfers
{
    public class Metodo_Tarjetadto
    {
        public int ID_Metodo_Tarjeta { get; set; }
        public int ID_Metodo_Pago { get; set; }
        public string Numero_Tarjeta { get; set; }
        public Nullable<int> Mes_Año { get; set; }
        public Nullable<int> CVV { get; set; }
        public int ID_Comercio { get; set; }
    }
}