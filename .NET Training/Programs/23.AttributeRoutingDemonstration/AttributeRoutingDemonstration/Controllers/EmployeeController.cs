using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AttributeRoutingDemonstration.Controllers
{
    [RouteArea("RouteArea")]
    [RoutePrefix("Employee")]
    public class EmployeeController : Controller
    {
        [Route("All")]
        public string Index()
        {
            return "Getting all the Employees";
        }

        //        List of in-line constraints.

        //1. { param: bool} = Boolean value

        //2. {param:datetime
        //    } = DateTime value

        //3. {param:decimal
        //} = Decimal value

        //4. {param:double} = Double value

        //5. {param:float} = Single value

        //6. {param:guid} = Guid value

        //7. {param:int} = Int32 value

        //8. {param:long} = Int64 value

        //9. {param:minlength(n)} = string value with at least N number of characters(i.e. { param: minlength(5)} )

        //10. {param:maxlength(n)} = string value with less than N number of characters(i.e. { param: maxlength(5)} )

        //11. {param:length(n)} = string value with exactly N number of characters(i.e. { param: length(3)})

        //12. {param:length(minNumber, maxNumber)} = string value with minimum character and maximum character length.

        //13. {param:min(n)} = An Int64 value that is greater than or equal to N.(i.e. { param: min(2)})

        //14. {param:max(n)} = An Int64 value that is less than or equal to N.(i.e. { param: min(10)})

        //15. {param:range(min, max)}= An Int64 value that should be within range. (i.e. { param: range(2, 5)})

        //16. {param:alpha} =s tring value containing only the A–Z and a–z characters

        //17. {param:regex(pattern)} = (i.e {param:regex(\d+)}) match only number
        //      //Route Constrint
        //[Route("Get/{id:int}")]
        [Route("Get/{id:int:min(234):max(456)}")]
        public string Index(int id)
        {
            return "Getting the Employee Details By Id : " + id;
        }

        //[Route("Get/{name?}")]
        [Route("Get/{name=Pragim}")]
        public string Index(string name)
        {
            return "Getting the Employee Details By Name : " + name;
        }

        [Route("Create")]
        public string CreateEmployee()
        {
            return "Creating an Employee";
        }

        [Route("~/Test")]
        public string TestMethod()
        {
            return "Welcome to TestMethod";
        }
    }
}