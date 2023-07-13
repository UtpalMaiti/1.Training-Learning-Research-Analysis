using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewsDemonstration_4.Models;

namespace ViewsDemonstration_4.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string Index(Employee emp)
        {
            return "Employee ID is : " + emp.Id + ", Name is : " + emp.Name +
                ", Location is : " + emp.Location + " and Salary is : " + emp.Salary;
        }

        public string EditEmployee(int Id)
        {
            return "Editing Employee whose ID is : " + Id;
        }

        public string DeleteEmployee(int Id)
        {
            return "Deleting Employee whose ID is : " + Id;
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}