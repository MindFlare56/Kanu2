using System.Web;
using System.Web.Optimization;

namespace Kanu2
{
    public class BundleConfig
    {        
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/Vendors/jquery-{version}.js"
            ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/Vendors/jquery.validate*"
            ));
          
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/Vendors/modernizr-*"
            ));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/Vendors/bootstrap.js"
            ));

            bundles.Add(new ScriptBundle("~/bundles/fontawesome").Include(
                      "~/Scripts/Vendors/fontawesome/all.js"
            ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/Stylesheets/Vendors/bootstrap.css",                      
                      "~/Content/Stylesheets/player.css",
                      "~/Content/Stylesheets/site.css"
            ).Include("~/Content/Stylesheets/Vendors/fontawesome-all.min", new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/Player/css").Include(
                      "~/Content/Stylesheets/player.css"
            ));

            bundles.Add(new ScriptBundle("~/Player/js").Include(
                "~/Scripts/player.js"
            ));
        }
    }
}
