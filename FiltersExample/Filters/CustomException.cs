using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FiltersExample.Filters
{
    public class CustomException : FilterAttribute, IExceptionFilter //ActionFilterAttribute //
    {
        public void OnException(ExceptionContext filterContext)
        {
           if (filterContext.ExceptionHandled)
                return;

            Console.WriteLine("Exception caught by CustomerExceptionFilter");
            Console.WriteLine(filterContext.Exception.Message);

            filterContext.ExceptionHandled = true;

            filterContext.Result = new ViewResult
            {
                ViewName = "CusteomErrorPage"
            }; 
        }

      /*  public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Console.WriteLine("OnActionExecuting.......");
        }
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Console.WriteLine("OnActionExecuted.......");
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            Console.WriteLine("Before rendering the result.......");
        }
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Console.WriteLine("after rendering the result.......");
        } */
    }

   
}