using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddUser()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult AddUser(User user)
        {
            if (ModelState.IsValid)
            {

                UserRepository repository = new UserRepository();
                repository.AddUser(user);

                ViewBag.msg = "User created";

                return View("Index");
            }

            return View();
        }
    }
}