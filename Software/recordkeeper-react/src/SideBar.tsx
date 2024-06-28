import { useEffect, useState } from "react"
import { IParty } from "./DataInterfaces";
import { fetchParties } from "./DataUtil";
import PartyButton from "./PartyButton";
import { getUserStore } from "@charliecpu/reactutils";
interface Props {
    onPartySelected: (partyId: number) => void;
    onPartySelectedForEdit: (party: IParty) => void;
}
export default function Sidebar({ onPartySelected, onPartySelectedForEdit }: Props) {
    const [partylist, setPartyList] = useState<IParty[]>([]);
    const [selectedPartyId, setSelectedPartyId] = useState(0);
    const apiurl = import.meta.env.VITE_API_URL;
    const useUserStore = getUserStore(apiurl);
    const isloggedin = useUserStore(state => state.isLoggedIn);

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
                    {isloggedin ?
                        <button onClick={() => onPartySelectedForEdit(p)} className="btn btn-outline-primary">Edit</button>
                        : null}
                </div>
            )}
        </>
    )
}