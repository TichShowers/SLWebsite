using System.Web.Mvc;

namespace SLWebsite.Infrastructure.Extensons
{
    public static class HtmlExtenstions
    {
        public static string IsActiveTab(this HtmlHelper helper, string tabName)
        {
            return helper.ViewBag.TabName == tabName ? "active" : "";
        }
    }
}