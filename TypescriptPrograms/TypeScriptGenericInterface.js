let kv1 = { key: 1, value: "Kavya" };
let kv2 = { key: 2, value: 12345 };
console.log(kv1);
console.log(kv2);
;
function processNumKeyPairs(key, value) {
    console.log('processNumKeyPairs: key = ' + key + ', value = ' + value);
}
function processStringKeyPairs(key, value) {
    console.log('processStringKeyPairs: key = ' + key + ', value = ' + value);
}
let numKVProcessor = processNumKeyPairs;
numKVProcessor(3, 6789);
let strKVProcessor = processStringKeyPairs;
strKVProcessor(4, "Jerry");
//2nd process
function processKeyPairs(key, value) {
    console.log(`processKeyPairs: key = ${key}, value = ${value}`);
}
let numKVProcessor1 = processKeyPairs;
numKVProcessor(5, 78567); //Output: processKeyPairs: key = 1, value = 12345 
let strKVProcessor1 = processKeyPairs;
strKVProcessor(6, "Samyu");
;
class kvProcessor {
    process(key, val) {
        console.log(`Key = ${key}, val = ${val}`);
    }
}
let procedure = new kvProcessor();
procedure.process(7, 'Neelu');
//# sourceMappingURL=TypeScriptGenericInterface.js.map