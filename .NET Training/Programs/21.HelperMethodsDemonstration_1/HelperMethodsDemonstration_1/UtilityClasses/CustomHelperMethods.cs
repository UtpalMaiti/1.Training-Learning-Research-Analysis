using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Web.Mvc;

namespace HelperMethodsDemonstration_1.UtilityClasses
{
    public static class CustomHelperMethods
    {
        //Html helper Extension Methods in C#
        public static MvcHtmlString DisplayList_New(this Htmlhelper helper, List<string> list)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<ul>");

            foreach (var i in list)
            {
                sb.Append("<li>" + i + "</li");
            }

            sb.Append("</ul>");
            return new MvcHtmlString(sb.ToString());
        }
    }
}