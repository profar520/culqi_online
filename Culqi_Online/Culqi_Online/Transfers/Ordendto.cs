using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Culqi_Online.Transfers
{
    public class Ordendto
    {
        public int ID_Orden { get; set; }
        public int ID_Link { get; set; }
        public int ID_Metodo_Pago { get; set; }
        public string Correo { get; set; }

        //public virtual Link Link { get; set; }
        //public virtual Metodo_Pago Metodo_Pago { get; set; }
    }
}