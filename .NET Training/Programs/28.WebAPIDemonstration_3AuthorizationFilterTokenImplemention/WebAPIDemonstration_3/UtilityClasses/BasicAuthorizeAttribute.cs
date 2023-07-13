using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace WebAPIDemonstration_3.UtilityClasses
{
    public class BasicAuthorizeAttribute : AuthorizationFilterAttribute /*Attribute*/
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            if (actionContext.Request.Headers.Authorization == null)
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
            }
            else
            {
                var data = actionContext.Request.Headers.Authorization.Parameter;
                var originalString = Encoding.UTF8.GetString(Convert.FromBase64String(data));

                var uName = originalString.Split(':')[0];

                var pwd = originalString.Split(':')[1];

                if (!uName.StartsWith("Pr"))
                {
                    actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
                }
            }
            base.OnAuthorization(actionContext);
        }
    }
}