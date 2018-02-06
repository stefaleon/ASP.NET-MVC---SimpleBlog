using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog.Areas.Admin.Controllers
{
    [Authorize(Roles = "admin")]
    public class UsersController : Controller
    {
        SimpleBlogModel db = new SimpleBlogModel();

        // GET: Admin/Users
        public ActionResult Index()
        {
            // get the users list from the db and assign it to a viewmodel object
            var usersviewmodel = db.Users.ToList();

            // pass the model to the Index view 
            return View(usersviewmodel);
        }
    }
}