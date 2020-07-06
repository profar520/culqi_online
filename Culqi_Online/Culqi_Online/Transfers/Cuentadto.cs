using Culqi_Online.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Culqi_Online.Transfers
{
    public class Cuentadto
    {
        public int ID_Cuenta { get; set; }
        public int ID_Marca { get; set; }
        public int ID_Usuario { get; set; }
        public string Tipo_Moneda { get; set; }
        public string Numero_cuenta { get; set; }

        public virtual Marca Marca { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}