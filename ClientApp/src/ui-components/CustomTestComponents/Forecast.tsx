import { DetailsList, IColumn, Spinner, Stack,Text } from '@fluentui/react';
import axios from 'axios';
import * as React from 'react';
import { IFetchData } from '../../models/FetchData';
import { urlWeatherforecast } from '../../models/responses/Endpoints';




export default function Forecast(){
  const [weatherForecasts, setWeatherForecasts] = React.useState<IFetchData[]>([]);
  React.useEffect(() => {
    axios.get(urlWeatherforecast).then((response) => {
      setWeatherForecasts(response.data)
      console.log(response.data)
    })
  }, [])

  const columns: IColumn[] = [
    {
      key: 'column1',
      name: 'Date',
      fieldName: 'Date',
      minWidth: 200,
      maxWidth: 300,
      isRowHeader: true,
      isResizable: true,
      isSorted: false,
      isSortedDescending: false,
      sortAscendingAriaLabel: 'Sorted A to Z',
      sortDescendingAriaLabel: 'Sorted Z to A',
      data: 'date',
      isPadded: true,
    },
    {
      key: 'column2',
      name: 'TemperatureC',
      fieldName: 'TemperatureC',
      minWidth: 100,
      maxWidth: 200,
      isRowHeader: true,
      isResizable: true,
      isSorted: false,
      isSortedDescending: false,
      sortAscendingAriaLabel: 'Sorted A to Z',
      sortDescendingAriaLabel: 'Sorted Z to A',
      data: 'number',
      isPadded: true,
    },
    {
      key: 'column3',
      name: 'TemperatureF',
      fieldName: 'TemperatureF',
      minWidth: 100,
      maxWidth: 200,
      isRowHeader: true,
      isResizable: true,
      isSorted: false,
      isSortedDescending: false,
      sortAscendingAriaLabel: 'Sorted A to Z',
      sortDescendingAriaLabel: 'Sorted Z to A',
      data: 'number',
      isPadded: true,
    },
    {
      key: 'column4',
      name: 'Summary',
      fieldName: 'Summary',
      minWidth: 100,
      maxWidth: 200,
      isRowHeader: true,
      isResizable: true,
      isSorted: false,
      isSortedDescending: false,
      sortAscendingAriaLabel: 'Sorted A to Z',
      sortDescendingAriaLabel: 'Sorted Z to A',
      data: 'string',
      isPadded: true,
    },
  ];
  return(
    <Stack>

      <Stack styles={{ root: {width: '100%'}}} horizontalAlign='center' wrap={false} tokens={{childrenGap:10}} >
        <h2>Pronóstico del tiempo</h2>

        {weatherForecasts.length > 0 ? (
          <DetailsList
          items={weatherForecasts}
          columns={columns}
          selectionMode={2}
          setKey='set'
          layoutMode={1}
          isHeaderVisible={true}
          usePageCache={true}
          checkboxVisibility={2}
          useReducedRowRenderer={true}
          enableUpdateAnimations={true}
          />
        ) : (
          <Stack>
            <Spinner size={3} />
          <Text variant='xLarge' styles={{ root: { width: '100%' } }}>
            {weatherForecasts.length > 0 ? weatherForecasts[0].date : 'Cargando...'}
          </Text>
          </Stack>
        )}
      </Stack>
      
      
      </Stack>

  );
}


// export interface IFetchData {
//     date: string;
//     temperatureC: string;
//     temperatureF: string;
//     summary: string;

// }
// export interface IFetchDataState {
//     items: IFetchData[];
//     loading: boolean;
// }

// export class FetchData extends React.Component<{}, IFetchDataState> {
//     static displayName = FetchData.name;

//     private _allItems: IFetchData[];

//     constructor(props: {}) {
//         super(props);
//         this._allItems = [];
//         this.state = {
//             items: this._allItems,
//             loading: true
//         };

//   }

//   componentDidMount() {
//     this.populateWeatherData();
//   }

//   static renderForecastsTable(items: IFetchData[]) {
//     return (
      
//       <table className='ms-table' aria-labelledby="tabelLabel">
//         <thead>
//           <tr>
//             <th>Date</th>
//             <th>Temp. (C)</th>
//             <th>Temp. (F)</th>
//             <th>Summary</th>
//           </tr>
//         </thead>
//         <tbody>
//                 {items.map(forecast =>
//             <tr key={forecast.date}>
//               <td>{forecast.date}</td>
//               <td>{forecast.temperatureC}</td>
//               <td>{forecast.temperatureF}</td>
//               <td>{forecast.summary}</td>
//             </tr>
//           )}
//         </tbody>
//       </table>
//     );
//   }

//   render() {
//     let contents = this.state.loading
//       ? <p><em>Loading...</em></p>
//       : FetchData.renderForecastsTable(this.state.items);

//     return (
//       <div>
//         <h1 id="tabelLabel" >Weather forecast</h1>
//         <p>This component demonstrates fetching data from the server.</p>
//         {contents}
//       </div>
//     );
//   }

//   async populateWeatherData() {
//     const response = await fetch(urlWeatherforecast);
//     const data = await response.json();
//     this.setState({ items: data, loading: false });
//   }
// }
// export default FetchData;