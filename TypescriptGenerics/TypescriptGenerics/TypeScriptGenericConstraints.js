class Person {
    constructor(fname, lname) {
        this.firstName = fname;
        this.lastName = lname;
    }
}
function display(per) {
    console.log(`${per.firstName} ${per.lastName}`);
}
var per = new Person("Kavya", "Vegi");
display(per);
//display("Bill Gates");//gives error
//# sourceMappingURL=TypeScriptGenericConstraints.js.map