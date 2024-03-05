import "bootstrap/dist/css/bootstrap.min.css"
import PresidentSummary from "./PresidentSummary"
import PresidentList from "./PresidentList"
import PresidentFeature from "./PresidentFeature"
import initialPresidents from "./PresidentData.json"
import { useState } from "react"

function App() {
  const [presidents, setPresidents] = useState(initialPresidents);
  const [featured, setFeatured] = useState(0);

  const getCopyOfPresidents = () => presidents.map(p => ({ ...p }));

  const handleChangePrez = () => {
    const newPresidents = getCopyOfPresidents();
    if (newPresidents.length > 0) {
      newPresidents[0].lastName = newPresidents[0].lastName + "A";
      console.log("current", presidents[0].lastName);
      console.log("new", newPresidents[0].lastName);
      setPresidents(newPresidents);
    }
  };

  const handleAddPresident = () => {
    const newPresidents = getCopyOfPresidents();
    if (newPresidents.length > 0) {
      const newPrez = { ...newPresidents[newPresidents.length - 1] };
      newPrez.lastName += "B";
      newPrez.num++;
      newPresidents.push(newPrez);
      setPresidents(newPresidents);

    }
  };

  const handleChangeFeatured = (value: number) => {
    let newFeatured = featured + value;
    if (newFeatured > -1 && newFeatured <= presidents.length - 1) {
      setFeatured(newFeatured);
    }

  }

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
            <div className="col-3">
              <button onClick={handleAddPresident} className="btn btn-primary">Add Prez</button>
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
            <div className="col-4"><button disabled={featured == 0} onClick={() => handleChangeFeatured(-1)} className="btn btn-success">Back</button></div>
            <div className="col-4"><button disabled={featured == presidents.length - 1} onClick={() => handleChangeFeatured(1)} className="btn btn-success">Next {featured}</button></div>
          </div>
          <div className="row">
            <div className="col-12">
              <PresidentFeature president={presidents[featured]} />
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
