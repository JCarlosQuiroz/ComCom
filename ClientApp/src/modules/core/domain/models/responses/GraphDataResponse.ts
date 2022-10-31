import { ApiResponse } from "../../../../../utils/ApiResponse";
import { GraphData } from "../GraphData";


export interface GraphDataResponse extends ApiResponse {
    data: GraphData[];
}