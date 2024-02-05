type post = { id: number, body: string, title?: string, userId: number };
type weather = {
    date: Date, temperatureC: number, temperatureF: number, readOnly: boolean,summary:string
};

type party = {
    partyId: number;
    partyName: string;
    yearStart: number;
    colorId: number;
    partyColor: string;
    partDesc: string;
}
type president = {
    presidentId: number;
    partyId: number;
    num: number | null;
    firstName: string;
    lastName: string;
    dateBorn: Date | null;
    dateDied: Date | null;
    termStart: number | null;
    termEnd: number | null;
}
const domain = window.location.hostname;
console.log(window.Location);
console.log(domain);
let rkurl = "https://mgrecordkeeperapi.azurewebsites.net/api/";

//if (domain.toLowerCase() == "localhost") {
//    rkurl = "https://localhost:7286/api/";
//}

const params = new URLSearchParams(window.location.search);
let partyid = params.get("partyid");

let num = 1;
let picnum = 1;
let msg2: HTMLElement = document.querySelector("#msg") ;
document.querySelector("#btn").addEventListener("click", btnWeatherclick);
document.querySelector("#btnParty").addEventListener("click", btnPartyclick);
document.querySelector("#btnPresident").addEventListener("click", btnPresidentclick);

if (partyid) {
    getAndDisplayPresidents(`President/getbyparty/${partyid}`)
}

async function btnPresidentclick() {
    getAndDisplayPresidents("president");
}

async function getAndDisplayPresidents(actionvalue: string) {
    clearCardDiv();
    let wprez: president[] = await fetchFromAPI(`${rkurl + actionvalue}`);
    for (let p of wprez) {
        const newdiv = document.createElement("div");
        newdiv.className = "col";
        newdiv.innerHTML = addPresidentPostcard(p);
        document.querySelector("#dvcards").appendChild(newdiv);
    }
}
function clearCardDiv() {
    let dvcards = document.querySelector("#dvcards");
    dvcards.innerHTML = "";
}
async function btnPartyclick() {
    let wparties: party[] = await fetchFromAPI(`${rkurl}party`);
    clearCardDiv();
    let dvcards = document.querySelector("#dvcards");
    for (let p of wparties) {
        const newdiv = document.createElement("div");
        newdiv.className = "col";
        newdiv.innerHTML = addPartyPostcard(p);
        dvcards.appendChild(newdiv);
    }
    //$(".partycard").click(btnPartyCardClick);   
}

async function btnPartyCardClick() {
    const partyid = this.id;
    getAndDisplayPresidents(`President/getbyparty/${partyid}`)
}
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

function addPartyPostcard(p: party): string {
    let s = "";
    if (picnum > 9) { picnum = 1; }
    s =
        `<div class="card" style="width: 18rem;">
  <img class="card-img-top" src="/images/p${picnum}p.jpeg" alt="${p.partyName}">
  <div class="card-body" style="background-color:${p.partyColor}">
    <h5 class="card-title">${p.partyName}</h5>
    <p class="card-text">${p.partyName + " " + p.yearStart || "body coming soon...."}</p>
    <a href="fetchbasics?partyid=${p.partyId}" class="btn btn-primary partycard">See card ${p.partyName}</a>
  </div>
</div>`
    picnum++;
    return s;
}

function addPresidentPostcard(p: president): string {
    let s = "";
    if (picnum > 9) { picnum = 1; }
    s =
        `<div class="card" style="width: 18rem;">
  <img class="card-img-top" src="/images/p${p.num}p.jpeg" alt="${p.num}">
  <div class="card-body">
    <h5 class="card-title">${p.firstName + " " + p.lastName}</h5>
    <p class="card-text">${p.firstName + " " + p.lastName + ", " + p.termStart || "body coming soon...."}</p>
    <a href="#" class="btn btn-primary">See card ${p.num}</a>
  </div>
</div>`
    picnum++;
    return s;
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