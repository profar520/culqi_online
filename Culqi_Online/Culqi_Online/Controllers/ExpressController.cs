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
    public class ExpressController : ApiController
    {
        //api/CulqiExpress/GenerarLink
        [HttpPost]
        [Route("api/CulqiExpress/GenerarLink")]
        public int GenerarLink(Linkdto linkdto)
        {
            if (linkdto.Monto > 0)
            {
                return Link.GenerarLink(linkdto);
            }
            else
            {
                return 00;
            }
            
        }

        [HttpPost]
        [Route("api/CulqiExpress/CrearOrden")]
        public int CrearOrden(Ordendto ordendto)
        {
            return Orden.CrearOrden(ordendto);
        }

        //Listar todo los enlaces
        [HttpGet]
        [Route("api/CulqiExpress/listar_enlace")]
        public IEnumerable<Linkdto> ListarEnlace()
        {
            return Link.ListarEnlace();
        }

        //Listar todo los enlaces según el id
        [HttpGet]
        [Route("api/CulqiExpress/listarenlaceId")]
        public IEnumerable<Linkdto> ListarEnlaceId(int ID_Link)
        {
            return Link.ListarEnlaceId(ID_Link);
        }

    }
}
