using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiEx.Models;

namespace WebApiEx.Controllers
{
    public class ValuesController : ApiController
    {

        public HttpResponseMessage Post([FromBody] Employee employee)
        {
            EmpDBContext context = new EmpDBContext();
            context.employees.Add(employee);

            context.SaveChanges();

            return Request.CreateErrorResponse(HttpStatusCode.OK,"New record is inserted");
        }

        // GET api/values
        public List<Employee> Get()
        {
            
            EmpDBContext context = new EmpDBContext();

            return context.employees.ToList();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

       

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
