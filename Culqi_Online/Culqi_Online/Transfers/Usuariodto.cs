﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Culqi_Online.Transfers
{
    public class Usuariodto
    {
        public int ID_Usuario { get; set; }
        public int ID_Tipo { get; set; }
        public int ID_Tipo_Doc { get; set; }
        public string Nombres { get; set; }
        public string Correo { get; set; }
        public string Contrasenia { get; set; }
    }
}