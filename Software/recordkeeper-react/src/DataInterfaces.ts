export interface IParty {
    partyId: number;
    partyName: string;
    yearStart: number;
    colorId: number;
    partyDesc: string;
    partyColor: string;
    errorMessage: string;
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
    errorMessage: string
}

export interface IColor {
    colorId: number;
    colorName: string;
}