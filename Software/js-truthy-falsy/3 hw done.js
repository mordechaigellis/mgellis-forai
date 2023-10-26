/*
You are working on a web page and have the following task to do in javascript.

The web page is displaying the results of a search. 
Sample search results is <li>red</li><li>green</li><li>blue</li>.

Your job is to enclose the search results in open and close tag for an unordered list. 
If there are no results then display an H2 that says No Results.

You may not use an if statement or ternary operator, you can only do variable assignments.
You also must work with the following variables.
let openlist = ""; let closelist = ""; let searchresults = ""; let e = "";

The final result of your code (list or h2) has to be in the e variable. 
The open and close tags have to be in the open/close list variables.

Write the code for when the there are and are not any search results. Console.log the variable e at the end of each case.
*/
let openlist = ""; let closelist = ""; let searchresults = ""; let e = "";

searchresults = "<li>red</li><li>green</li><li>blue</li>"

openlist = searchresults && "<ul>";

closelist = searchresults && "</ul>";

e = openlist + searchresults + closelist;

console.log(e)

searchresults = "";
openlist = searchresults && "<li>";

closelist = searchresults && "</li>";

e = openlist + searchresults + closelist;

e = e || "<h2>no results<h2>";
console.log(e)