using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcEntityWebApplication.Models;

namespace MvcEntityWebApplication.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeContext emp = new EmployeeContext();
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        public ViewResult Index1()
        {
            return View(emp.Employee.ToList());
        }
    }
}