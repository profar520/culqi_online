using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Culqi_Online
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //Configuración y servicios de API web
            var cors = new EnableCorsAttribute("http://localhost:53961", "*", "*");
            config.EnableCors(cors);
            
            // Rutas de API web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
