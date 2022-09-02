import {
  ISeparatorStyles,
  Pivot,
  PivotItem,
  Separator,
  Stack,
} from '@fluentui/react'
import { Theme } from '../../styles/Theme'
import CuartoFrioPepinoElMoro from './SubComponentsPepino/CuartoFrioPepinoElMoro'
import CuartoFrioPepinoEuropeoFrello from './SubComponentsPepino/CuartoFrioPepinoEuropeoFrello'
import CuartoFrioPepinoEuropeoGrecos from './SubComponentsPepino/CuartoFrioPepinoEuropeoGrecos'
import CuartoFrioPepinoEuropeoPureFlavor from './SubComponentsPepino/CuartoFrioPepinoEuropeoPureFlavor'
import CuartoFrioPepinoEuropeoSunnyFresh from './SubComponentsPepino/CuartoFrioPepinoEuropeoSunnyFresh'
import CuartoFrioPepinoEuropeoSunset from './SubComponentsPepino/CuartoFrioPepinoEuropeoSunset'
import CuartoFrioPepinoFrello from './SubComponentsPepino/CuartoFrioPepinoFrello'
import CuartoFrioPepinoGrecos from './SubComponentsPepino/CuartoFrioPepinoGrecos'

import CuartoFrioPepinoSunnyFresh from './SubComponentsPepino/CuartoFrioPepinoSunnyFresh'

const dividerStyle: Partial<ISeparatorStyles> = {
  root: {
    backgroundColor: Theme.palette.whiteTranslucent40,
  },
  content: {
    backgroundColor: Theme.palette.themeLight,
    height: '1.7px',
    width: '100%',
  },
}

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

export default function CuartoFrioPepino() {
//  const [productos, setProductos] = React.useState<ICuartoFrio>();
  return (
    <Stack
      horizontalAlign="stretch"
      horizontal
      wrap
      tokens={{ padding: '0px 0px 0px 0px', childrenGap: 60 }}
    >
      <Pivot styles={pivotStyles}>
        <PivotItem headerText="Pepino">
          <CuartoFrioPepinoGrecos
            items={[]}
            Empacado={0}
            ParrillasEmpActivas={0}
            ParrillasEmpParciales={0}
            Embarcado={0}
            NomEtiqueta={''}
            Parrillas_Chep={0}
            BultosParciales={0} NomProducto={''}          />

          <Separator styles={dividerStyle}></Separator>

          <CuartoFrioPepinoSunnyFresh
            items={[]}
            Empacado={0}
            ParrillasEmpActivas={0}
            ParrillasEmpParciales={0}
            Embarcado={0}
            NomEtiqueta={''}
            Parrillas_Chep={0}
            BultosParciales={0} NomProducto={''}          />

          <Separator styles={dividerStyle}></Separator>
          <CuartoFrioPepinoElMoro
            items={[]}
            Empacado={0}
            ParrillasEmpActivas={0}
            ParrillasEmpParciales={0}
            Embarcado={0}
            NomEtiqueta={''}
            Parrillas_Chep={0}
            BultosParciales={0} NomProducto={''}          />
          <Separator styles={dividerStyle}></Separator>
          <CuartoFrioPepinoFrello
            items={[]}
            Empacado={0}
            ParrillasEmpActivas={0}
            ParrillasEmpParciales={0}
            Embarcado={0}
            NomEtiqueta={''}
            Parrillas_Chep={0}
            BultosParciales={0} NomProducto={''}          />
          {/* <CuartoFrioPepinoPureFlavor /> */}
        </PivotItem>

        <PivotItem 
        headerText="Pepino Europeo"
        // itemCount={productos?.NomProducto ? productos.NomProducto.length : undefined}
        >
          <CuartoFrioPepinoEuropeoGrecos
            items={[]}
            Empacado={0}
            ParrillasEmpActivas={0}
            ParrillasEmpParciales={0}
            Embarcado={0}
            NomEtiqueta={''}
            Parrillas_Chep={0}
            BultosParciales={0} NomProducto={''}          />
          <Separator styles={dividerStyle}></Separator>
          <CuartoFrioPepinoEuropeoSunnyFresh
            items={[]}
            Empacado={0}
            ParrillasEmpActivas={0}
            ParrillasEmpParciales={0}
            Embarcado={0}
            NomEtiqueta={''}
            Parrillas_Chep={0}
            BultosParciales={0} NomProducto={''}          />
          <Separator styles={dividerStyle}></Separator>
          <CuartoFrioPepinoEuropeoSunset
            items={[]}
            Empacado={0}
            ParrillasEmpActivas={0}
            ParrillasEmpParciales={0}
            Embarcado={0}
            NomEtiqueta={''}
            Parrillas_Chep={0}
            BultosParciales={0} NomProducto={''}          />
          <Separator styles={dividerStyle}></Separator>
          <CuartoFrioPepinoEuropeoFrello
            items={[]}
            Empacado={0}
            ParrillasEmpActivas={0}
            ParrillasEmpParciales={0}
            Embarcado={0}
            NomEtiqueta={''}
            Parrillas_Chep={0}
            BultosParciales={0} NomProducto={''}          />
          <Separator styles={dividerStyle}></Separator>
          <CuartoFrioPepinoEuropeoPureFlavor
            items={[]}
            Empacado={0}
            ParrillasEmpActivas={0}
            ParrillasEmpParciales={0}
            Embarcado={0}
            NomEtiqueta={''}
            Parrillas_Chep={0}
            BultosParciales={0} NomProducto={''}          />
        </PivotItem>
      </Pivot>
    </Stack>
  )
}

// const totalCount = (productos: []) => {
//    const totalProductos = productos.length;
//    return totalProductos;
// }
