import { useState } from 'react'
import MainScreen from './MainScreen'
import Navbar from './Navbar'
import Sidebar from './SideBar'
import { PartyEdit } from './PartyEdit'
import { IParty } from './DataInterfaces'
import { blankParty } from './DataUtil'
function USGov() {
  const [selectedPartyId, setSelectedPartyId] = useState(0);
  const [isPartyEdit, setIsPartyEdit] = useState(false);

  const [partyforedit, setPartyforedit] = useState(blankParty);

  const handlePartySelected = (partyId: number) => {
    setIsPartyEdit(false);
    setSelectedPartyId(partyId);
  };

  const handlePartySelectedForEdit = (party: IParty) => {
    setPartyforedit(party);
    setIsPartyEdit(true);

  };

  return (
    <div className="row">
      <div className="col-3 col-lg-2 border boder-light">
        <button onClick={() => handlePartySelectedForEdit(blankParty)} className="btn btn-outline-primary">New Party</button>
        <Sidebar onPartySelected={handlePartySelected} onPartySelectedForEdit={handlePartySelectedForEdit} />
      </div>
      <div className="col-9 col-lg-10 bg-primary">
        {isPartyEdit ? <PartyEdit party={partyforedit} /> : <MainScreen partyId={selectedPartyId} />}
      </div>
    </div>
  )
}

export default USGov
