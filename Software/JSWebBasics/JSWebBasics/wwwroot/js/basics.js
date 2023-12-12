document.querySelector("#btn1").addEventListener("click", changeP1);
document.querySelector("#btn2").addEventListener("click", changeAllPtags);
document.querySelector("#btn3").addEventListener("click", changeByClass);
document.querySelector("#btn4").addEventListener("click", changeImages);
document.querySelector("#btn5").addEventListener("click", () => document.querySelector("#msg").outerHTML = "<button>Click me I was a div</button>");
document.querySelector("#btn6").addEventListener("click", changeByWildcard);
const msg = document.querySelector("#msg");
let imgnum = 0;

function changeP1() {
    const p = document.querySelector("#p1");
    p.innerHTML = "I was changed because of my id<br/><img src='images/p3p.jpg' class = 'img-fluid'>";
    p.classList.add("bg-danger");
    p.style.border = "10px solid green";
    p.style.borderTop = "20px solid purple";
    const txt = document.querySelector("#txtValue");
    txt.value = "hi";
}

function changeAllPtags() {
    const lst = document.querySelectorAll("p");
    msg.innerHTML = `${lst.length} p tags found`;
    lst.forEach(p => p.innerHTML = "I was changed!!!");
}

function changeByClass() {
    const lst = document.querySelectorAll(".siteinfo");
    msg.innerHTML = `${lst.length} tags found with call = siteinfo`;
    lst.forEach(p => p.innerHTML = "I was changed because of class = siteinfo");
}
function changeImages() {
    const lst = document.querySelectorAll(".imgchange");
    if (imgnum >= 9) { imgnum = 0 }
    lst.forEach(
        i => {
            i.src = `images/p${++imgnum}p.jpg`;
            console.log(i.src);
        }
    );
}

function changeByWildcard() {
    const s = document.querySelector("#txtValue").value;
    msg.innerHTML = s;
    const lst = document.querySelectorAll(`[class*='${s}']`);
    lst.forEach(e => e.outerHTML = "");
}