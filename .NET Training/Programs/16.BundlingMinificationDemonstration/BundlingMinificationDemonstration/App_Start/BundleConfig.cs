using System.Web;
using System.Web.Optimization;

namespace BundlingMinificationDemonstration
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            BundleTable.EnableOptimizations = true;    //this is Used for minification of CSS abd JS files Bundels

            //bundles.Add(new StyleBundle("~/Content/MyStyles").IncludeDirectory("~/Content/MyStyles", "*.js"
            //    .Include("~/Content/bootstrap.css",
            //    "~/Content/Site.css",
            //    "~/Content/AppStyles.css"));

            bundles.Add(new StyleBundle("~/Content/MyStyles")
               .Include("~/Content/bootstrap.css",
               "~/Content/Site.css",
               "~/Content/AppStyles.css"));

            bundles.Add(new ScriptBundle("~/Scripts/BuiltInScripts").Include(
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/jquery.validate*",
                //"~/Scripts/jquery.validate.unobtrusive.js",
                "~/Scripts/AppScripts-{version}.js"
                ));
        }
    }
}