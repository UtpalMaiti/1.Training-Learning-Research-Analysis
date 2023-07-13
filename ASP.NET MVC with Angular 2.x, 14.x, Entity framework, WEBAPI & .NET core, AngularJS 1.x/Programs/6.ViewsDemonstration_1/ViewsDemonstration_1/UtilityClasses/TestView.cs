using System.IO;
using System.Web.Mvc;

namespace ViewsDemonstration_1.UtilityClasses
{
    public class TestView : IView
    {
        public void Render(ViewContext viewContext, TextWriter writer)
        {
            dynamic list = viewContext.ViewBag.UserList;

            writer.Write("<h2>Understanding the Concept of Views...</h2>");
            writer.Write("<p>Controller Name : <b>" +
            viewContext.ViewBag.ControllerName + "</b></p>");
            writer.Write("<p>User List : </p>");
            writer.Write("<ul>");

            foreach (var i in list)
            {
                writer.Write("<li> " + i + "</li> ");
            }
            writer.Write("</ul>");
        }
    }
}