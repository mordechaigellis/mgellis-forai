import { IPresident } from "./PresidentTypes";

type Props = { presidents: IPresident[] }

function PresidentList(props: Props) {
    return (<>
        <table className="table">
            <thead>
                <tr>
                    <th scope="col">Num</th>
                    <th scope="col">Last Name</th>
                </tr>
            </thead>
            <tbody>
                {
                    props.presidents.map(p =>
                        <tr key={p.num}>
                            <td >{p.num}</td>
                            <td>{p.lastName}</td>
                        </tr>)
                }
            </tbody>
        </table>
    </>)
}

export default PresidentList;