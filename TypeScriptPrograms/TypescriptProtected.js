class Student1 {
    constructor(ID, Name) {
        this.StuID = ID;
        this.StuName = Name;
        //console.log(this.StuID + "\n " + this.StuName);
    }
}
class Person extends Student1 {
    constructor(ID, Name, department) {
        //properties of parent class
        super(ID, Name);
        this.department = "department";
        //console.log(this.StuID + "\n " + this.StuName + "\n " + this.department);
    }
    GetResult() {
        return ("StudentID: " + this.StuID + "\n" + "Student Name: " + this.StuName + "\n" + "Department: " + this.department);
    }
}
let student = new Person(103, "Samyu", "cse");
console.log(student.GetResult());
//# sourceMappingURL=Protected.js.map