import Header from "./Header"
import ColorBlock from "./ColorBlock"
import "bootstrap/dist/css/bootstrap.min.css"
function App() {
  const blocks: JSX.Element[] = [];
  for (let i = 0; i < 49; i++) {
    blocks.push(<ColorBlock key={i} />)
  }
  return (
    <>
      <Header />
      <div className="row">
        {blocks}
      </div>

    </>
  )
}

export default App
