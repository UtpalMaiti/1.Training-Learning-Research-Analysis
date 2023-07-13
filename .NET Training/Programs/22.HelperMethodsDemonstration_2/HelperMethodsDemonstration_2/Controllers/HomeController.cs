using HelperMethodsDemonstration_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace HelperMethodsDemonstration_2.Controllers
{
    public class HomeController : Controller
    {
        private List<Employee> empList = new List<Employee>
            {
                new Employee {Id=101,Name="Abhinav",Location="Bangalore",Salary=12345,Role=Role.Employee },
                new Employee {Id=102,Name="Abhishek",Location="Bangalore",Salary=23456,Role=Role.Employee },
                new Employee {Id=103,Name="Ajay",Location="Chennai",Salary=34567,Role=Role.Employee },
                new Employee {Id=104,Name="Anil",Location="Bangalore",Salary=45678,Role=Role.Lead },
                new Employee {Id=105,Name="Akash",Location="Bangalore",Salary=56789,Role=Role.Employee },
                new Employee {Id=106,Name="Akshay",Location="Chennai",Salary=67890,Role=Role.Employee },
                new Employee {Id=107,Name="Ashish",Location="Bangalore",Salary=15000,Role=Role.Lead },
                new Employee {Id=108,Name="Ashutosh",Location="Chennai",Salary=25000,Role=Role.Employee },
                new Employee {Id=109,Name="Pragim",Location="Bangalore",Salary=35000,Role=Role.Manager }
            };

        // GET: Home
        public ActionResult Index(string Role)
        {
            return View((object)Role);
        }

        public PartialViewResult LoadEmployees(string Role)
        {
            Thread.Sleep(10000);

            if (Role == null || Role == "" || Role == "All")
            {
                return PartialView(empList);
            }
            else
            {
                var filteredList = empList.Where(e => e.Role.ToString() == Role);

                return PartialView(filteredList.ToList());
            }
        }
    }
}