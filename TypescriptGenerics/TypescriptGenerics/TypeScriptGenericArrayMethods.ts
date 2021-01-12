//Typescript Generic Array Methods
function displayNames<T>(names: T[]): void {
    console.log(names.join(", "));
}
displayNames<string>(["Kavya", "Jyothirmayee", "Samyu", "Neelu"]);
