using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewDataViewBagDemonstration.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.userName = "Pragim";
            ViewData["locationList"] = new List<string>
            {
                "Bangalore","Chennai","Hyderabad"
            };

            return View();
        }

        public ActionResult EditProfile()
        {
            return View();
        }
    }
}