import { InteractionRequiredAuthError, InteractionStatus } from "@azure/msal-browser";
import { useMsal } from "@azure/msal-react";
import axios, { AxiosResponse } from "axios";
import { useState, useEffect } from "react";
import { loginRequest } from "../../authConfig";
import { urlWeatherforecast } from "../../models/responses/Endpoints";
import { callMsGraph } from "../../models/responses/MsGraphApiCall";
import { WeatherForecast } from "../../modules/core/domain/models/WeatherForecast";
// import { Weatherforecast } from "../../modules/core/domain/models/WeatherForecast";



export function FetchData() {
  const { instance, inProgress } = useMsal();
    const [forecastData, setForecastData] = useState<WeatherForecast[]>([]);
    const [loading, setLoading] = useState(true);
 
    useEffect(() => {
      if (!forecastData && inProgress === InteractionStatus.None) {
        callMsGraph() 
          .then((response) => setForecastData(response))
          .catch(async (e) => {
            if (e instanceof InteractionRequiredAuthError) {
             await instance.acquireTokenRedirect({
                ...loginRequest,
                account: instance.getAllAccounts()[0],
              });
            }
          });
      }
    }, [inProgress, forecastData, instance]);

    useEffect(() => {
      if (forecastData) {
        setLoading(false);
      }
    }, [forecastData]);

    // useEffect(() => {
    //   const fetchData = async () => {
    //     const result = await instance.acquireTokenSilent({
    //       ...loginRequest,
    //       account: instance.getAllAccounts()[0],
    //     });
    //     const headers = new Headers();
    //     const bearer = `Bearer ${result.accessToken}`;
    //     headers.append("Authorization", bearer);
    //     const options = {
    //       method: "GET",
    //       headers: headers,
    //     };
    //     const response = await fetch(urlWeatherforecast, options);
    //     const data = await response.json();
    //     const weatherForecast = data as WeatherForecast[];
    //     setForecastData(weatherForecast);
    //   };
    //   fetchData();
    // }, [instance]);

    useEffect(() => {
      axios.get(urlWeatherforecast).then((response: AxiosResponse<WeatherForecast[]>) => {
        setForecastData(response.data);
      });
    }, []);

    useEffect(() => {
      axios.get("https://localhost:7235/api/Clients/nas").then((resp) => {
        console.log(resp);
      });
    }, []);
    

    useEffect(() => {
      const fetchData = async () => {
        const result = await instance.acquireTokenSilent({
          ...loginRequest,
          account: instance.getAllAccounts()[0],
        });
        // console.log("result", result)
        axios.get(urlWeatherforecast, {
          headers: {
            Authorization: `Bearer ${result.accessToken}`,
            contentType: "application/json",
          },
        }).then((response: AxiosResponse<WeatherForecast[]>) => {
          setForecastData(response.data);
          });
      };
      fetchData();
    }, [instance]);
    

    return (
      <div>
        <h1 id="tabelLabel">Weather forecast</h1>
        <p>This component demonstrates fetching data from the server.</p>
        {loading ? (
          <p>
            <em>Loading...</em>
          </p>
        ) : (
          <table className="table table-striped" aria-labelledby="tabelLabel">
            <thead>
              <tr>
                <th>Date</th>
                <th>Temp. (C)</th>
                <th>Temp. (F)</th>
                <th>Summary</th>
              </tr>
            </thead>
            <tbody>
              {forecastData.map((forecast) => (
                <tr key={forecast.date}>
                  <td>{forecast.date}</td>
                  <td>{forecast.temperatureC}</td>
                  <td>{forecast.temperatureF}</td>
                  <td>{forecast.summary}</td>
                </tr>
              ))}
            </tbody>
          </table>
        )}
      </div>
    );
}

