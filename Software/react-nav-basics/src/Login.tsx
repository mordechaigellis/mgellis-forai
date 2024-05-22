import { useForm } from "react-hook-form"
import { useUserStore } from "./user/userstore";

type forminput = { username: string, password: string }

export default function Login() {
    const { register, handleSubmit, formState: { errors } } = useForm<forminput>();
    const login = useUserStore((state) => state.login)
    const onSubmit = async (data: forminput) => await login(data.username, data.password);

    return (
        <>
            <form onSubmit={handleSubmit(onSubmit)}>
                
            </form>
        </>
    )
}
