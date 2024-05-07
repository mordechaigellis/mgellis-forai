import { useParams } from "react-router-dom"
import NumStars from "./NumStars";
import NumCount from "./NumCount";


export default function Screen3() {
    const { val, num } = useParams();
    const numvalue = Number(num) || 0;

    return (
        <>
            <div>Screen3 dynamic path val = {val} num = {num}</div>
            <hr />
            <NumStars num={numvalue} />
            <hr />
            <NumCount num={numvalue} />
        </>
    )
}
