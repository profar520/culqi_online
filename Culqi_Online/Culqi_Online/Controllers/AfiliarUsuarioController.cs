﻿using Culqi_Online.Models;
using Culqi_Online.Transfers;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Culqi_Online.Controllers
{
    public class AfiliarUsuarioController : ApiController
    {
        //1

        [HttpGet]
        [Route("api/registrar_usuario/listar_canal")]
        public IEnumerable<Canaldto> listar_canal()
        {
            return Canal.listar_canal();
        }

        //2

        [HttpGet]
        [Route("api/registrar_usuario/listar_tipo_usuario")]
        public IEnumerable<Tipo_Usuariodto> listar_tipo_usuario()
        {
            return Tipo_Usuario.listar_tipo_usuario();
        }


        //3

        [HttpGet]
        [Route("api/registrar_comercio/listar_ciudad")]
        public IEnumerable<Ciudaddto> listar_ciudad()
        {
            return Ciudad.listar_ciudad();
        }


        //4

        [HttpGet]
        [Route("api/afiliar_cuenta/listar_tipo_cuenta")]
        public IEnumerable<Tipo_Cuentadto> listar_tipo_cuenta()
        {
            return Tipo_Cuenta.listar_tipo_cuenta();
        }

        //5

        [HttpGet]
        [Route("api/afiliar_cuenta/listar_lugar")]
        public IEnumerable<Lugardto> listar_lugar()
        {
            return Lugar.listar_lugar();
        }

        //6

        [HttpGet]
        [Route("api/afiliar_cuenta/listar_moneda")]
        public IEnumerable<Monedadto> listar_moneda()
        {
            return Moneda.listar_moneda();
        }

        //CIP


        [HttpPost]
        [Route("api/pagoefectivo/registrarcip")]

        public int registrarcip(Cip_Efectivodto cip_efectivodto)
        {
            return Cip_Efectivo.registrarcip(cip_efectivodto);

        }


        [HttpGet]
        [Route("api/pagoefectivo/listarcip")]

        public IEnumerable<Cip_Efectivodto> listar_cip_efectivo(int ID_Cip)
        {
            return Cip_Efectivo.listar_cip_efectivo(ID_Cip);

        }


    }
}
