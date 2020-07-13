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
    public class PublicacionApisController : ApiController
    {
        // GET: api/registrarComercio/listarTipoDocumento
        [HttpGet]
        [Route("api/registrarComercio/listarTipoDocumento")]
        public IEnumerable<Tipo_Documentodto> ListarDocumento()
        {
            return Tipo_Documento.ListarDocumento();
        }

        // GET: api/registrarComercio/listarCategoriaRubro
        [HttpGet]
        [Route("api/registrarComercio/listarCategoria")]
        public IEnumerable<Giro_Negociodto> ListarCategoria()
        {
            return Categoria.ListarCategoria();
        }

        // GET: api/registrarComercio/listarCategoriaRubro
        [HttpGet]
        [Route("api/registrarComercio/listarCategoriaRubro")]
        public IEnumerable<Rubrodto> ListarRubroCategoria()
        {
            return Rubro.ListarRubroCategoria();
        }

        //GET: api/afiliarCuenta/listarNombreBanco
       [HttpGet]
       [Route("api/afiliarCuenta/listarNombreBanco")]
        public IEnumerable<Bancodto> ListarBancos()
        {
            return Banco.ListarBancos();
        }
    }
}
