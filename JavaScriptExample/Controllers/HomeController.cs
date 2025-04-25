using JavaScriptExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JavaScriptExample.Controllers
{
    public class HomeController : Controller
    {
        public List<Employee> emplist = new List<Employee>();

        public static List<Employee> GetEmployeeDetails()
        {
            List<Employee> list = new List<Employee> { 
            new Employee{ID=1,Name="A", Department="IT",Salary=53463.334,Age=25},
             new Employee{ID=2,Name="B", Department="NON-IT",Salary=673534.43,Age=26},
              new Employee{ID=1,Name="C", Department="IT",Salary=8253435.33,Age=27},
               new Employee{ID=1,Name="D", Department="NON-IT",Salary=53463.334,Age=30}

            };

            return list;
        }
        public ActionResult Index()
        {
            return View();
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

        public ActionResult Getemployees()
        {
            ViewBag.Message = "Employess details";

            emplist = GetEmployeeDetails();

            return View(emplist);
        }

        public ActionResult Hello()
        {
            return Json("hello mvc",JsonRequestBehavior.AllowGet);
        }

        
    }
}