class KeyValuePair {
    setKeyValue(key, val) {
        this.key = key;
        this.val = val;
    }
    display() {
        console.log(`Key = ${this.key}, val = ${this.val}`);
    }
}
let kvp1 = new KeyValuePair();
kvp1.setKeyValue(1, "Madhuri");
kvp1.display(); //Output: Key = 1, Val = Steve 
let kvp2 = new KeyValuePair();
kvp2.setKeyValue("2", "Daughter of Devbata Naidu");
kvp2.display();
;
class kvProcessor1 {
    process(key, val) {
        console.log(`Key = ${key}, val = ${val}`);
    }
}
let proc = new kvProcessor1();
proc.process(1, 'Kavya');
//# sourceMappingURL=TypeScriptGenericClass.js.map