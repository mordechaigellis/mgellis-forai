import { useNavigate } from "react-router-dom";



export default function Screen1() {
    const navigate = useNavigate();
    return (
        <>
            <h1>Screen1</h1>
            <button onClick={() => navigate("/screen2")}>Nav to Screen 2</button>
        </>
    )
}
