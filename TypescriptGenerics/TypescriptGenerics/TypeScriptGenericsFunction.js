function getArray(items) {
    return new Array().concat(items);
}
let myNumArr1 = getArray([100, 200, 300]);
let myStrArr1 = getArray(["Hello", "World"]);
myNumArr1.push(400);
myStrArr1.push("Hello TypeScript");
//myNumArr.push("Hi"); //it gives error because this array only consist  of numbers
//myStrArr.push(500);//Give error
//Calling Generic Function without Specifying the Type
let myNumArr2 = getArray([400, 500, 600]); // OK
let myStrArr2 = getArray(["Hello", "Friends"]);
console.log(myNumArr1);
console.log(myStrArr1);
console.log(myNumArr2);
console.log(myStrArr2);
//# sourceMappingURL=TypeScriptGenericsFunction.js.map