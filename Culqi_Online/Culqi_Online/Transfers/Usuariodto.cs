using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Culqi_Online.Transfers
{
    public class Usuariodto
    {
        public int ID_Usuario { get; set; }
        public Nullable<int> ID_Tipo { get; set; }
        public Nullable<int> ID_Tipo_Documento { get; set; }
        public string Nombres { get; set; }
        public string Correo { get; set; }
        public string Contrasenia { get; set; }
    }
}