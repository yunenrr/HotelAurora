using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Room",
                url: "room/{id}",
                defaults: new { controller = "Home", action = "Room", idRoom = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "RoomType",
                url: "roomtype/{id}",
                defaults: new { controller = "Home", action = "RoomType", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Booking",
                url: "booking/{id}",
                defaults: new { controller = "Home", action = "Booking", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
