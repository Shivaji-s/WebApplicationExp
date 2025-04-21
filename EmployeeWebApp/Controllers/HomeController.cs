using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeWebApp.Models;

namespace EmployeeWebApp.Controllers
{
   
    public class HomeController : Controller
    {
        private EmployeeDBContext dBContext = new EmployeeDBContext();

        public ActionResult Index()
        {

            return View();
        }

        public ActionResult EmpList()
        {

            return View(dBContext.employees.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}