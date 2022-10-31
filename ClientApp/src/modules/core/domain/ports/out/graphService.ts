import { GraphData } from "../../models/GraphData";
import { GraphDataResponse } from "../../models/responses/GraphDataResponse";

export abstract class GraphDataService {
  abstract getGraphData(
    id: string,
    givenName: string,
    surname: string,
    userPrincipalName: string,
    jobTitle: string,
    mail: string,
    officeLocation: string,
    mobilePhone: string,
    preferredLanguage: string,
    displayName: string,
    businessPhones: [],
    imageUrl: string,
    username: string,
    name: string,
    tenantId: string,
    homeAccountId: string,
    localAccountId: string,
    environment: string,
    idTokenClaims: {}
  ): Promise<GraphDataResponse>;

  abstract getGraphById(id: number): Promise<GraphDataResponse>;
  abstract saveGraphData(graphData: GraphData): Promise<GraphDataResponse>;
  abstract deleteGraphData(graphData: GraphData): Promise<GraphDataResponse>;
  abstract enableGraphData(graphData: GraphData): Promise<GraphDataResponse>;
  abstract disableGraphData(graphData: GraphData): Promise<GraphDataResponse>;
}
