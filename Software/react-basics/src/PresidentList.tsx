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
                <tr>
                    {
                        props.presidents.map(p => 
                    <th scope="row">1</th>
                    <td>Mark</td>

                        )
                    }
                </tr>
            </tbody>
        </table>
    </>)
}

export default PresidentList;