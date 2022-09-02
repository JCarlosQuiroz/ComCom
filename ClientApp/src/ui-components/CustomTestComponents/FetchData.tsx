import * as React from 'react';
import { urlWeatherforecast } from '../../services/endpoints';


export interface IFetchData {
    date: string;
    temperatureC: string;
    temperatureF: string;
    summary: string;

}
export interface IFetchDataState {
    items: IFetchData[];
    loading: boolean;
}

export class FetchData extends React.Component<{}, IFetchDataState> {
    static displayName = FetchData.name;

    private _allItems: IFetchData[];

    constructor(props: {}) {
        super(props);
        this._allItems = [];
        this.state = {
            items: this._allItems,
            loading: true
        };

  }

  componentDidMount() {
    this.populateWeatherData();
  }

  static renderForecastsTable(items: IFetchData[]) {
    return (
      
      <table className='ms-table' aria-labelledby="tabelLabel">
        <thead>
          <tr>
            <th>Date</th>
            <th>Temp. (C)</th>
            <th>Temp. (F)</th>
            <th>Summary</th>
          </tr>
        </thead>
        <tbody>
                {items.map(forecast =>
            <tr key={forecast.date}>
              <td>{forecast.date}</td>
              <td>{forecast.temperatureC}</td>
              <td>{forecast.temperatureF}</td>
              <td>{forecast.summary}</td>
            </tr>
          )}
        </tbody>
      </table>
    );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : FetchData.renderForecastsTable(this.state.items);

    return (
      <div>
        <h1 id="tabelLabel" >Weather forecast</h1>
        <p>This component demonstrates fetching data from the server.</p>
        {contents}
      </div>
    );
  }

  async populateWeatherData() {
    const response = await fetch(urlWeatherforecast);
    const data = await response.json();
    this.setState({ items: data, loading: false });
  }
}
export default FetchData;