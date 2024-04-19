import { useState } from 'react'
import MainScreen from './MainScreen'
import Navbar from './Navbar'
import Sidebar from './SideBar'
import './assets/css/bootstrap.min.css'
import { PartyEdit } from './PartyEdit'
import { IParty } from './DataInterfaces'
function App() {
  const [selectedPartyId, setSelectedPartyId] = useState(0);
  const [isPartyEdit, setIsPartyEdit] = useState(false);
  const initialparty: IParty = {
    partyId: 0,
    partyName: "",
    partyColor: "",
    colorId: 0,
    yearStart: 0,
    partyDesc: "",
    errorMessage: ""
  };

  const [partyforedit, setPartyforedit] = useState(initialparty);

  const handlePartySelected = (partyId: number) => {
    setIsPartyEdit(false);
    setSelectedPartyId(partyId);
  };

  const handlePartySelectedForEdit = (party: IParty) => {
    setPartyforedit(party);
    setIsPartyEdit(true);

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
          <button onClick={() => handlePartySelectedForEdit(initialparty)} className="btn btn-outline-primary">New Party</button>
          <Sidebar onPartySelected={handlePartySelected} onPartySelectedForEdit={handlePartySelectedForEdit} />
        </div>
        <div className="col-9 col-lg-10 bg-primary">
          {isPartyEdit ? <PartyEdit party={partyforedit} /> : <MainScreen partyId={selectedPartyId} />}
        </div>
      </div>

    </div>
  )
}

export default App
