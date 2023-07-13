using HelperMethodsDemonstration_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelperMethodsDemonstration_1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.countryList = new List<string>
            {
                "India","China","Japan","US","UK"
            };

            ViewBag.departmentList = new List<string>
            {
                "Dept1","Dept2","Dept3","Dept4","Dept5"
            };

            ViewBag.deptList = new List<ListItem>
            {
                new ListItem {Id=101,Name="Dept-1" },
                new ListItem {Id=102,Name="Dept-2" },
                new ListItem {Id=103,Name="Dept-3" },
                new ListItem {Id=104,Name="Dept-4" }
            };
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Employee emp)
        {
            return View("ShowDetails", emp);
        }

        [HttpGet]
        public ActionResult EditProfile()
        {
            ViewBag.countryList = new List<string>
            {
                "India","China","Japan","US","UK"
            };

            ViewBag.departmentList = new List<string>
            {
                "Dept1","Dept2","Dept3","Dept4","Dept5"
            };

            ViewBag.deptList = new List<ListItem>
            {
                new ListItem {Id=101,Name="Dept-1" },
                new ListItem {Id=102,Name="Dept-2" },
                new ListItem {Id=103,Name="Dept-3" },
                new ListItem {Id=104,Name="Dept-4" }
            };
            return View();
        }
    }
}