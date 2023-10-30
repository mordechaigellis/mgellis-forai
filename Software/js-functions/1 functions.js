
let domath = AddIt;

let n = domath(10,9);

console.log(n);

domath = MultiplyIt;

console.log(domath(10,9));

function AddIt(x, y){
    return x + y;
}

function MultiplyIt(x, y){
    return x * y;
}

