using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcDbFirstApproach.Models;

namespace MvcDbFirstApproach.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeDBEntities1 emp = new EmployeeDBEntities1();
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        public ViewResult Index1()
        {
            return View(emp.Employees.ToList());
        }
    }
}