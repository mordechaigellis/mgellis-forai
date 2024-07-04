import { createBrowserRouter } from "react-router-dom";
import App from "./App";
import USGov from "./USGov";
import Login from "./Login";
import ProtectedRoute from "./ProtectedRoute";
import Olympics from "./Olympics";
import Home from "./Home";


const router = createBrowserRouter([
    {
        path: "/", element: < App />, children: [
            { index: true, element: <Home /> },
            { path: "usgov", element: <USGov /> },
            { path: "login", element: <Login frompath={location.pathname} /> },
            { path: "olympics", element: <ProtectedRoute element={<Olympics />} requiredrole={0} /> },

        ]
    }

]);

export default router;