type post = { id: number, body: string, title?: string, userId: number };

let p: post = { id: 1, body: "hello world", userId: 10 };
let msg2: HTMLElement = document.querySelector("#msg") ;
document.querySelector("#btn").addEventListener("click", btnclick)

function btnclick() {
    msg2.innerHTML = p.body;
}