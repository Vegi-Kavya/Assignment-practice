class Person {
    firstName: string;
    lastName: string;

    constructor(fname: string, lname: string) {
        this.firstName = fname;
        this.lastName = lname;
    }
}
function display<T extends Person>(per: T): void {
    console.log(`${per.firstName} ${per.lastName}`);
}
var per = new Person("Kavya", "Vegi");
display(per);
//display("Bill Gates");//gives error
