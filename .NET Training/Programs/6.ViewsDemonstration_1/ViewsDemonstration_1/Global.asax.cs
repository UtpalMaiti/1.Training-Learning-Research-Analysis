using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using ViewsDemonstration_1.UtilityClasses;

namespace ViewsDemonstration_1
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //ViewEngines.Engines.Add(new CustomViewEngine());

            //ViewEngines.Engines.RemoveAt(0);

            ViewEngines.Engines.Clear();

            //ViewEngines.Engines.Add(new RazorViewEngine());

            //ViewEngines.Engines.Insert(0, new CustomViewEngine());

            ViewEngines.Engines.Add(new ModifiedRazorViewEngine());
        }
    }
}