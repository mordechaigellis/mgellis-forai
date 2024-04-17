import { useEffect, useState } from "react"
import { IParty } from "./DataInterfaces";
import { fetchParties } from "./DataUtil";
import PartyButton from "./PartyButton";
interface Props {
    onPartySelected: (partyId: number) => void;
    onPartySelectedForEdit: (party: IParty) => void;
}
export default function Sidebar({ onPartySelected, onPartySelectedForEdit }: Props) {
    const [partylist, setPartyList] = useState<IParty[]>([]);
    const [selectedPartyId, setSelectedPartyId] = useState(0);

    useEffect(() => {
        const fetchdata = async () => {
            const data = await fetchParties();
            setPartyList(data);
            if (data.length > 0) {
                handleSelectedParty(data[0].partyId);
            }
        }
        fetchdata();
    }
        , []);

    function handleSelectedParty(partyId: number) {
        setSelectedPartyId(partyId);
        onPartySelected(partyId);
    }

    return (
        <>

            {partylist.map(p =>
                <div key={p.partyId}>
                    <PartyButton party={p} onSelected={handleSelectedParty} isSelected={p.partyId == selectedPartyId} />
                    <button onClick={() => onPartySelectedForEdit(p)} className="btn btn-outline-primary">Edit</button>
                </div>
            )}
        </>
    )
}