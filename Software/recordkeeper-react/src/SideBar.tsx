import { useEffect, useState } from "react"
import { IParty } from "./DataInterfaces";
import PartyButton from "./PartyButton";
import { getUserStore } from "@charliecpu/reactutils";
interface Props {
    onPartySelected: (partyId: number) => void;
    onPartySelectedForEdit: (party: IParty) => void;
    partylist: IParty[]
}
export default function Sidebar({ partylist, onPartySelected, onPartySelectedForEdit }: Props) {
    const [selectedPartyId, setSelectedPartyId] = useState(0);
    const apiurl = import.meta.env.VITE_API_URL;
    const useUserStore = getUserStore(apiurl);
    const isloggedin = useUserStore(state => state.isLoggedIn);

    useEffect(() => {
        if (partylist.length > 0) {
            handleSelectedParty(partylist[0].partyId);
        }
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