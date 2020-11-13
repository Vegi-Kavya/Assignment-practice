using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcFirstDBApproach.Models;

namespace MvcFirstDBApproach.Controllers
{
    public class StudentController : Controller
    {
        StudentDBEntities db = new StudentDBEntities();
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        public ViewResult Index1()
        {
            return View(db.Students.ToList());
        }
    }
}