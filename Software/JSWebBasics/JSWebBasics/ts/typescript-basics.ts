const msg: HTMLElement = document.querySelector("#msg");
document.querySelector("#btn1").addEventListener("click", displayMillisecond);
document.querySelector("#btndivs").addEventListener("click", changeDivs)
const divs = document.querySelectorAll("div");
function displayMillisecond() {
    let color: string = "";
    msg.innerHTML = new Date().getMilliseconds().toString();
    if ((document.querySelector("#optblue") as HTMLInputElement).checked) {
        color = (document.querySelector("#optblue") as HTMLInputElement).value;
    }
    else {
        color = (document.querySelector("#optred") as HTMLInputElement).value;
    }
    msg.style.backgroundColor = color;
}

function changeDivs() {
    divs.forEach(d => d.style.backgroundColor = "silver");
}