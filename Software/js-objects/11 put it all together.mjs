/*
Using API weatherstack.com write a script that allows you to specify two cities and provide the current temperature for each one.
http://api.weatherstack.com/current
    ? access_key = abcd239bbb468aabf8a66e76772f44c0
    & query = New York
*/
let s = await getWeather("New York");
console.log(s);
s = await getWeather("Dallas");
console.log(s);
async function getWeather(city){
    let url = "http://api.weatherstack.com/current?";
    let sp = new URLSearchParams();
    sp.append("access_key","abcd239bbb468aabf8a66e76772f44c0");
    sp.append("query",city);
    let r = await fetch(url + sp.toString());
    let w = await r.json();
    let wdesc = `Weather in ${w.location.name}, ${w.location.region} is ${w.current.temperature}`;
    return wdesc;
}

