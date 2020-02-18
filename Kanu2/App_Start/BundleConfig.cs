using System.Web;
using System.Web.Optimization;

namespace Kanu2
{
    public class BundleConfig
    {        
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/Vendors/jquery-3.4.1.min.js"
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
                      "~/Content/Stylesheets/site.css"
            ).Include("~/Content/Stylesheets/Vendors/fontawesome-all.min", new CssRewriteUrlTransform()));            

            bundles.Add(new ScriptBundle("~/player/js").Include(
                "~/Scripts/player.js"                
            ));
        }
    }
}
