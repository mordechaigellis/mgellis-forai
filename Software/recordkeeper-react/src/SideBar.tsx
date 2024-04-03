import { useEffect, useState } from "react"
import { IParty } from "./DataInterfaces";
import { fetchParties } from "./DataUtil";
import PartyButton from "./PartyButton";

export default function Sidebar() {
    const [partylist, setPartyList] = useState<IParty[]>([]);
    useEffect(() => {
        const fetchdata = async () => {
            const data = await fetchParties();
            setPartyList(data);
        }
        fetchdata();
    }
        , []);
    return (
        <>
            <h2>{partylist.map(p => <PartyButton party={p} />)}</h2>
        </>
    )
}