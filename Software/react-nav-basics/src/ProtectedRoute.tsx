import Login from "./Login";
import { useUserStore } from "@charliecpu/reactutils"

interface Props { element: React.ReactNode, requiredrole: string }

export default function ProtectedRoute({ element, requiredrole }: Props) {
    const isLoggedIn = useUserStore((state) => state.isLoggedIn);
    const role = useUserStore((state) => state.role);
    const hasprivilege = requiredrole == "" || requiredrole == role;

    if (!isLoggedIn) {
        return <Login />;
    }
    else if (!hasprivilege) {
        return <><div>You are not authorized to view this page.</div></>
    }
    else {
        return <>{element}</>;
    }
}
