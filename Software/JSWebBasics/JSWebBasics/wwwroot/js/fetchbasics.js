let p = { id: 1, body: "hello world", userId: 10 };
let msg2 = document.querySelector("#msg");
document.querySelector("#btn").addEventListener("click", btnclick);
function btnclick() {
    msg2.innerHTML = p.body;
}
//# sourceMappingURL=fetchbasics.js.map