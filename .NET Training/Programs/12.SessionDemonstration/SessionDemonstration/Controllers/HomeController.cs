using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SessionDemonstration.Controllers
{
    //<!-- Disabled at Controller level -->
    //[SessionState(System.Web.SessionState.SessionStateBehavior.Disabled)]
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //Session.Remove()
            //Session.RemoveAll();
            //Session.Clear();

            //Session.Abandon();
            Session["uName"] = "Pragim";
            Session["pwd"] = "Pragim@123";
            ViewBag.Demo = "DemoText";

            return View();
        }

        public ActionResult EditProfile()
        {
            //Session.Abandon();
            return View();
        }

        public ActionResult ChangePassword()
        {
            return View();
        }
    }
}