using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoutingDemonstration_1.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            ViewBag.ControllerName = "Order";
            ViewBag.ActionName = "Index";

            return View("TestView");
        }

        public ActionResult CreateOrder()
        {
            ViewBag.ControllerName = "Order";
            ViewBag.ActionName = "CreateOrder";

            return View("TestView");
        }

        public ActionResult ShowOrderSummary()
        {
            ViewBag.ControllerName = "Order";
            ViewBag.ActionName = "ShowOrderSummary";

            return View("TestView");
        }
    }
}