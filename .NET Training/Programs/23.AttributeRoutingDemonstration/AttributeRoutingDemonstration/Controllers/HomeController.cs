using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AttributeRoutingDemonstration.Models;

namespace AttributeRoutingDemonstration.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Welcome to Index Method";
        }

        [Route("LogIn")]
        //[Route("Home/LogIn")]
        public string LogIn()
        {
            return "Welcome to LogIn Method";
        }

        public string Register()
        {
            return "Welcome to Register Method";
        }

        [HttpGet]
        [Route("~/Callback")]
        public ActionResult TestMethod()
        {
            return View("Create");
        }

        [HttpPost]
        [ValidateAntiForgeryToken()]
        [Route("~/Callback")]
        public ActionResult TestMethod(CallBackViewModel model)
        {
            return View("Callback",model);
        }
    }
}