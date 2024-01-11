var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    function adopt(value) { return value instanceof P ? value : new P(function (resolve) { resolve(value); }); }
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : adopt(result.value).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};
let rkurl = "https://localhost:7286/api/";
let num = 1;
let picnum = 1;
let msg2 = document.querySelector("#msg");
document.querySelector("#btn").addEventListener("click", btnWeatherclick);
document.querySelector("#btnParty").addEventListener("click", btnPartyclick);
document.querySelector("#btnPresident").addEventListener("click", btnPresidentclick);
function btnPresidentclick() {
    return __awaiter(this, void 0, void 0, function* () {
        let wprez = yield fetchFromAPI(`${rkurl}president`);
        for (let p of wprez) {
            const newdiv = document.createElement("div");
            newdiv.className = "col";
            newdiv.innerHTML = addPresidentPostcard(p);
            document.querySelector("#dvcards").appendChild(newdiv);
        }
    });
}
function btnPartyclick() {
    return __awaiter(this, void 0, void 0, function* () {
        let wparties = yield fetchFromAPI(`${rkurl}party`);
        let dvcards = document.querySelector("#dvcards");
        dvcards.innerHTML = "";
        for (let p of wparties) {
            const newdiv = document.createElement("div");
            newdiv.className = "col";
            newdiv.innerHTML = addPartyPostcard(p);
            dvcards.appendChild(newdiv);
        }
    });
}
function btnWeatherclick() {
    return __awaiter(this, void 0, void 0, function* () {
        let w; //= { id: 1, body: "hello world", userId: 10 };
        let wlist = yield fetchFromAPI(`https://ccapibasics.azurewebsites.net/WeatherForecast`);
        w = wlist[0];
        num++;
        msg2.innerHTML = w.summary;
        const newdiv = document.createElement("div");
        newdiv.className = "col";
        newdiv.innerHTML = addWeatherPostcard(w);
        document.querySelector("#dvcards").appendChild(newdiv);
    });
}
function btnclick() {
    return __awaiter(this, void 0, void 0, function* () {
        let p; //= { id: 1, body: "hello world", userId: 10 };
        p = yield fetchFromAPI(`https://jsonplaceholder.typicode.com/posts/${num}`);
        num++;
        msg2.innerHTML = p.body;
        const newdiv = document.createElement("div");
        newdiv.className = "col";
        newdiv.innerHTML = addPostcard(p);
        document.querySelector("#dvcards").appendChild(newdiv);
    });
}
function addPartyPostcard(p) {
    let s = "";
    if (picnum > 9) {
        picnum = 1;
    }
    s =
        `<div class="card" style="width: 18rem;">
  <img class="card-img-top" src="/images/p${picnum}p.jpeg" alt="${p.partyName}">
  <div class="card-body">
    <h5 class="card-title">${p.partyName}</h5>
    <p class="card-text">${p.partyName + " " + p.yearStart || "body coming soon...."}</p>
    <a href="#" class="btn btn-primary">See card ${p.partyName}</a>
  </div>
</div>`;
    picnum++;
    return s;
}
function addPresidentPostcard(p) {
    let s = "";
    if (picnum > 9) {
        picnum = 1;
    }
    s =
        `<div class="card" style="width: 18rem;">
  <img class="card-img-top" src="/images/p${p.num}p.jpeg" alt="${p.num}">
  <div class="card-body">
    <h5 class="card-title">${p.firstName + " " + p.lastName}</h5>
    <p class="card-text">${p.firstName + " " + p.lastName + ", " + p.termStart || "body coming soon...."}</p>
    <a href="#" class="btn btn-primary">See card ${p.num}</a>
  </div>
</div>`;
    picnum++;
    return s;
}
function addWeatherPostcard(w) {
    let s = "";
    if (picnum > 9) {
        picnum = 1;
    }
    s =
        `<div class="card" style="width: 18rem;">
  <img class="card-img-top" src="/images/p${picnum}p.jpg" alt="${w.temperatureC}">
  <div class="card-body">
    <h5 class="card-title">${w.temperatureC}</h5>
    <p class="card-text">${w.summary || "body coming soon...."}</p>
    <a href="#" class="btn btn-primary">See card ${w.temperatureF}</a>
  </div>
</div>`;
    picnum++;
    return s;
}
function addPostcard(p) {
    let s = "";
    if (picnum > 9) {
        picnum = 1;
    }
    s =
        `<div class="card" style="width: 18rem;">
  <img class="card-img-top" src="/images/p${picnum}p.jpg" alt="${p.title}">
  <div class="card-body">
    <h5 class="card-title">${p.title}</h5>
    <p class="card-text">${p.body || "body coming soon...."}</p>
    <a href="#" class="btn btn-primary">See card ${p.id}</a>
  </div>
</div>`;
    picnum++;
    return s;
}
function fetchFromAPI(url) {
    return __awaiter(this, void 0, void 0, function* () {
        let o;
        let r = yield fetch(url);
        o = yield r.json();
        return o;
    });
}
//# sourceMappingURL=fetchbasics.js.map