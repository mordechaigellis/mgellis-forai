import { FieldValues } from "react-hook-form";
import { IColor, IParty, IPresident } from "./DataInterfaces";

let baseurl = "https://recordkeeperapi2.azurewebsites.net/api/";
baseurl = "http://localhost:5086/api/";
async function fetchData<T>(url: string): Promise<T> {
    url = baseurl + url;
    const r = await fetch(url);
    const data = await r.json();
    return data;
}

async function postData<T>(url: string, form: FieldValues): Promise<T> {
    url = baseurl + url;
    const r = await fetch(url, {
        method: "POST",
        body: JSON.stringify(form),
        headers: {
            "Content-Type": "application/json"
        }
    });
    const data = await r.json();
    return data;
};

export async function fetchParties() {
    return await fetchData<IParty[]>("party");
}

export async function fetchPresidentByPartyId(partyId: number) {
    return await fetchData<IPresident[]>(`president/getbyparty/${partyId}`);
}

export async function fetchColors() {
    return await fetchData<IColor[]>("Party/colors");
}

export async function postParty(form: FieldValues) {
    return postData<IParty>("party", form);
}