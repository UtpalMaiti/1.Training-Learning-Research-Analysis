using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TempDataDemonstration.Models;

namespace TempDataDemonstration.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        static readonly List<Employee> empList = new List<Employee>
        {
            new Employee {Id=101,Name="Abhinav",Location="Bangalore",Salary=12345 },
            new Employee {Id=102,Name="Abhishek",Location="Chennai",Salary=23456 },
            new Employee {Id=103,Name="Ajay",Location="Bangalore",Salary=34567 },
            new Employee {Id=104,Name="Anil",Location="Chennai",Salary=45678 },
            new Employee {Id=105,Name="Anirudh",Location="Bangalore",Salary=56789 }
        };
        public ActionResult Index()
        {
            return View(empList);
        }

        public ActionResult CreateEmployee()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateEmployee(Employee emp)
        {
            //We write the Code here to insert this record into DB
            empList.Add(emp);
            TempData["message"] = "New Record is Created Successfully";

            return RedirectToAction("Index");
        }
    }
}