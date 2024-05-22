import Login from "./Login";
import { useUserStore } from "./user/userstore"

interface Props { element: React.ReactNode }

export default function ProtectedRoute({ element }: Props) {
    const isLoggedIn = useUserStore((state) => state.isLoggedIn);

    return (
        <>
            {isLoggedIn ?
                <>{element}</>
                :
                <Login />
            }
        </>
    )
}
