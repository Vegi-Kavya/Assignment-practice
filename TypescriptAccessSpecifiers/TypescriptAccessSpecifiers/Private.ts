﻿class Employee1{
    public EmpID: number;
    private EmpName: string;
    constructor(ID: number, Name: string) {
        this.EmpID = ID;
        this.EmpName = Name;
    }
    public display() {
        return ("Employee ID " + this.EmpID + "\n" + "Employee Name " + this.EmpName);
        //return ("Employee ID " + this.EmpID);
        //return ("Employee Name " + this.EmpName:""kavya");
    }
}//closing class of Employee

let employe= new Employee1(102,"Bhavya");
employe.EmpID = 103;
//employe.EmpName = "Navya";
console.log(employe.display());
