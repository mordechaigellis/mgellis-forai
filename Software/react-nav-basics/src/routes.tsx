import { createBrowserRouter } from "react-router-dom";
import Screen1 from "./Screen1";
import Screen2 from "./Screen2";
import Screen3 from "./Screen3";

const router = createBrowserRouter([
    { path: "/", element: < Screen1 /> },
    { path: "/screen1", element: < Screen1 /> },
    { path: "/screen2", element: < Screen2 /> },
    { path: "/screen3/:val?", element: < Screen3 /> },
]);

export default router;