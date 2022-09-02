import {
  DetailsList,
  IColumn,
  Stack,
} from '@fluentui/react'
import axios from 'axios'

import * as React from 'react'

import { ICuartoFrioState } from '../../../models/Productos';
import { urlGetChileBellGrecos } from '../../../services/endpoints';


export default function CuartoFrioChileBellGrecos(_props: ICuartoFrioState) {
  const [productos, setProductos] = React.useState<ICuartoFrioState[]>([])
  // const [total, setTotal] = React.useState(0)
  // const [loading, setLoading] = React.useState(false)
  React.useEffect(() => {
    axios.get(urlGetChileBellGrecos).then((response) => {
      setProductos(response.data)
      console.log(response.data)
    })
  }, [])

  const columns: IColumn[] = [
    {
      key: 'column1',
      name: 'Tamaño',
      fieldName: 'NomTamano',
      minWidth: 50,
      maxWidth: 100,
      isRowHeader: true,
      isResizable: true,
      isSorted: false,
      isSortedDescending: false,
      sortAscendingAriaLabel: 'Sorted A to Z',
      sortDescendingAriaLabel: 'Sorted Z to A',
      data: 'string',
      isPadded: true,
    },
    {
      key: 'column2',
      name: 'Bultos',
      fieldName: 'Empacado',
      minWidth: 50,
      maxWidth: 100,
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
      name: 'Parrillas',
      fieldName: 'ParrillasEmpActivas',
      minWidth: 50,
      maxWidth: 100,
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
      name: 'Parrillas CHEP',
      fieldName: 'Parrillas_Chep',
      minWidth: 70,
      maxWidth: 140,
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
      key: 'column5',
      name: 'Parrillas Embarcadas',
      fieldName: 'Embarcado',
      minWidth: 110,
      maxWidth: 220,
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
      key: 'column6',
      name: 'Bachas',
      fieldName: 'ParrillasEmpParciales',
      minWidth: 50,
      maxWidth: 100,
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
      key: 'column7',
      name: 'Bultos/Bachas',
      fieldName: 'BultosParciales',
      minWidth: 60,
      maxWidth: 120,
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
      key: 'column8',
      name: 'Total',
      fieldName: 'Total',
      minWidth: 50,
      maxWidth: 100,
      isRowHeader: true,
      isResizable: true,
      isSorted: false,
      isSortedDescending: false,
      sortAscendingAriaLabel: 'Sorted A to Z',
      sortDescendingAriaLabel: 'Sorted Z to A',
      data: 'number',
      isPadded: true,
    },
  ]

  return (
    <Stack horizontal>
      <Stack.Item grow={true} align="start" verticalFill={true}>
      </Stack.Item>
      <Stack.Item align="center" verticalFill={true} grow={true} role="table">
        <DetailsList
          items={productos.map((producto) => {
            return {
              ...producto,
              Total:
                producto.Empacado +
                producto.ParrillasEmpActivas +
                producto.ParrillasEmpParciales +
                producto.Embarcado,
            }
          })}
          columns={columns}
          setKey="set"
          layoutMode={1}
          constrainMode={1}
          usePageCache={true}
          useReducedRowRenderer={true}
          isHeaderVisible={true}
          enableUpdateAnimations={true}
          compact={true}
          checkboxVisibility={2}
          selectionMode={2}
          // onRenderDetailsFooter={(detailsFooterProps: any) => {
          //   return (
          //     <div>
          //       <Text variant="xLarge">
          //         Total: {detailsFooterProps.totalCount}
          //       </Text>
          //     </div>
          //   )
          // }}
          styles={{
            root: {
              textAlign: 'center',
              display: 'flex',
              flexDirection: 'column',
            },
          }}
          // selectionPreservedOnEmptyClick={true}
          // enterModalSelectionOnTouch={true}
          // ariaLabelForSelectionColumn='Toggle selection'
        />
      </Stack.Item>
    </Stack>
  )
}
