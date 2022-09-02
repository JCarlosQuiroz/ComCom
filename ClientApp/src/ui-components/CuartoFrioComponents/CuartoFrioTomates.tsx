import {
  Pivot,
  PivotItem,
  Stack,
} from '@fluentui/react'
/*import { Theme } from 'constants/Theme'*/
import * as React from 'react'
//import CuartoFrioChileBellGrecos from './SubComponentsChileBell/CuartoFrioChileBellGrecos'
//import CuartoFrioChileBellPureFlavor from './SubComponentsChileBell/CuartoFrioChileBellPureFlavor'
//import CuartoFrioChileBellSunnyFresh from './SubComponentsChileBell/CuartoFrioChileBellSunnyFresh'
//import CuartoFrioChileBellSunset from './SubComponentsChileBell/CuartoFrioChileBellSunset'
//import CuartoFrioTomateElMoro from './SubComponentsTomate/CuartoFrioTomateElMoro'
//import CuartoFrioTomateFrello from './SubComponentsTomate/CuartoFrioTomateFrello'
//import CuartoFrioTomateGenerica from './SubComponentsTomate/CuartoFrioTomateGenerica'
//import CuartoFrioTomateGladiador from './SubComponentsTomate/CuartoFrioTomateGladiador'
//import CuartoFrioTomateGrecos from './SubComponentsTomate/CuartoFrioTomateGrecos'
//import CuartoFrioTomatePureFlavor from './SubComponentsTomate/CuartoFrioTomatePureFlavor'
//import CuartoFrioTomateSunnyFresh from './SubComponentsTomate/CuartoFrioTomateSunnyFresh'
//import CuartoFrioTomateTripleH from './SubComponentsTomate/CuartoFrioTomateTripleH'

// export class CuartoFrioTomates extends React.Component<{}, {}> {
//   // async componentDidMount() {
//   //   const response = await axios.get(urlRprtPalletsDets)
//   //   this.setState({ items: response.data })
//   //   console.log(response.data)
//   // }

//   // private _columns: IColumn[]

//   // constructor(props: {}) {
//   //   super(props)
//   //   this.state = {
//   //     items: [],
//   //   }

//   //   this._columns = [
//   //     {
//   //       key: 'column1',
//   //       name: 'Tamaño',
//   //       fieldName: 'NomTamano',
//   //       minWidth: 100,
//   //       maxWidth: 200,
//   //       isResizable: true,
//   //     },
//   //     {
//   //       key: 'column2',
//   //       name: 'Bultos',
//   //       fieldName: 'Empacado',
//   //       minWidth: 40,
//   //       maxWidth: 200,
//   //       isResizable: true,
//   //     },
//   //     {
//   //       key: 'column3',
//   //       name: 'Parrilla',
//   //       fieldName: 'ParrillasEmpActivas1',
//   //       minWidth: 40,
//   //       maxWidth: 200,
//   //       isResizable: true,
//   //     },
//   //     {
//   //       key: 'column4',
//   //       name: 'Parrillas Chep',
//   //       fieldName: 'ParrillasEmpActivas',
//   //       minWidth: 40,
//   //       maxWidth: 200,
//   //       isResizable: true,
//   //     },
//   //     {
//   //       key: 'column5',
//   //       name: 'Parrillas Embarcadas',
//   //       fieldName: 'ParrillasEmbarcado',
//   //       minWidth: 40,
//   //       maxWidth: 200,
//   //       isResizable: true,
//   //     },
//   //     {
//   //       key: 'column6',
//   //       name: 'Bachas',
//   //       fieldName: 'Tipo',
//   //       minWidth: 40,
//   //       maxWidth: 200,
//   //       isResizable: true,
//   //     },
//   //     {
//   //       key: 'column7',
//   //       name: 'Bultos/Bachas',
//   //       fieldName: 'Empacado',
//   //       minWidth: 40,
//   //       maxWidth: 200,
//   //       isResizable: true,
//   //     },
//   //   ]
//   // }

//   public render(): JSX.Element {
//     return (
//       <Stack>
//         <CuartoFrioTomateGrecos />
//         <Separator theme={Theme} ></Separator>
//         <CuartoFrioTomateFrello />
//         <Separator theme={Theme} ></Separator>
//         <CuartoFrioTomateGenerica />
//         <Separator theme={Theme} ></Separator>
//         <CuartoFrioTomateGladiador />
//         <Separator theme={Theme} ></Separator>
//         <CuartoFrioTomateElMoro />
//         <Separator theme={Theme} ></Separator>
//         <CuartoFrioTomateGladiador />
//         <Separator theme={Theme} ></Separator>
//         <CuartoFrioTomateSunnyFresh />
//         <Separator theme={Theme} ></Separator>

//         <CuartoFrioTomateTripleH />
//         <Separator theme={Theme} ></Separator>

//         <CuartoFrioTomatePureFlavor />

//         {/*<Separator theme={Theme} styles={ISepStyles}></Separator>*/}
//         {/*      <CuartoFrioPepinoGladiador/>*/}
//         {/*      <Separator theme={Theme} styles={ISepStyles}></Separator>*/}
//         {/*      <CuartoFrioPepinoInterlock />*/}
//         {/*      <Separator theme={Theme} styles={ISepStyles}></Separator>*/}
//         {/*      <CuartoFrioPepinoJJ />*/}
//         {/*      <Separator theme={Theme} styles={ISepStyles}></Separator>*/}
//         {/*      <CuartoFrioPepinoKingdomFresh />*/}
//         {/*      <Separator theme={Theme} styles={ISepStyles}></Separator>*/}
//         {/*      <CuartoFrioPepinoMucci />*/}
//         {/*<Separator theme={Theme} styles={ISepStyles}></Separator>*/}
//         {/*<CuartoFrioPepinoRedWagonFarms />*/}
//         {/*<Separator theme={Theme} styles={ISepStyles}></Separator>*/}
//         {/*<CuartoFrioPepinoSafeway />*/}
//         {/*<Separator theme={Theme} styles={ISepStyles}></Separator>*/}
//         {/*<CuartoFrioPepinoTripleH />*/}
//         {/*<Separator theme={Theme} styles={ISepStyles}></Separator>*/}
//         {/*<CuartoFrioPepinoTriStar />*/}
//         {/*<Separator theme={Theme} styles={ISepStyles}></Separator>*/}
//         {/*<CuartoFrioPepinoUnitedGreenHo />*/}
//         {/*<Separator theme={Theme} styles={ISepStyles}></Separator>*/}
//         {/*<CuartoFrioPepinoVikingo />*/}
//         {/*<Separator theme={Theme} styles={ISepStyles}></Separator>*/}
//         {/*<CuartoFrioPepinoWilson />*/}
//       </Stack>
//     )
//   }
// }
// export default CuartoFrioTomates

//const dividerStyle: Partial<ISeparatorStyles> = {
//  root: {
//    backgroundColor: Theme.palette.whiteTranslucent40,
//  },
//  content: {
//    backgroundColor: Theme.palette.themeLight,
//    height: '1.7px',
//    width: '100%',
//  },
//}

const pivotStyles = {
  root: {
    display: 'flex',
    alignItems: 'center',
    alighContent: 'center',
    justifyContent: 'center',
    // marginTop: '100px',
    // marginLeft: '100px',
    // marginRight: '100px',
    backgroundRepeat: 'no-repeat',
    backgroundPosition: 'center',
    backgroundSize: 'cover',
    cursor: 'pointer',
    transition: 'all 0.5s',
  },
}

export default function CuartoFrioTomates() {
  const [overflow] = React.useState(true)
  return (
    <Stack
      horizontalAlign="stretch"
      horizontal
      wrap
      tokens={{ padding: '20px 0px 0px 0px', childrenGap: 30 }}
    >
      <Pivot
        styles={pivotStyles}
        overflowBehavior={overflow ? 'menu' : 'none'}
        overflowAriaLabel="more items"
      >
        <PivotItem headerText="Roma Tomato Of "></PivotItem>

        <PivotItem headerText="Tom Bola GH">
          {/* <CuartoFrioChileBellSunnyFresh/> */}
        </PivotItem>
        <PivotItem headerText="Tom On the Vine GH">
          {/* <CuartoFrioChileBellSunset/> */}
        </PivotItem>
        <PivotItem headerText="Campari">
          {/* <CuartoFrioChileBellSunset/> */}
        </PivotItem>
        <PivotItem headerText="Tomate Roma Mallas">
          {/* <CuartoFrioChileBellSunset/> */}
        </PivotItem>
        <PivotItem headerText="Tomate Zima">
          {/* <CuartoFrioChileBellSunset/> */}
        </PivotItem>
        <PivotItem headerText="Tomate Champagne">
          {/* <CuartoFrioChileBellSunset/> */}
        </PivotItem>
        <PivotItem headerText="Tomate Splendido"></PivotItem>

        <PivotItem headerText="Tom Grape Of">
          {/* <CuartoFrioChileBellSunnyFresh/> */}
        </PivotItem>
        <PivotItem headerText="Tom Special Pack GH">
          {/* <CuartoFrioChileBellSunset/> */}
        </PivotItem>
        <PivotItem headerText="Roma Tomato GH">
          {/* <CuartoFrioChileBellSunset/> */}
        </PivotItem>
        <PivotItem headerText="Tom Bola GHO">
          {/* <CuartoFrioChileBellSunset/> */}
        </PivotItem>
        <PivotItem headerText="Roma Tomato Of-G">
          {/* <CuartoFrioChileBellSunset/> */}
        </PivotItem>
        <PivotItem headerText="Tom Bola GH-G">
          {/* <CuartoFrioChileBellSunset/> */}
        </PivotItem>
        <PivotItem headerText="Tomate Tov Special Pack"></PivotItem>
        <PivotItem headerText="Tom Grape Gh">
          {/* <CuartoFrioChileBellSunnyFresh/> */}
        </PivotItem>
      </Pivot>
    </Stack>
  )
}
