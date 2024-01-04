type post = { id: number, body: string, title?: string, userId: number };
type weather = {
    date: Date, temperatureC: number, temperatureF: number, readOnly: boolean,summary:string
};

let num = 1;
let picnum = 1;
let msg2: HTMLElement = document.querySelector("#msg") ;
document.querySelector("#btn").addEventListener("click", btnWeatherclick)

async function btnWeatherclick() {
    let w: weather; //= { id: 1, body: "hello world", userId: 10 };
    let wlist: weather[] = await fetchFromAPI(`https://ccapibasics.azurewebsites.net/WeatherForecast`);
    w = wlist[0];
    num++;
    msg2.innerHTML = w.summary;
    const newdiv = document.createElement("div");
    newdiv.className = "col";
    newdiv.innerHTML = addWeatherPostcard(w);
    document.querySelector("#dvcards").appendChild(newdiv);

}

async function btnclick() {
    let p: post; //= { id: 1, body: "hello world", userId: 10 };
    p = await fetchFromAPI(`https://jsonplaceholder.typicode.com/posts/${num}`);
    num++;
    msg2.innerHTML = p.body;
    const newdiv = document.createElement("div");
    newdiv.className = "col";
    newdiv.innerHTML = addPostcard(p);
    document.querySelector("#dvcards").appendChild(newdiv);
    
}

function addWeatherPostcard(w: weather): string {
    let s = "";
    if (picnum > 9) { picnum = 1; }
    s =
        `<div class="card" style="width: 18rem;">
  <img class="card-img-top" src="/images/p${picnum}p.jpg" alt="${w.temperatureC}">
  <div class="card-body">
    <h5 class="card-title">${w.temperatureC}</h5>
    <p class="card-text">${w.summary || "body coming soon...."}</p>
    <a href="#" class="btn btn-primary">See card ${w.temperatureF}</a>
  </div>
</div>`
    picnum++;
    return s;
}
function addPostcard(p: post): string {
    let s = "";
    if (picnum > 9) { picnum = 1; }
    s = 
`<div class="card" style="width: 18rem;">
  <img class="card-img-top" src="/images/p${picnum}p.jpg" alt="${p.title}">
  <div class="card-body">
    <h5 class="card-title">${p.title}</h5>
    <p class="card-text">${p.body || "body coming soon...."}</p>
    <a href="#" class="btn btn-primary">See card ${p.id}</a>
  </div>
</div>`
    picnum++;
    return s;
}

async function fetchFromAPI<T>(url: string): Promise<T> {
    let o: T;
    let r = await fetch(url);
    o = await r.json();
    return o;
}