import { useEffect, useState } from "react"
import { fetchPresidentByPartyId } from "./DataUtil";
import { IPresident } from "./DataInterfaces";

interface Props {
    partyId: number
}
export default function MainScreen({ partyId }: Props) {
    const [prezlist, setPrezList] = useState<IPresident[]>([]);

    useEffect(() => {
        const fetchdata = async () => {
            const data = await fetchPresidentByPartyId(partyId);
            setPrezList(data);
        };
        fetchdata();
    }
        , []);
    return (
        <>
            {prezlist.map(p => <div key={p.presidentId} className="col text-light">{p.num}</div>)}
        </>
    )
}