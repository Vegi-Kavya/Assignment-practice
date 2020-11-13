using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcEntityProject.Models;

namespace MvcEntityProject.Controllers
{
    public class StudentController : Controller
    {
        StudentContext db = new StudentContext();
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        public ViewResult Index1()
        {
            return View(db.Student.ToList());
        }
    }
}