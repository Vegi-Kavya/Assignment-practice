﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelsinMVC.Models;

namespace ModelsinMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var data = GetEmployee();
            return View("Viewname",data);
        }

        private Employee GetEmployee()
        {
            return new Employee()
            {
                EmpID = 1,
                EmpName = "Kavya",
                Salary = 30000
            };
        }
    }
}