import {
    DetailsList,
    IColumn,
    Image,
    Stack,
  } from '@fluentui/react'
  import axios from 'axios'
  import { Images, Theme } from '../../../styles/Theme'
  import * as React from 'react'
  // import { urlGetPepinoEuropeoFrello } from '../../../services/endpoints'
  import { ICuartoFrioState } from '../../../models/Productos';
  

  export default function CuartoFrioPepinoEuropeoFrello(props: ICuartoFrioState) {
    const [productos, setProductos] = React.useState<ICuartoFrioState[]>([])
    React.useEffect(() => {
      axios.get('https://localhost:44394/api/GetPepinoSunset').then((response) => {
        setProductos(response.data)

      })
    }, [])
  
    const columns: IColumn[] = [
      {
        key: 'column1',
        name: 'Tamaño',
        fieldName: 'NomTamano',
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
      {
        key: 'column2',
        name: 'Bultos',
        fieldName: 'Empacado',
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
        name: 'Parrillas',
        fieldName: 'ParrillasEmpActivas',
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
        name: 'Parrillas CHEP',
        fieldName: 'Parrillas_Chep',
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
        key: 'column5',
        name: 'Parrillas Embarcadas',
        fieldName: 'Embarcado',
        minWidth: 130,
        maxWidth: 250,
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
        key: 'column7',
        name: 'Bultos/Bachas',
        fieldName: 'BultosParciales',
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
        key: 'column8',
        name: 'Total',
        fieldName: 'Total',
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
    ]
  
    return (
      <Stack horizontal>
        <Stack.Item grow={true} align="start" verticalFill={true}>
        <Image
          src={Images.frello}
          alt="frello"
          imageFit={1}
          styles={{
            root: {
              width: '120px',
              height: '120px',
              display: 'flex',
              marginTop: '50px',
              marginRight: '50px',
              flexDirection: 'column',
              justifyContent: 'center',
              alignItems: 'center',
              borderRadius: '50%',
              borderColor: Theme.palette.neutralPrimary,
              borderWidth: '2px',
              borderStyle: 'solid',
              transition: 'all 0.5s ease-in-out',
              ':hover': {
                transform: 'scale(1.1)',
                borderColor: Theme.palette.themePrimary,
              },
            },
          }}
        />
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
            isHeaderVisible={false}
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
  