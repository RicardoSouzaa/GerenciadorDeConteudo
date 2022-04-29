using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_GerenciadorDeConteudo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                );

            routes.MapRoute(
                "paginas",
                "paginas",
                new { Controller = "Paginas", Action = "Index" }
            );

            routes.MapRoute(
                "paginas_novo",
                "paginas/novo",
                new { Controller = "Paginas", Action = "Index" }
            );

            routes.MapRoute(
                "paginas_criar",
                "paginas/criar",
                new { Controller = "Paginas", Action = "criar" }
            );

            routes.MapRoute(
                "paginas_editar",
                "paginas/editar/{id}",
                new { Controller = "Paginas", Action = "Editar", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                "paginas_alterar",
                "paginas/alterar/{id}",
                new { Controller = "Paginas", Action = "Alterar", id = UrlParameter.Optional }
            );

            routes.MapRoute(
               "paginas_excluir",
               "paginas/excluir/{id}",
               new { Controller = "Paginas", Action = "Excluir", id = UrlParameter.Optional }
           );

            routes.MapRoute(
               "paginas_visualizar",
               "paginas/visualizar/{id}",
               new { Controller = "Paginas", Action = "Visualizar", id = UrlParameter.Optional }
           );
        }
    }
}