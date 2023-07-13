using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AreasDemonstration.Areas.Admin.Controllers
{
    public class UserMgmtController : Controller
    {
        // GET: Admin/UserMgmt
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ApproveUsers()
        {
            return View();
        }
    }
}