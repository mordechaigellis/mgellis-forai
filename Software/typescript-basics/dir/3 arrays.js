"use strict";
let lst;
lst = ["hello"];
lst.push("hi");
console.log(lst);
let usert;
usert = [0, ""];
usert[0] = 12;
usert[1] = "john";
console.log(usert);
usert.push(9);
let anylst = [];
anylst.push(1);
anylst.push("sdfsf");
anylst.push([1, 2, 3]);
console.log(anylst);
var Size;
(function (Size) {
    Size["small"] = "s";
    Size["medium"] = "m";
    Size["large"] = "l";
})(Size || (Size = {}));
let si = Size.medium;
console.log(si);
console.log("finished");
//# sourceMappingURL=3%20arrays.js.map