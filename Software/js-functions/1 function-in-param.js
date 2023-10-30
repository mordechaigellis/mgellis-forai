

console.log(doMath(AddIt,9,10));
console.log(doMath(MultiplyIt,9,10));

function doMath(f, x, y){
    return f(x,y);
}

function AddIt(x, y){
    return x + y;
}

function MultiplyIt(x, y){
    return x * y;
}
