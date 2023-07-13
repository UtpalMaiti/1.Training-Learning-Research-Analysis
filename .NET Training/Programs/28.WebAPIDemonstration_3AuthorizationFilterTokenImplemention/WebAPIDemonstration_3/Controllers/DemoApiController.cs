using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIDemonstration_3.Controllers
{
    public class DemoApiController : ApiController
    {
        [Route("api/DemoApi/Name")]
        public string GetByName()
        {
            return "Getting the Details By Name";
        }

        [Route("api/DemoApi/Id")]
        public string GetById()
        {
            return "Getting the Details By ID";
        }
    }
}
