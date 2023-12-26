type post = { id: number, body: string, title?: string, userId: number };

let p: post; //= { id: 1, body: "hello world", userId: 10 };
let num = 1;
let msg2: HTMLElement = document.querySelector("#msg") ;
document.querySelector("#btn").addEventListener("click", btnclick)

async function btnclick() {
    p = await fetchFromAPI(`https://jsonplaceholder.typicode.com/posts/${num}`);
    num++;
    msg2.innerHTML = p.body;
    //
}

async function fetchFromAPI<T>(url: string): Promise<T> {
    let o: T;
    let r = await fetch(url);
    o = await r.json();
    return o;
}