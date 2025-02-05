
import { IParty } from "./DataInterfaces"

interface Props {
    party: IParty,
    isSelected: boolean
    onSelected: (partyId: number) => void
}
export default function PartyButton({ party, isSelected, onSelected }: Props) {
    const imgpath = "/images/party-images/";
    return (
        <div onClick={() => onSelected(party.partyId)} className={`btn ${isSelected ? "bg-secondary" : ""}`}>
            <figure className="figure">
                <img src={`${imgpath}${party.partyName.toLowerCase()}.jpg`} className="figure-img img-fluid rounded" alt="..."
                    onError={(event) => (event.currentTarget.src = `${imgpath}default.jpg`)}
                />
                <figcaption className="figure-caption text-center">{party.partyName}</figcaption>
            </figure>
        </div >
    )
}