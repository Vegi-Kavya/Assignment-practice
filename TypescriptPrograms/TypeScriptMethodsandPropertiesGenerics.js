function displayType(id, name) {
    id.toString();
    name.toString();
    //id.toFixed();  // Compiler Error: 'toFixed' does not exists on type 'T'
    //name.toUpperCase(); // Compiler Error: 'toUpperCase' does not exists on type 'U'
    console.log(typeof (id) + ", " + typeof (name));
    console.log(id + " " + name);
}
displayType(1, "Kavya");
//Generic with Non-generic Type
function displayType1(id, name) {
    console.log(typeof (id) + ", " + typeof (name));
    console.log(id + " " + name);
}
displayType1(2, "Samyu");
//# sourceMappingURL=TypeScriptMethodsandPropertiesGenerics.js.map