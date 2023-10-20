var myHeaders = new Headers();
myHeaders.append("apikey", "7fEZqjYaBCzgcnEUS0Ufg3fRSuK0aw9b");

var requestOptions = {
  method: 'GET',
  headers: myHeaders,
  redirect: 'follow'
};
//start_date=2010-01-01&end_date=2011-01-01
const sp = new URLSearchParams();
sp.append("start_date","2010-01-01");
sp.append("end_date","2011-01-01");

let url = "https://api.apilayer.com/currency_data/change?" + sp.toString();

const r = await fetch(url,requestOptions);
let c = await r.json();

console.log(c);
