import { useUserStore } from "./user/userstore"


export default function UserPanel() {
    const isLoggedIn = useUserStore(state => state.isLoggedIn);
    const username = useUserStore(state => state.username);
    const role = useUserStore(state => state.role);
    const logout = useUserStore(state => state.logout);
    return (
        <>

        </>
    )
}
