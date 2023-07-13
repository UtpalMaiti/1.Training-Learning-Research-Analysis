using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebAPIDemonstration_2.Models;

namespace WebAPIDemonstration_2.Controllers
{
    [EnableCors("http://localhost:10058","*","*")]
    public class EmployeeApiController : ApiController
    {
        public List<Employee> GetAll()
        {
            return new List<Employee>
            {
                new Employee {Id=101,Name="Abhinav",Location="Bangalore",Salary=12345 },
                new Employee {Id=102,Name="Abhishek",Location="Chennai",Salary=23456 },
                new Employee {Id=103,Name="Ajay",Location="Bangalore",Salary=34567 },
                new Employee {Id=104,Name="Anil",Location="Chennai",Salary=45678 },
                new Employee {Id=105,Name="Anirudh",Location="Bangalore",Salary=56789 }
            };
        }
    }
}
