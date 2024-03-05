import "bootstrap/dist/css/bootstrap.min.css"
import PresidentSummary from "./PresidentSummary"
import PresidentList from "./PresidentList"
import PresidentFeature from "./PresidentFeature"
import initialPresidents from "./PresidentData.json"
import { useState } from "react"

function App() {
  const [presidents, setPresidents] = useState(initialPresidents);

  const handleChangePrez = () => {
    if (presidents.length > 0) {
      const newPresidents = presidents.map(p => ({ ...p }));
      newPresidents[0].lastName = newPresidents[0].lastName + "A";
      console.log("current", presidents[0].lastName);
      console.log("new", newPresidents[0].lastName);
      setPresidents(newPresidents);
    }

  };

  return (
    <div className="container">
      <div className="row">
        <div className="col-12">
          <h1>U.S. Presidents</h1>
          <hr />
        </div>
      </div>
      <div className="row">
        <div className="col-6">
          <div className="row">
            <div className="col-12">
              <PresidentSummary presidents={presidents} />
            </div>
          </div>
          <div className="row">
            <div className="col-3">
              <button onClick={handleChangePrez} className="btn btn-primary">Change Prez</button>
            </div>
          </div>
          <div className="row">
            <div className="col-12">
              <PresidentList presidents={presidents} />
            </div>
          </div>
        </div>
        <div className="col-6">
          <div className="row">
            <div className="col-12">
              <PresidentFeature president={presidents[0]} />
            </div>
          </div>
          <div className="row">
            <div className="col-12">
              <PresidentFeature president={presidents[2]} />
            </div>
          </div>
        </div>
      </div>
    </div>
  )
}

export default App
