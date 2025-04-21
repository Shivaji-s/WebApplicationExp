using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EmployeeWebApp.Models
{
    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext():base("EmployeesConnection")
        {

        }
        public DbSet<Employee> employees { get; set; }
    }
}