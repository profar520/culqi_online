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
        // GET: api/registrar_comercio/listar_categoria_rubro
        [HttpGet]
        [Route("api/registrar_comercio/listar_tipo_documento")]
        public IEnumerable<Tipo_Documentodto> ListarDocumento()
        {
            return Tipo_Documento.ListarDocumento();
        }

        // GET: registrar_comercio/listar_categoria
        [HttpGet]
        [Route("api/registrar_comercio/listar_categoria")]
        public IEnumerable<Giro_Negociodto> ListarCategoria()
        {
            return Categoria.ListarCategoria();
        }
        
        // GET: api/registrar_comercio/listar_categoria_rubro
        [HttpGet]
        [Route("api/registrar_comercio/listar_categoria_rubro")]
        public IEnumerable<Rubrodto> ListarCategoriaRubro(int ID_Giro_Negocio)
        {
            return Rubro.ListarCategoriaRubro(ID_Giro_Negocio);
        }
      
        //GET: api/afiliarCuenta/listarNombreBanco
        [HttpGet]
       [Route("api/afiliar_cuenta/listar_nombre_banco")]
        public IEnumerable<Bancodto> ListarBancos()
        {
            return Banco.ListarBancos();
        }
    }
}
