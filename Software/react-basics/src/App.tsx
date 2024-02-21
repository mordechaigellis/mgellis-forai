import "bootstrap/dist/css/bootstrap.min.css"
import PresidentSummary from "./PresidentSummary"
import PresidentList from "./PresidentList"
import PresidentFeature from "./PresidentFeature"
import presidentdata from "./PresidentData.json"

function App() {
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
              <PresidentSummary presidents={presidentdata} />
            </div>
          </div>
          <div className="row">
            <div className="col-12">
              <PresidentList presidents={presidentdata} />
            </div>
          </div>
        </div>
        <div className="col-6">
          <div className="row">
            <div className="col-12">
              <PresidentFeature president={presidentdata[0]} />
            </div>
          </div>
          <div className="row">
            <div className="col-12">
              <PresidentFeature president={presidentdata[2]} />
            </div>
          </div>
        </div>
      </div>
    </div>
  )
}

export default App
