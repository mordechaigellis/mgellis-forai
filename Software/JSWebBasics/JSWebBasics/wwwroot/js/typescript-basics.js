const msg = document.querySelector("#msg");
document.querySelector("#btn1").addEventListener("click", displayMillisecond);
document.querySelector("#btndivs").addEventListener("click", changeDivs);
const divs = document.querySelectorAll("div");
function displayMillisecond() {
    let color = "";
    msg.innerHTML = new Date().getMilliseconds().toString();
    if (document.querySelector("#optblue").checked) {
        color = document.querySelector("#optblue").value;
    }
    else {
        color = document.querySelector("#optred").value;
    }
    msg.style.backgroundColor = color;
}
function changeDivs() {
    divs.forEach(d => d.style.backgroundColor = "silver");
}
//# sourceMappingURL=typescript-basics.js.map