using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewsDemonstration_1.UtilityClasses
{
    public class ModifiedRazorViewEngine : RazorViewEngine
    {
        public ModifiedRazorViewEngine()
        {
            ViewLocationFormats = new string[]
            {
                //{1} represent Contollername    {0} represent ViewName
                "~/Views/{1}/{0}.cshtml",
                "~/Views/Common/{0}.cshtml"
            };
        }
    }
}