using System.Web;
using System.Web.Optimization;

namespace SLWebsite
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/styles/login")
                .Include("~/Content/Login.css"));

            bundles.Add(new StyleBundle("~/styles")
                .Include("~/Content/Bootstrap/css/bootstrap.css"));
        }
    }
}
