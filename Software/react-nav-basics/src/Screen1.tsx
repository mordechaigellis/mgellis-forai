import { useNavigate } from "react-router-dom";
import Navbar from "./Navbar";


export default function Screen1() {
    const navigate = useNavigate();
    return (
        <>
            <Navbar />
            <hr />
            <div>Screen1</div>
            <button onClick={() => navigate("/screen2")}>Nav to Screen 2</button>
        </>
    )
}
