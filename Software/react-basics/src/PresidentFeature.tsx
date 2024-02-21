import { IPresident } from "./PresidentTypes";

type Props = { president: IPresident }

function PresidentFeature(props: Props) {
    const prez = props.president;
    let execorderheader = props.president.executiveOrders.length == 0 ? "No Executive Orders" : "Executive Orders";
    return (<>
        <div className="card">
            <div className="card-body">
                <h5 className="card-title">{prez.lastName}</h5>
                <h6 className="card-subtitle mb-2 text-muted">{prez.party}</h6>
                <p className="card-text">{prez.firstName} {prez.lastName}</p>
                <h6>{execorderheader}</h6>
                <hr />
                <ul className="list-group">
                    {props.president.executiveOrders.map((e, index) =>
                        <li key={index} className="list-group-item">{e}</li>
                    )
                    }
                </ul>
            </div>
        </div>
    </>)
}

export default PresidentFeature;