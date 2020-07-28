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
        public string GenerarLink(Linkdto linkdto)
        {
            return Link.GenerarLink(linkdto);
        }

        [HttpPost]
        [Route("api/CulqiExpress/CrearOrden")]
        public int CrearOrden(Ordendto ordendto)
        {
            return Orden.CrearOrden(ordendto);
        }
    }
}
