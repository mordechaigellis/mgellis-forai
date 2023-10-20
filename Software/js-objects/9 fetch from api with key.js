var myHeaders = new Headers();
myHeaders.append("apikey", "7fEZqjYaBCzgcnEUS0Ufg3fRSuK0aw9b");

var requestOptions = {
  method: 'GET',
  headers: myHeaders,
  redirect: 'follow'
};

fetch("https://api.apilayer.com/geo/city/name/tokyo", requestOptions)
  .then(response => response.text())
  .then(result => console.log(result))
  .catch(error => console.log('error', error));