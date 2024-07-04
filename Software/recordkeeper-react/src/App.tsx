import { Outlet } from "react-router-dom";
import Navbar from "./Navbar";
import './assets/css/bootstrap.min.css'
import 'bootstrap/dist/js/bootstrap.bundle.min.js';
export default function App() {
    return (
        <div className='container'>
            <div className="row">
                <div className="col-12 px-0">
                    <Navbar />
                </div>
            </div>
            <div className="row">
                <Outlet />
            </div>

        </div>
    )
}
