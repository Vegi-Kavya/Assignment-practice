function getArray1(items: any[]): any[] {
    return new Array().concat(items);
}

let myNumArr = getArray1([100, 200, 300]);
let myStrArr = getArray1(["Hello", "World"]);

myNumArr.push(400);
myStrArr.push("Hello TypeScript"); 

myNumArr.push("Hi");
myStrArr.push(500); 

console.log(myNumArr); 
console.log(myStrArr);