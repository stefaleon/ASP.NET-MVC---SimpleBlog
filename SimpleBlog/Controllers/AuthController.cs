using SimpleBlog.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SimpleBlog.Controllers
{
    public class AuthController : Controller
    {        
        public ActionResult Login()
        {
            return View(new AuthLogin { });
        }

        [HttpPost]
        public ActionResult Login(AuthLogin form)
        {
            if (!ModelState.IsValid)
                return View(form);                       

            if (form.Password.Length < 4)
            {
                ModelState.AddModelError("Password", "Password has to be at least four characters long!");
                return View(form); 
            }

            FormsAuthentication.SetAuthCookie(form.Username, true);

            return Content($"Posted {form.Username} and {form.Password}");
        }
    }
}