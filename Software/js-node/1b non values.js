//declare var and set to specified value below and then checknonvalue
//1 leave with no value
let x;
checknonvalue(x);
//2 set to null
x = null;
checknonvalue(x);
//3 set to NaN with invalid math, specify true for second param
x = "abc" * 23;
checknonvalue(x,true);
//4 set to "abc", specify true for second param
x = "abv";
checknonvalue(x, true);


function checknonvalue(x, includeNaN) {
    console.log('x =', x);
    console.log('== undefined is', x == undefined, ': === undefined is', x === undefined)
    console.log('== null is', x == null, ': === null is', x === null)
    if(includeNaN){
        console.log('== NaN is', x == NaN, ': === NaN is', x === NaN)
        console.log("isNaN(x)",isNaN(x))
        console.log("Number.isNaN(x)",Number.isNaN(x))
    }
    console.log("----------------------------")
}
