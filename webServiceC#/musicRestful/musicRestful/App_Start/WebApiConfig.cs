using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace musicRestful
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );


            config.Routes.MapHttpRoute(
    name: "musicList",
    routeTemplate: "api/{controller}/{action}",
    defaults: null);

            config.Routes.MapHttpRoute(
    name: "songMaintenance",
    routeTemplate: "api/{controller}/{action}/{acao}/{songId}/{songName}/{songAutor}/{songYear}",
    defaults: new { acao = RouteParameter.Optional, songId = RouteParameter.Optional, songName = RouteParameter.Optional, songAutor = RouteParameter.Optional, songYear = RouteParameter.Optional});

            var appXmlType = config.Formatters.XmlFormatter.SupportedMediaTypes.FirstOrDefault(t => t.MediaType == "application/xml");
            config.Formatters.XmlFormatter.SupportedMediaTypes.Remove(appXmlType);

        }
    }
}
