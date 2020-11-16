using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MyApp.Models;

namespace MvcAppDb.DBOperation
{
    public class EmployeeRepository
    {
        public int AddEmployee(EmployeeModel model)
        {
            using(var context=new EmployeeDBEntities())
            {
                Employee emp = new Employee()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    Code = model.Code
                };
                context.Employee.Add(emp);
                context.SaveChanges();
                return emp.id;
            }
        }
    }
}
