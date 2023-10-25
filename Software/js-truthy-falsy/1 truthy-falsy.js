let x; let s;
x = "0";
if(x){
    console.log("has value")
}
else{
    console.log("no value")
}
x = 0;
s = x ? "has value":"no value";
console.log("s",s)

x = "hi";
s = x;
console.log("s",s)

s = x === "hi";
console.log("s",s)