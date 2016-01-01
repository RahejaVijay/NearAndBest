using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace NearAndBest.WebServices
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "RouteGetAll",
                routeTemplate: "api/{controller}",
                defaults: new { action = "GetAll" }
            );

            config.Routes.MapHttpRoute(
              name: "RouteGetById",
              routeTemplate: "api/{controller}/{id}",
              defaults: new { action = "GetById" }
          );

            config.Routes.MapHttpRoute(
             name: "RouteInsert",
             routeTemplate: "api/{controller}",
             defaults: new { action = "Insert" }
         );

            config.Routes.MapHttpRoute(
               name: "RouteUpdate",
               routeTemplate: "api/{controller}",
               defaults: new { action = "Update" }
           );

            config.Routes.MapHttpRoute(
            name: "RouteDelete",
            routeTemplate: "api/{controller}/Delete",
            defaults: new { action = "Delete" }
        );

            config.Routes.MapHttpRoute(
            name: "RoutePurge",
            routeTemplate: "api/{controller}",
            defaults: new { action = "Purge" }
        );


            config.Formatters.Clear();            
            config.Formatters.Add(new JsonMediaTypeFormatter());
            config.Formatters.Add(new FormUrlEncodedMediaTypeFormatter());
        }
    }
}
