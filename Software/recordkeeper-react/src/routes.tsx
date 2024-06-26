import { createBrowserRouter } from "react-router-dom";
import App from "./App";
import USGov from "./USGov";
//import Login from "./Login";
//import ProtectedRoute from "./ProtectedRoute";

const router = createBrowserRouter([
    {
        path: "/", element: < App />, children: [
            { index: true, element: <USGov /> },
        ]
    },
]);

export default router;