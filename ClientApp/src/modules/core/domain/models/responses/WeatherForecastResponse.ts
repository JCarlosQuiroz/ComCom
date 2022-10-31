import { ApiResponse } from "../../../../../utils/ApiResponse";

import { WeatherForecast } from "../WeatherForecast";

export interface WeatherForecastResponse extends ApiResponse {
    data: WeatherForecast[];
}