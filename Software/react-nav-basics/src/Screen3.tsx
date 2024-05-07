import { useParams } from "react-router-dom"


export default function Screen3() {
    const { val, num } = useParams();
    
    return (
        <>
            <div>Screen3 dynamic path val = {val}</div>
        </>
    )
}
