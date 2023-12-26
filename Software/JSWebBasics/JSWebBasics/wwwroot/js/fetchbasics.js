var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    function adopt(value) { return value instanceof P ? value : new P(function (resolve) { resolve(value); }); }
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : adopt(result.value).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};
let p; //= { id: 1, body: "hello world", userId: 10 };
let num = 1;
let msg2 = document.querySelector("#msg");
document.querySelector("#btn").addEventListener("click", btnclick);
function btnclick() {
    return __awaiter(this, void 0, void 0, function* () {
        p = yield fetchFromAPI(`https://jsonplaceholder.typicode.com/posts/${num}`);
        num++;
        msg2.innerHTML = p.body;
        //
    });
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