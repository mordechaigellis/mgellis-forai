//1 create person object using constructor
function Person(){
    return {
        name : "John",
        age:16
    }
}
//2 get 3 instances of person and log them
const a = new Person;
const b = new Person();
b.name = "Jim";
b.DOB = "1/1/1900";
let c = new Person;

console.log(a);
console.log(b);
console.log(c);
console.log(typeof(c));