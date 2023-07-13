using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebAPIDemonstration_3.Controllers
{
    //[BasicAuthorize]
    public class TestApiController : ApiController
    {
        public int GetBalance()
        {
            return 10000;
        }
    }
}