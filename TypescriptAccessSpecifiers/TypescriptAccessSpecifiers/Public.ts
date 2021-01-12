console.log('Hello world');
//Access Specifiers-public,private,protected
class Employee {
    public EmpID: number;
    EmpName: string;
}
//Create a variable
let emp = new Employee();//Instance creaated
emp.EmpID = 101;
emp.EmpName = "Kavya";
console.log(emp.EmpID + " " + emp.EmpName);
class Student {
    public StuName: string;
    StuRegNum: string;
    StuSection: string;
    StuCity: string;
}
let object = new Student();
object.StuName = "Kavya";
object.StuCity = "Visakhapatnam";
object.StuRegNum = "16NM1A05B8";
object.StuSection = "CSE-A";
console.log("Name of the student "+object.StuName + "\n " +"Name of City: "+ object.StuCity +" \n" + "Regd Number"+object.StuRegNum + "\n "+"Section" + object.StuSection);