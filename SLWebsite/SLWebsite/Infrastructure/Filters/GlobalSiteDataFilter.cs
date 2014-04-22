using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Filters;
using System.Web.Mvc;

namespace SLWebsite.Infrastructure.Filters
{
    public class GlobalSiteDataFilter : IResultFilter
    {
        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            //var repository = DependencyResolver.Current.GetService<GlobalDataRepository>();
            var viewBag = filterContext.Controller.ViewBag;

            //TODO get stuff from repository
            viewBag.ApplicationTitle = "Title";
            viewBag.ApplicationName = "Name";
            viewBag.ApplicationCredits = "Me";
            viewBag.ApplicationCreated = DateTime.UtcNow;
            viewBag.BlogName = "Hello";
        }

        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
        }
    }
}