import { GraphData } from "../../models/GraphData";

export abstract class GraphDataInteractor {
    abstract getGraphData(
        id : string,
        givenName : string,
        surname: string,
        userPrincipalName: string,
        jobTitle: string,
        mail: string,
        officeLocation: string,
        mobilePhone: string,
        preferredLanguage: string,
        displayName: string,
        businessPhones:[],
        imageUrl: string,
        username: string,
        name: string,
        tenantId: string,
        homeAccountId: string,
        localAccountId: string,
        environment: string,
        idTokenClaims: {},
    ): Promise<GraphData[]>;

abstract getGraphById(id: number): Promise<GraphData>;
abstract saveGraphData(graphData: GraphData): Promise<GraphData>;
abstract deleteGraphData(graphData: GraphData): Promise<GraphData>;
abstract enableGraphData(graphData: GraphData): Promise<GraphData>;
abstract disableGraphData(graphData: GraphData): Promise<GraphData>;
}