using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoutingDemonstration_2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //return RedirectToAction("EditEmployee",new { controller = "Home" ,
            //    id =123, Name="Abhishek"});

            //return RedirectToRoute("Default", new
            //{
            //    controller = "Home",
            //    action = "EditEmployee",
            //    id = 123,
            //    Name = "Abhishek"
            //});

            return View();
            //return RedirectToActionPermanent
        }

        public string EditEmployee()
        {
            return "Welcome to EditEmployee Method";
        }

        public string DeleteEmployee()
        {
            return "Welcome to DeleteEmployee Method";
        }
    }
}