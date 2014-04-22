using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SLWebsite.ViewModels;

namespace SLWebsite.Controllers
{
    public class AuthController : Controller
    {
        public ActionResult Login()
        {
            return View(new AuthLogin());
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Login(AuthLogin form)
        {

            if (!ModelState.IsValid)
            {
                return View(form);
            }
            return Content("SUCCESS");
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Logout()
        {
            return RedirectToRoute("Home");
        }
    }
}