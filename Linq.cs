using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqexample
{
    class program
    {
        static void Main(string[] args)
        {
            IList<Employee> employeelist = new List<Employee>()
            {
                new Employee(){ EmpID=1,EmpName="kavya",EmpSalary=30000,EmpDesignation="developer"},
                new Employee(){ EmpID=2,EmpName="samyu",EmpSalary=35000,EmpDesignation="testing"},
                new Employee(){ EmpID=3,EmpName="jyothirmayee",EmpSalary=33000,EmpDesignation="training"},
                new Employee(){ EmpID=4,EmpName="neelu",EmpSalary=28000,EmpDesignation="manager"},
            };
            IList<Department> departmentlist = new List<Department>()
            {
                new Department(){ DepID=1,DepName="CSE",EmpDesignation="developer"},
                new Department(){ DepID=2,DepName="ECE",EmpDesignation="manager"},
                new Department(){ DepID=3,DepName="EEE",EmpDesignation="testing"},
                new Department(){ DepID=4,DepName="IT",EmpDesignation="trainer"},
            };
            var EmpName = employeelist.Where(e => e.EmpSalary > 30000).Select(s => s.EmpName);
            var EmpName1 = employeelist.Where(e => e.EmpSalary <=30000).Where(et => et.EmpID == 1).Select(s => s.EmpName);
            var EmpName2 = employeelist.Where(e => e.EmpSalary <= 30000).Where(et => et.EmpDesignation=="manager").Select(s => s.EmpName);
            foreach (var x in EmpName)
            {
                Console.WriteLine(x);
            }
            foreach (var x in EmpName1)
            {
                Console.WriteLine(x);
            }
            foreach (var x in EmpName2)
            {
                Console.WriteLine(x);
            }
            var EmpID = from e in employeelist
                        where
                        e.EmpName == "kavya" && e.EmpID == 1
                        select new { EmpID= e.EmpID };
            EmpID.ToList().ForEach(s => Console.WriteLine(s.EmpID));
            //group by
            var employeeGroupByBatch = from e in employeelist
                                       group e by e.EmpID into eb
                                       orderby eb.Key
                                       select new { eb.Key, eb };
            foreach (var group in employeeGroupByBatch)
            {
                Console.WriteLine("EmpID: {0}", group.Key);
            }
            foreach (var x in EmpID)
            {
                Console.WriteLine(x.EmpID);
            }
            var join = from e1 in employeelist
                       join d1 in departmentlist 
                       on e1.EmpID equals d1.DepID
                       select new
                       {
                           Name = e1.EmpName,
                           designation = d1.EmpDesignation,
                       };
            foreach(var x in join)
            {
                Console.WriteLine("EmpName:"+x.Name+" "+"Designation:"+x.designation);
                Console.ReadKey();
            }
           
            Console.ReadKey();
        }
    }
    class Employee
    {
        private int EmployeeID;
        public int EmpID
        {
            get { return EmployeeID; }
            set { EmployeeID = value; }
        }
        private string EmployeeName;
        public string EmpName
        {
            get { return EmployeeName; }
            set { EmployeeName = value; }
        }
        private int EmployeeSalary;
        public int EmpSalary
        {
            get { return EmployeeSalary; }
            set { EmployeeSalary = value; }
        }
        private string EmployeeDesignation;
        public string EmpDesignation
        {
            get { return EmployeeDesignation; }
            set { EmployeeDesignation = value; }
        }
    }
    class Department
    {
        private int DepartmentID;
        public int DepID
        {
            get { return DepartmentID; }
            set { DepartmentID = value; }
        }
        private string DepartmentName;
        public string DepName
        {
            get { return DepartmentName; }
            set { DepartmentName = value; }
        }
        private string EmployeeDesignation;
        public string EmpDesignation
        {
            get { return EmployeeDesignation; }
            set { EmployeeDesignation = value; }
        }

    }
}
