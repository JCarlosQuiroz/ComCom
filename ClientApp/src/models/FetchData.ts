export class IFetchData{
    date: Date;
    temperatureC: number;
    temperatureF: number;
    summary: string;

    constructor(date: Date, temperatureC: number, temperatureF: number, summary: string) {
        this.date = date;
        this.temperatureC = temperatureC;
        this.temperatureF = temperatureF;
        this.summary = summary;
    }
}

export class IFetchDataState{
    loading: boolean;
    items: IFetchData[];
    error: string;

    constructor(loading: boolean, items: IFetchData[], error: string) {
        this.loading = loading;
        this.items = items;
        this.error = error;
    }
}