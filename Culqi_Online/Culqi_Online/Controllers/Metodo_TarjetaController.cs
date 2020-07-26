using Culqi_Online.Models;
using Culqi_Online.Transfers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Culqi_Online.Controllers
{
    public class Metodo_TarjetaController : ApiController
    {

        [HttpPost]
        [Route("api/registrar_pago/metodo_tarjeta")]
        public int RegistrarPago(Metodo_Tarjetadto metodo_tarjetadto)
        {
            if (metodo_tarjetadto.Numero_Tarjeta.Length == 16 && metodo_tarjetadto.CVV.ToString().Length == 3)
            {
                return Metodo_Tarjeta.RegistrarPagoTarjeta(metodo_tarjetadto);
            }
            else
            {
                return 0;
            }
            
        }

        [HttpGet]
        [Route("api/registrar_pago/listar_metodo_pago")]
        public IEnumerable<Metodo_Pagodto> ListarMetodoPago()
        {
            return Metodo_Pago.ListarMetodosPago();
        }
    }
}
