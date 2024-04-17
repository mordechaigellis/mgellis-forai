import { IParty, IPresident } from "./DataInterfaces";

let baseurl = "https://recordkeeperapi2.azurewebsites.net/api/";
baseurl = "http://localhost:5086/api/";
async function fetchData<T>(url: string): Promise<T> {
    url = baseurl + url;
    const r = await fetch(url);
    const data = await r.json();
    return data;
}

export async function fetchParties() {
    return await fetchData<IParty[]>("party");

}

export async function fetchPresidentByPartyId(partyId: number) {
    return await fetchData<IPresident[]>(`president/getbyparty/${partyId}`);
}