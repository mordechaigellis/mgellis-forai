import { create } from "zustand";

interface User {
    username: string,
    role: string,
    isLoggedIn: boolean,
    login: (username: string, password: string) => Promise<void>,
    logout: () => void,
}

export const useUserStore = create<User>(
    (set) => ({
        username: "", role: "", isLoggedIn: false,
        logout: () => { set({ username: "", role: "", isLoggedIn: false }) },
        login: async (username: string, password: string) => {
            const roleval = username.toLowerCase().startsWith("a") ? "admin" : "user";
            set({ username: username, role: roleval, isLoggedIn: true })
        }
    })
);