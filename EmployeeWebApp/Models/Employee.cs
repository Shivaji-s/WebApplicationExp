using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeWebApp.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string EmpName { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
        public int age { get; set; }

    }
}