using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoutingDemonstration_1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.ControllerName = "Home";
            ViewBag.ActionName = "Index";
            ViewBag.getAll = RouteData.Values["getAll"];

            //Debug.WriteLine(ViewBag.getAll);

            return View("TestView");
        }

        public ActionResult Register()
        {
            ViewBag.ControllerName = "Home";
            ViewBag.ActionName = "Register";

            return View("TestView");
        }

        public ActionResult LogOut()
        {
            ViewBag.ControllerName = "Home";
            ViewBag.ActionName = "LogOut";

            return View("TestView");
        }
    }
}