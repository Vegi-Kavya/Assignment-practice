using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcEntityProject.Models
{
    public class Student
    {
        [Key]
        public int StuID { get; set; }
        public string StuName { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
    }
}