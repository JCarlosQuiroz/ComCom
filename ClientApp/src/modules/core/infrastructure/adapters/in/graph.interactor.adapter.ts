// import { GraphDataInteractor } from "modules/core/domain/ports/in/graph.interactor";
// import { GraphDataService } from "modules/core/domain/ports/out/graphService";
import { Location } from "microsoft-graph";
import { GraphData } from "../../../domain/models/GraphData";
import { GraphDataResponse } from "../../../domain/models/responses/GraphDataResponse";
import { GraphDataInteractor } from "../../../domain/ports/in/graph.interactor";
import { GraphDataService } from "../../../domain/ports/out/graphService";
// import { GraphData } from "modules/core/domain/models/GraphData";
// import { GraphDataResponse } from "modules/core/domain/models/responses/GraphDataResponse";
import { MessageService } from "../out/MessageService";
export class GraphDataInteractorAdapter implements GraphDataInteractor{
  private title: string = "GraphDataInteractorAdapter";
  constructor(
    private graphDataService: GraphDataService,
    private message: MessageService,
    private location: Location
  ) { console.log(this.title); }
  async getGraphData(
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
  ): Promise<GraphData[]> {

    let GraphDataList: GraphData[];
    let GraphDataResponse: GraphDataResponse;

      GraphDataResponse = await this.graphDataService.getGraphData(
        id,
        givenName,
        surname,
        userPrincipalName,
        jobTitle,
        mail,
        officeLocation,
        mobilePhone,
        preferredLanguage,
        displayName,
        businessPhones,
        imageUrl,
        username,
        name,
        tenantId,
        homeAccountId,
        localAccountId,
        environment,
        idTokenClaims
      ).finally().catch((res: any) => res);
      if(GraphDataResponse.statusCode === 200){
        GraphDataList = GraphDataResponse.data;
      } else {
        this.message.dialog('warning', {
          title: this.title,
          message: GraphDataResponse.message
        });
        return Promise.reject(GraphDataResponse.message);
      }
      return GraphDataList;
    }

    async getGraphById(id: number): Promise<GraphData> {
      let graphData: GraphData;
      let graphDataResponse: GraphDataResponse;
  
      graphDataResponse = await this.graphDataService
        .getGraphById(id)
        .finally()
        .catch((res: any) => res);
      if (graphDataResponse.statusCode === 200) {
        graphData = graphDataResponse.data[0];
      } else {
        this.message.dialog('warning', {
          title: this.title,
          message: graphDataResponse.message,
        });
        return Promise.reject(graphDataResponse.message);
      }
      return graphData;
    }
    saveGraphData(graphData: GraphData): Promise<GraphData> {
      throw new Error("Method not implemented.");
    }
    deleteGraphData(graphData: GraphData): Promise<GraphData> {
      throw new Error("Method not implemented.");
    }
    enableGraphData(graphData: GraphData): Promise<GraphData> {
      throw new Error("Method not implemented.");
    }
    disableGraphData(graphData: GraphData): Promise<GraphData> {
      throw new Error("Method not implemented.");
    }      
}
