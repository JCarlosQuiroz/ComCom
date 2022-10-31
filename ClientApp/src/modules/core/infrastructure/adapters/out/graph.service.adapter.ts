import { msalInstance } from "../../../../..";
import { graphConfig, loginRequest } from "../../../../../authConfig";
import { GraphData } from "../../../domain/models/GraphData";
import { GraphDataResponse } from "../../../domain/models/responses/GraphDataResponse";
import { GraphDataService } from "../../../domain/ports/out/graphService";

export class GraphDataServiceAdapter implements GraphDataService{
  url: string = graphConfig.graphMeEndpoint;
  id: string = "";
  private title: string = "GraphDataServiceAdapter";

  constructor(
    private callMsGraph = async (url: string, accessToken: string): Promise<any> => {
      const headers = new Headers();
      const bearer = `Bearer ${accessToken}`;
      headers.append("Authorization", bearer);
      const options = {
        method: "GET",
        headers: headers,
      };
      return fetch(url, options)
        .then((response) => response.json())
        .catch((error) => console.log(error));
    }
  ) { console.log(this.title); }

  
async getGraphData(): Promise<GraphDataResponse>{
  let GraphDataList: GraphDataResponse;
  GraphDataList = await this.callMsGraph(this.url, this.id);
  return GraphDataList;
}

async getGraphById(id: number): Promise<GraphDataResponse> {    
    let GraphDataList: GraphDataResponse;
    GraphDataList = await this.callMsGraph(this.url, this.id);
    return GraphDataList;
}



  async getGraphPhoto(): Promise<any> {
    const account = await msalInstance.getActiveAccount();
    if (!account) {
      throw Error("No active account! Verify a user has been signed in and setActiveAccount has been called.");
    }
    const response = await msalInstance.acquireTokenSilent({
      ...loginRequest,
      account: account,
    });
    const headers = new Headers();
    const bearer = `Bearer ${response.accessToken}`;
    headers.append("Authorization", bearer);
    const options = {
      method: "GET",
      headers: headers,
    };
    return fetch(graphConfig.graphMeEndpoint, options)
      .then((response) => response.blob())
      .catch((error) => console.log(error));
  }

  saveGraphData(graphData: GraphData): Promise<GraphDataResponse> {
    throw new Error("Method not implemented.");
  }
  deleteGraphData(graphData: GraphData): Promise<GraphDataResponse> {
    throw new Error("Method not implemented.");
  }
  enableGraphData(graphData: GraphData): Promise<GraphDataResponse> {
    throw new Error("Method not implemented.");
  }
  disableGraphData(graphData: GraphData): Promise<GraphDataResponse> {
    throw new Error("Method not implemented.");
  }
}

  