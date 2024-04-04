export interface IParty {
    partyId: number;
    partyName: string;
    yearStart: number;
    colorId: number;
    partyDesc: string;
    partyColor: string;
}

export interface IPresident {
    presidentId: number;
    partyId: number;
    num: number;
    firstName: string;
    lastName: string;
    dateBorn: string;
    dateDied: string;
    termStart: number;
    termEnd: string | null;
}