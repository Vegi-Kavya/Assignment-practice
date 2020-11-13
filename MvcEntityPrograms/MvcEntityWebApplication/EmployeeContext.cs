using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcEntityWebApplication.Models
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext() : base("ProductionConnection")//Creating Constructor
        {

        }
        public DbSet<Employee> Employee { get; set; }
    }
}