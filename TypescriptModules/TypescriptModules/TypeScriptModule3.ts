import * as Emp from "./TypescriptModule1"
console.log(Emp.EmpAge); 

let empObj = new Emp.Employee("Madhuri", 2);
empObj.displayEmployee();