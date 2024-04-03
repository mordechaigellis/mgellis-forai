import MainScreen from './MainScreen'
import Navbar from './Navbar'
import Sidebar from './SideBar'
import './assets/css/bootstrap.min.css'
function App() {

  return (
    <div className='container'>
      <div className="row">
        <div className="col-12">
          <Navbar />
        </div>
      </div>
      <div className="row">
        <div className="col-3">
          <Sidebar />
        </div>
        <div className="col-9 bg-primary">
          <MainScreen />
        </div>
      </div>

    </div>
  )
}

export default App
