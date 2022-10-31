import { WeatherForecast } from "../../models/WeatherForecast";

export abstract class WeatherForecastInteractor {
    abstract getWeatherForecast(
        date: string,
        temperatureC: number,
        temperatureF: number,
        summary: string
    ): Promise<WeatherForecast[]>;
}