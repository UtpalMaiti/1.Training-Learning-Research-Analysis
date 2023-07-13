﻿using EmployeeCRUDDemonstration.UtilityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EmployeeCRUDDemonstration
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            DependencyResolver.SetResolver(new CustomDependencyResolver());
        }
    }
}
