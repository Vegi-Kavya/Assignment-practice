using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;

namespace MvcEntityProject.Models
{
    public class StudentContext:DbContext
    {
        public StudentContext() : base("ProductionConnection")//Creating Constructor
        {

        }
        public DbSet<Student> Student { get; set; }
    }
}