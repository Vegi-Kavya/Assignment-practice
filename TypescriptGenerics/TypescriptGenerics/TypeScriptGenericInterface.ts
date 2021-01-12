//Generic Interface as Type
interface KeyPair<T, U> {
    key: T;
    value: U;
}
let kv1: KeyPair<number, string> = { key: 1, value: "Kavya" }; 
let kv2: KeyPair<number, number> = { key: 2, value: 12345 };
console.log(kv1);
console.log(kv2);

//Generic Interface as Function Type
interface KeyValueProcessor<T, U> {
    (key: T, val: U): void;
};
function processNumKeyPairs(key: number, value: number): void {
    console.log('processNumKeyPairs: key = ' + key + ', value = ' + value)
}
function processStringKeyPairs(key: number, value: string): void {
    console.log('processStringKeyPairs: key = ' + key + ', value = ' + value)
}
let numKVProcessor: KeyValueProcessor<number, number> = processNumKeyPairs;
numKVProcessor(3, 6789); 
let strKVProcessor: KeyValueProcessor<number, string> = processStringKeyPairs;
strKVProcessor(4, "Jerry");

//2nd process
function processKeyPairs<T, U>(key: T, value: U): void {
    console.log(`processKeyPairs: key = ${key}, value = ${value}`)
}
let numKVProcessor1: KeyValueProcessor<number, number> = processKeyPairs;
numKVProcessor(5, 78567); //Output: processKeyPairs: key = 1, value = 12345 
let strKVProcessor1: KeyValueProcessor<number, string> = processKeyPairs;
strKVProcessor(6, "Samyu");

//3rd process
interface IKeyValueProcessor<T, U> {
    process(key: T, val: U): void;
};
class kvProcessor implements IKeyValueProcessor<number, string>
{
    process(key: number, val: string): void {
        console.log(`Key = ${key}, val = ${val}`);
    }
}
let procedure: IKeyValueProcessor<number, string> = new kvProcessor();
procedure.process(7, 'Neelu');