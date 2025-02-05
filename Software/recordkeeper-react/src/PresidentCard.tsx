import { getUserStore } from "@charliecpu/reactutils";
import { IPresident } from "./DataInterfaces"
import './PresidentCard.css';
interface Props {
    president: IPresident,
    onPresidentEdit: (presidentid: number) => void;
}
export default function PresidentCard({ president, onPresidentEdit }: Props) {
    const imgpath = "/images/president-images/";
    const apiurl = import.meta.env.VITE_API_URL;
    const useUserStore = getUserStore(apiurl);
    const isloggedin = useUserStore(state => state.isLoggedIn);

    return (
        <>
            <div className="card" >
                <img src={`${imgpath}p${president.num}p.jpeg`} className="card-img-top" alt="..."
                    onError={(event) => (event.currentTarget.src = `${imgpath}default.jpeg`)} />
                <div className="card-body">
                    <h5 className="card-title">{president.num} {president.firstName} {president.lastName}</h5>
                    <ul className="card-text">
                        <li>{`${president.dateDied ? "Life" : "Born"}: ${president.dateBorn} - ${president.dateDied}`}</li>
                        <li>{`Term: ${president.termStart} - ${president.termEnd}`}</li>
                    </ul>                </div>
                <div className="card-footer">
                    {isloggedin ?
                        <button className="btn btn-primary" onClick={() => onPresidentEdit(president.presidentId)} >Edit</button>
                        : null}
                </div>
            </div>
        </>
    )
}