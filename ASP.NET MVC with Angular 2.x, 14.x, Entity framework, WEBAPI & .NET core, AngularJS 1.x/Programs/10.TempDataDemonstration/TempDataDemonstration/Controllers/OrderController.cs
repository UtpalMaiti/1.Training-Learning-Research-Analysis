using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TempDataDemonstration.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            TempData["uName"] = "Pragim";
            TempData["pwd"] = "Pragim@123";

            return View();
        }

        public ActionResult EditProfile()
        {
            return View();
        }

        public ActionResult CreateOrder()
        {
            return View();
        }
    }
}