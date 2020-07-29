using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Culqi_Online.Transfers
{
    public class Linkdto
    {
        public int ID_Link { get; set; }
        public int ID_Moneda { get; set; }
        public Nullable<int> Monto { get; set; }
        public string Concepto { get; set; }
        public string Url { get; set; }
    }
}