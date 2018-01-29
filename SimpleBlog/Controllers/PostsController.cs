using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog.Controllers
{
    public class PostsController : Controller
    {
        public ActionResult Index()
        {
            return Content("new Home route, this is content from the PostsController");
        }
    }
}