using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcEntityDemo.Models;

namespace MvcEntityDemo.Controllers
{
    public class ProductsController : Controller
    {
        ProductContext db = new ProductContext();

        // GET: Products
        public ActionResult Index()
        {
            return View();
        }
        public ViewResult Index1()
        {
            return View(db.ProductTable.ToList());
        }
    }
}