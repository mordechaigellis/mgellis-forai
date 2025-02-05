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
    dateBorn: Date | string;
    dateDied: Date | null | string;
    termStart: number;
    termEnd: Number | null;
    errorMessage: string;
    executiveOrderList: IExecutiveOrder[];
    presidentMedalList: IPresidentMedal[];
}

export interface IColor {
    colorId: number;
    colorName: string;
}

export interface IExecutiveOrder {
    executiveOrderId: number;
    presidentId: number;
    orderNumber: number;
    pageNum: number;
    yearIssued: number;
    orderName: string;
    reference: string;
    upheldByCourt: boolean;
    dateInserted: Date | string;
    errorMessage: string;
}

export interface IPresidentMedal {
    presidentMedalId: number;
    presidentId: number;
    medalId: number;
    medalName: string
}

export interface IMedal {
    medalId: number;
    medalName: string;
}

export interface IDashboard {
    dashboardType: string;
    dashboardText: string;
}