using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace RoutingDemonstration_1.UtilityClasses
{
    public class DeviceConstraint : IRouteConstraint
    {
        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {
            var isMobileDevice = httpContext.Request.Browser.IsMobileDevice;

            return !isMobileDevice;
        }
    }
}