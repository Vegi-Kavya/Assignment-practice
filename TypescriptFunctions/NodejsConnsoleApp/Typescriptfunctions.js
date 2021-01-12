console.log('Hello world');
//Functions in TypeScript
function add(x, y) {
    return x + y;
}
var sum = function (x, y) {
    return x + y;
};
var result = add(2, 3);
console.log(result);
//default parameters
function Mul(x, y, z = 0) {
    return x + y + z;
}
let result1 = Mul(2, 3);
let result2 = Mul(2, 3, 5);
console.log(result1);
console.log(result2);
//without parameters
function Substraction() {
    let a = 10;
    let b = 20;
    return a - b;
}
var result3 = Substraction();
console.log(result3);
//# sourceMappingURL=app.js.map