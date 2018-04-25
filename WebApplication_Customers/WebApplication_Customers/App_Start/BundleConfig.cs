using System.Web;
using System.Web.Optimization;

namespace WebApplication_Customers
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //Kendo UI js
            bundles.Add(new ScriptBundle("~/bundles/kendoJS").Include(
                        //"~/Scripts/kendo/2017.3.913/jquery.min.js",
                        "~/Scripts/kendo/2017.3.913/angular.min.js",
                        "~/Scripts/kendo/2017.3.913/jszip.min.js",
                        "~/Scripts/kendo/2017.3.913/kendo.all.min.js"));

            //Kendo UI css
            bundles.Add(new StyleBundle("~/Content/kendoCSS").Include(
                     "~/Content/kendo/2017.3.913/kendo.common-material.min.css",
                     "~/Content/kendo/2017.3.913/kendo.mobile.all.min.css",
                     "~/Content/kendo/2017.3.913/kendo.material.min.css"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                     "~/Content/bootstrap.css",
                     "~/Content/Site.css"));
        }
    }
}