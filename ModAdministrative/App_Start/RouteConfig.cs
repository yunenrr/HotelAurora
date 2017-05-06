using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ModAdministrative
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Ruta para el login
            routes.MapRoute
            (
                name: "Login",
                url: "login",
                defaults: new { controller = "Login", action = "Login" }
            );

            routes.MapRoute(
                name: "ModAdministrative",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "HomeAdmin", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
