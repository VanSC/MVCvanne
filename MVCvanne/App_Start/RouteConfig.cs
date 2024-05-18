using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCvanne
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                //action recibe el valor del nombre de controller y id el de las funciones
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "People", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
