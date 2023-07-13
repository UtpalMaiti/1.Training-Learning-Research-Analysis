using RoutingDemonstration_1.UtilityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RoutingDemonstration_1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            Route r = new Route("Pragim", new CustomRouteHandler());
            //Route r = new Route("{action}/{controller}", new MvcRouteHandler());

            routes.Add(r);

            //routes.MapRoute("TestRoute", "{controller}/{action}/{id}",
            //    new { controller = "Home", action = "Index", id=UrlParameter.Optional });

            //routes.MapRoute("TestRoute", "Pragim/{controller}/{action}/{id}",
            //    new { controller = "Home", action = "Index", id = UrlParameter.Optional });

            //routes.MapRoute("TestRoute", "Pragim{controller}/{action}/{id}",
            //    new { controller = "Home", action = "Index", id = UrlParameter.Optional });

            //routes.MapRoute("TestRoute", "{controller}/{action}/{id}/{*getAll}",
            //    new { controller = "Home", action = "Index", id = UrlParameter.Optional });

            //routes.MapRoute("MobileRoute", "{controller}/{action}/{id}",
            //    new { controller = "Home", action = "Index", id = UrlParameter.Optional },
            //    //new { abcd = new DeviceConstraint() },
            //    new {controller="^H.+", action="^Index$"},
            //     new string[] { "RoutingDemonstration_1.Admin" });

            //routes.MapRoute("TestRoute", "{controller}/{action}/{id}",
            //    new { controller = "Home", action = "Index", id = UrlParameter.Optional },
            //    new string[] { "RoutingDemonstration_1.Controllers" });
        }
    }
}