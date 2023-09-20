//for all console.log(array variable)

//1 declare array with 4 numbers non-sorted
let a = [8,2,6,1];
console.log(a);
//2 sort the array
a.sort();
console.log('sort',a);
//3 return an array that only has the 2 middle items
let b = a.slice();
console.log('slice without any params',b);
b = a.slice(1,3);
console.log('slice 2 middle items',b);

//4 add the next 3 sequences
a.push(9,10,11);
console.log("push",a);
//5 replace 3 thru 5th item with num spelled out
a.splice(2,3,'six','eight','nine');
console.log("splice",a);
//6 return a new array only with the spelled out values

//7 return a new array that has all the numeric values doubled

//8 use forEach to output the index of each item (indexOf) and it's value

//9 using a for loop show the ascii value for each char in "the twain shall never meet"

//10 loop from 25 to 40 and build a string of chars using the String.fromCharCode method

//11 use the join method to produce the following array as one string of values 'h','a','v,'i','n',g,' ','f','u','n'

//12 destructure 1st 2 elements into two vars

//13 same as 12 and get the rest of the values into a new array

