import { WeatherForecastResponse } from "../../../domain/models/responses/WeatherForecastResponse";
import { WeatherForecast } from "../../../domain/models/WeatherForecast";
import { WeatherForecastInteractor } from "../../../domain/ports/in/weatherForecast.interactor";
import { WeatherForecastService } from "../../../domain/ports/out/weatherForecastService";
import { MessageService } from "../out/MessageService";

export class WeatherForecastInteractorAdapter implements WeatherForecastInteractor{
    private title: string = "WeatherForecastInteractorAdapter";

    constructor(
        private weatherForecastService: WeatherForecastService,
        private message: MessageService,
        private location: Location
    ) { console.log(this.title); }

    async getWeatherForecast(
        date: string,
        temperatureC: number,
        temperatureF: number,
        summary: string
    ): Promise<WeatherForecast[]> {
        let weatherForecastList: WeatherForecast[];
        let weatherForecastResponse: WeatherForecastResponse;

        weatherForecastResponse = await this.weatherForecastService.getWeatherForecast(
            date,
            temperatureC,
            temperatureF,
            summary
        ).finally().catch(res => res);
        if(weatherForecastResponse.statusCode === 200){
            weatherForecastList = weatherForecastResponse.data;
        }else{
            this.message.dialog('warning', {
                title: 'Error',
                message: weatherForecastResponse.message
            });
            return Promise.reject(weatherForecastResponse.message);
        }
        return weatherForecastList;
    }
}