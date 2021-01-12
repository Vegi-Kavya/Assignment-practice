class Student1 {
    public StuID :number;
    protected StuName: string;
    constructor(ID: number,Name: string) {
        this.StuID = ID;
        this.StuName = Name;
        //console.log(this.StuID + "\n " + this.StuName);
    }
}
class Person extends Student1 {
    private department: string;
    constructor(ID: number, Name: string, department: string) {
        //properties of parent class
        super(ID, Name);
        this.department = "department";
        //console.log(this.StuID + "\n " + this.StuName + "\n " + this.department);
    }

    public GetResult() {
        return ("StudentID: " + this.StuID + "\n" + "Student Name: " + this.StuName + "\n" + "Department: " + this.department);

    }
}
let student = new Person(103, "Samyu", "cse");
console.log(student.GetResult());
