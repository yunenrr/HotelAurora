using System.Web;
using System.Web.Optimization;

namespace WebApplication2
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"
                        ));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/A.css",
                      "~/Content/B.css",
                      "~/Content/estilos.css"
                      ));

            bundles.Add(new ScriptBundle("~/Content/js").Include(
                    "~/Content/js/script1.js",
                    "~/Content/js/script2.js",
                    "~/Content/js/script3.js",
                    "~/Content/js/script4.js",
                    "~/Content/js/script5.js",
                    "~/Content/js/script6.js",
                    "~/Content/js/script7.js",
                    "~/Content/js/script8.js",
                    "~/Content/js/script9.js",
                    "~/Content/js/slider.js"
                ));

            bundles.Add(new ScriptBundle("~/Content/revolution/js").Include(
                    "~/Content/revolution/js/jquery1.js",
                    "~/Content/revolution/js/jquery2.js",
                    "~/Content/revolution/js/extensions/rev1.js",
                    "~/Content/revolution/js/extensions/rev2.js",
                    "~/Content/revolution/js/extensions/rev3.js"
                ));
        }
    }
}
