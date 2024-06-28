import { FieldValues } from "react-hook-form";
import { IColor, IParty, IPresident } from "./DataInterfaces";
import { createAPI, getUserStore } from "@charliecpu/reactutils";

let baseurl = import.meta.env.VITE_API_URL;

function api() {
    const sessionkey = getUserStore(baseurl).getState().sessionKey;
    return createAPI(baseurl, sessionkey);
}

export async function fetchParties() {
    return await api().fetchData<IParty[]>("party");
}

export async function fetchPresidentByPartyId(partyId: number) {
    return await api().fetchData<IPresident[]>(`president/getbyparty/${partyId}`);
}

export async function fetchColors() {
    return await api().fetchData<IColor[]>("Party/colors");
}

export async function postParty(form: FieldValues) {
    return api().postData<IParty>("party", form);
}

export async function deleteParty(partyId: number) {
    return api().deleteData<IParty>(`party?id=${partyId}`);

}

export const blankParty: IParty = {
    partyId: 0,
    partyName: "",
    partyColor: "",
    colorId: 0,
    yearStart: 0,
    partyDesc: "",
    errorMessage: ""
};