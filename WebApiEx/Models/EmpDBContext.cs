using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApiEx.Models
{
    public class EmpDBContext : DbContext
    {

        public EmpDBContext(): base("EmployeesConnection")
        {

        }

        public DbSet<Employee> employees { get; set; }

    }
}