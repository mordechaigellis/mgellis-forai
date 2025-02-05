import { useEffect, useState } from 'react'
import MainScreen from './MainScreen'
import Sidebar from './SideBar'
import { PartyEdit } from './PartyEdit'
import { IParty } from './DataInterfaces'
import { blankParty, fetchParties } from './DataUtil'
function USGov() {
  const [partylist, setPartyList] = useState<IParty[]>([]);

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
  const handlePartyDelete = (deletedpartyid: number) => {
    setPartyList(prevList => prevList.filter(p => p.partyId !== deletedpartyid));
  }
  const handlePartyEdit = (updatedparty: IParty) => {
    const partyexists = partylist.some(p => p.partyId == updatedparty.partyId);
    if (partyexists) {
      setPartyList(prevList =>
        prevList.map(p => p.partyId === updatedparty.partyId ? updatedparty : p)
          .sort((a, b) => a.partyName.localeCompare(b.partyName))
      );
    } else {
      setPartyList([...partylist, updatedparty].sort((a, b) => a.partyName.localeCompare(b.partyName)));
    }
  };

  useEffect(() => {
    const fetchdata = async () => {
      const data = await fetchParties();
      setPartyList(data);
    }
    fetchdata();
  }
    , []);

  return (
    <div className="row">
      <div className="col-3 col-lg-2 border boder-light">
        <button onClick={() => handlePartySelectedForEdit(blankParty)} className="btn btn-outline-primary">New Party</button>
        <Sidebar partylist={partylist} onPartySelected={handlePartySelected} onPartySelectedForEdit={handlePartySelectedForEdit} />
      </div>
      <div className="col-9 col-lg-10 bg-primary">
        {isPartyEdit ? <PartyEdit party={partyforedit} onPartyUpdate={handlePartyEdit} onPartyDelete={handlePartyDelete} /> : <MainScreen partyId={selectedPartyId} />}
      </div>
    </div>
  )
}

export default USGov
