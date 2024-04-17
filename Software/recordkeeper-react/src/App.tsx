import { useState } from 'react'
import MainScreen from './MainScreen'
import Navbar from './Navbar'
import Sidebar from './SideBar'
import './assets/css/bootstrap.min.css'
import { PartyEdit } from './PartyEdit'
function App() {
  const [selectedPartyId, setSelectedPartyId] = useState(0);
  const [isPartyEdit, setIsPartyEdit] = useState(false);
  const handlePartySelected = (partyId: number) => {
    setIsPartyEdit(false);
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
          <button onClick={() => setIsPartyEdit(true)} className="btn btn-outline-primary">New Party</button>
          <Sidebar onPartySelected={handlePartySelected} />
        </div>
        <div className="col-9 col-lg-10 bg-primary">
          {isPartyEdit ? <PartyEdit /> : <MainScreen partyId={selectedPartyId} />}
        </div>
      </div>

    </div>
  )
}

export default App
