using BundlingMinificationDemonstration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace BundlingMinificationDemonstration.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetEmployees()
        {
            //Thread.Sleep(10000);
            EmployeeRepository repo = new EmployeeRepository();

            return Json(repo.GetAllEmployees(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetEmployeeById(int id)
        {
            EmployeeRepository repo = new EmployeeRepository();
            var empList = repo.GetAllEmployees();

            var emp = empList.FirstOrDefault(e => e.Id == id);

            return Json(emp, JsonRequestBehavior.AllowGet);
        }
    }
}