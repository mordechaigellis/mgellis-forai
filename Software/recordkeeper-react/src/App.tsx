import { useState } from 'react'
import MainScreen from './MainScreen'
import Navbar from './Navbar'
import Sidebar from './SideBar'
import './assets/css/bootstrap.min.css'
function App() {
  const [selectedPartyId, setSelectedPartyId] = useState(0);

  const handlePartySelected = (partyId: number) => {
    setSelectedPartyId(partyId);
  };

  return (
    <div className='container'>
      <div className="row">
        <div className="col-12 px-0">
          <Navbar />
        </div>
      </div>
      <div className="row">
        <div className="col-3 col-lg-2 border boder-light">
          <Sidebar onPartySelected={handlePartySelected} />
        </div>
        <div className="col-9 col-lg-10 bg-primary">
          <MainScreen partyId={selectedPartyId} />
        </div>
      </div>

    </div>
  )
}

export default App
