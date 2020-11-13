using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web;
using System.Data;
using MvcEntityDemo.Models;
using System.Data.Entity;

namespace MvcEntityDemo.Models
{
    public class ProductContext:DbContext
    {
        public ProductContext():base("ProductionConnection")//Creating Constructor
        {

        }
        public DbSet<Product> ProductTable { get; set; }
    }
}