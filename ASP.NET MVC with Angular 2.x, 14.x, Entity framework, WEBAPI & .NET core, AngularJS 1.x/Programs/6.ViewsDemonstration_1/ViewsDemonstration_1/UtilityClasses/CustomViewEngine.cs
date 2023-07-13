using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewsDemonstration_1.UtilityClasses
{
    public class CustomViewEngine : IViewEngine
    {
        public ViewEngineResult FindPartialView(ControllerContext controllerContext, string partialViewName, bool useCache)
        {
            throw new NotImplementedException();
        }

        public ViewEngineResult FindView(ControllerContext controllerContext, string viewName, string masterName, bool useCache)
        {
            if (viewName == "TestView")
            {
                return new ViewEngineResult(new TestView(), this);
            }
            else
            {
                return new ViewEngineResult(new string[] { "No View Found By CustomViewEngine" });
            }
        }

        public void ReleaseView(ControllerContext controllerContext, IView view)
        {
            IDisposable disp = view as IDisposable;
            if (disp != null)
            {
                disp.Dispose();
            }
        }
    }
}