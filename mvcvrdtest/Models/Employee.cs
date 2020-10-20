using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcvrdtest.Models
{
    public class Employee
    {
        public Int32 Id { get; set; }
        public string EmpName { get; set; }
        public string EmpEmail { get; set; }
        public double EmpSalary { get; set; }
        public string EmpDesignaton { get; set; }

    }
}