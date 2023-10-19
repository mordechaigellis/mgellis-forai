fetch("ttps://jsonplaceholder.typicode.com/posts/5")
.then(r => r.json())
.then(p => console.log(p))
.catch(e => console.log(e.message))