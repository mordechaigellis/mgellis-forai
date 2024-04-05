import { useEffect, useState } from "react"
import { fetchPresidentByPartyId } from "./DataUtil";
import { IPresident } from "./DataInterfaces";
import PresidentCard from "./PresidentCard";

interface Props {
    partyId: number
}
export default function MainScreen({ partyId }: Props) {
    const [prezlist, setPrezList] = useState<IPresident[]>([]);
    const [isLoading, setIsLoading] = useState(false);
    useEffect(() => {
        setIsLoading(true);
        const fetchdata = async () => {
            const data = await fetchPresidentByPartyId(partyId);
            setPrezList(data);
            setIsLoading(false);
        };
        fetchdata();
    }
        , [partyId]);
    return (
        <>
            <div className="row">
                <div className={isLoading ? "placeholder-glow" : ""}>
                    <h2 className="mt-2 bg-light">
                        <span className={isLoading ? "placeholder" : ""}>{prezlist.length} Presidents</span>
                    </h2>
                </div>
            </div>
            <div className="row">
                {
                    prezlist.map(p =>
                        <div className="col-3 mb-2">
                            <PresidentCard key={p.presidentId} president={p} />
                        </div>
                    )
                }
            </div>
        </>
    )
}