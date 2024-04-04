import { useState } from 'react'
import MainScreen from './MainScreen'
import Navbar from './Navbar'
import Sidebar from './SideBar'
import './assets/css/bootstrap.min.css'
function App() {
  const [selectedPartyId, setSelectedPartyId] = useState(1);

  const handlePartySelected = (partyId: number) => {
    setSelectedPartyId(partyId);
  };

  return (
    <div className='container'>
      <div className="row">
        <div className="col-12">
          <Navbar />
        </div>
      </div>
      <div className="row">
        <div className="col-3">
          <Sidebar onPartySelected={handlePartySelected} />
        </div>
        <div className="col-9 bg-primary">
          <MainScreen partyId={selectedPartyId} />
        </div>
      </div>

    </div>
  )
}

export default App
