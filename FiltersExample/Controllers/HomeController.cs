using FiltersExample.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FiltersExample.Controllers
{
    // [Authorize]
  //  [HandleError]
   
    public class HomeController : Controller
    {

        //  [AllowAnonymous]

        [CustomException]
        public ActionResult Index()
        {
          
              //  throw new Exception("something wnet wrong in index method");
          
            return View();
        }

        // [OutputCache(Duration =20)]
        [CustomException]
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