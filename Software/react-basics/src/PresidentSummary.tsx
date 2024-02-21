import { IPresident } from "./PresidentTypes";
type Props = { presidents: IPresident[] }

function PresidentSummary(props: Props) {
    return (<>
        <h2>{props.presidents.length} Presidents</h2>
    </>)
}

export default PresidentSummary;