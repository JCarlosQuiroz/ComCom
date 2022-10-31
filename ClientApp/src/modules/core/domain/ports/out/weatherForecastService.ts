import { WeatherForecastResponse } from "../../models/responses/WeatherForecastResponse";

export abstract class WeatherForecastService {
    abstract getWeatherForecast(
        date: string,
        temperatureC: number,
        temperatureF: number,
        summary: string
    ): Promise<WeatherForecastResponse>;
}