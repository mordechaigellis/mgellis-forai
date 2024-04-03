import { useState } from "react"
import { IParty } from "./DataInterfaces"

interface Props {
    party: IParty
}
export default function PartyButton({ party }: Props) {
    const [selected, setSelected] = useState(false);

    return (
        <div onClick={ } className = {`btn ${selected ? "bg-secondary" : ""}`}>
            <figure className="figure">
                <img src={`/public/images/party-images/${party.partyName}.jpg`} className="figure-img img-fluid rounded" alt="..." />
                <figcaption className="figure-caption text-center">{party.partyName}</figcaption>
            </figure>
        </div >
    )
}