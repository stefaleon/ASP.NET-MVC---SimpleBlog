using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog.Controllers
{
    public class AuthController : Controller
    {        
        public ActionResult Login()
        {
            return Content("Login! (content from the Login action in the AuthController)");
        }
    }
}