using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCEntityEmployee.Models
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext() : base("EmployeeConnection")//Creating Constructor
        {

        }
        public DbSet<Employee> Employee1 { get; set; }
    }
}