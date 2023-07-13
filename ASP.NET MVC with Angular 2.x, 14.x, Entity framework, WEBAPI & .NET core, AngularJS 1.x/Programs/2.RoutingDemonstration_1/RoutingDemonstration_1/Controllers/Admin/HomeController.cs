using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoutingDemonstration_1.Admin
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.ControllerName = "Admin-Home";
            ViewBag.ActionName = "Index";
            //ViewBag.getAll = RouteData.Values["getAll"];

            return View("TestView");
        }

        public ActionResult Register()
        {
            ViewBag.ControllerName = "Admin-Home";
            ViewBag.ActionName = "Register";

            return View("TestView");
        }

        public ActionResult ApproveUsers()
        {
            ViewBag.ControllerName = "Admin-Home";
            ViewBag.ActionName = "ApproveUsers";

            return View("TestView");
        }

    }
}