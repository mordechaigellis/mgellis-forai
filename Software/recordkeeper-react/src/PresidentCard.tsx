import { IPresident } from "./DataInterfaces"

interface Props {
    president: IPresident
}
export default function PresidentCard({ president }: Props) {
    return (
        <>
            <div className="card" style={{ width: "18rem" }}>
                <img src={`/public/images/president-images/p${president.num}p.jpeg`} className="card-img-top" alt="..." />
                <div className="card-body">
                    <h5 className="card-title">{president.num} {president.lastName}</h5>
                    <p className="card-text"></p>
                </div>
            </div>
        </>
    )
}