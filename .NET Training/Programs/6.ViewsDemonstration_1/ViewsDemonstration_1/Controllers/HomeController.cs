using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewsDemonstration_1.UtilityClasses;

namespace ViewsDemonstration_1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.ControllerName = "Home";
            ViewBag.UserList = new List<string>
            {
                "Amit","Utpal","Ravi","Abhik","Tarun"
            };

            //return View(new TestView());

            return View("TestView");
        }

        public ActionResult EditProfile()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
    }
}