import { useEffect, useState } from "react"
import { IParty } from "./DataInterfaces";
import { fetchParties } from "./DataUtil";
import PartyButton from "./PartyButton";

export default function Sidebar() {
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
    }

    return (
        <>
            <h2>{partylist.map(p =>
                <PartyButton key={p.partyId} party={p} onSelected={handleSelectedParty} isSelected={p.partyId == selectedPartyId} />)}</h2>
        </>
    )
}