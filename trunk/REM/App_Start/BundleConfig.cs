using System.Web;
using System.Web.Optimization;

namespace REM
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/angularjs").Include(
            "~/Scripts/angular.js"));

            bundles.Add(new ScriptBundle("~/bundles/loadingBar").Include(
            "~/Scripts/loading-bar.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/nanoBar").Include(
            "~/Scripts/nanobar.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/Controllers/Main").Include(
            "~/Scripts/Controllers/Main.js"));

            bundles.Add(new ScriptBundle("~/bundles/Controllers/NavbarController").Include(
            "~/Scripts/Controllers/NavbarController.js"));

            bundles.Add(new ScriptBundle("~/bundles/Controllers/Services").Include(
            "~/Scripts/Controllers/Services.js"));
            //

            bundles.Add(new ScriptBundle("~/Content/dashboard/js/jquery.min.js").Include(
            "~/Content/dashboard/js/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/Content/dashboard/js/bootstrap.min.js").Include(
            "~/Content/dashboard/js/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/Content/dashboard/js/metisMenu.min.js").Include(
            "~/Content/dashboard/js/metisMenu.min.js"));

            bundles.Add(new ScriptBundle("~/Content/dashboard/js/sb-admin-2.js").Include(
            "~/Content/dashboard/js/sb-admin-2.js"));
            //

            bundles.Add(new ScriptBundle("~/Content/dashboard/css/bootstrap.min.css").Include(
            "~/Content/dashboard/css/bootstrap.min.css"));

            bundles.Add(new ScriptBundle("~/Content/dashboard/css/metisMenu.min.css").Include(
            "~/Content/dashboard/css/metisMenu.min.css"));

            bundles.Add(new ScriptBundle("~/Content/dashboard/css/sb-admin-2.css").Include(
            "~/Content/dashboard/css/sb-admin-2.css"));

            bundles.Add(new ScriptBundle("~/Content/dashboard/css/bootstrapfont-awesome.min.css").Include(
            "~/Content/dashboard/css/bootstrapfont-awesome.min.css"));
        }
    }
}
