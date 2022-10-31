import { ICommandBarStyles, ICommandBarItemProps, ContextualMenuItemType, IColumn, Stack, CommandBar, DetailsList } from "@fluentui/react"
import axios from "axios"

import React from "react"
import { Images } from "../../styles/Theme"
import { ICuartoFrioState } from "../../models/Productos"
// import { getTest } from "../../services/endpoints"


const innerCommandBarStyles: ICommandBarStyles = {
  root: {
    height: '100%',
  },
}

const innerCommandBarItems: ICommandBarItemProps[] = [
  {
    key: 'Nuevo',
    name: 'Nuevo',
    iconProps: {
      iconName: 'Add',
    },
    subMenuProps: {
      items: [
        {
          key: 'Folder',
          name: 'Carpeta',
          iconProps: {
            iconName: 'FolderHorizontal',
          },
        },
        {
          key: 'Divider1',
          itemType: ContextualMenuItemType.Divider,
        },
        {
          key: 'WordDocument',
          name: 'Documento de Word',
          iconProps: {
            iconName: 'WordDocument',
          },
        },
        {
          key: 'ExcelWorkbook',
          name: 'Libro de Excel',
          iconProps: {
            iconName: 'ExcelDocument',
          },
        },
        {
          key: 'PowerPointPresentation',
          name: 'Presentación de PowerPoint',
          iconProps: {
            iconName: 'PowerPointDocument',
          },
        },
        {
          key: 'OneNoteNotebook',
          name: 'Cuaderno de OneNote',
          iconProps: {
            iconName: 'OneNoteLogo',
          },
        },
        {
          key: 'ExcelSurvey',
          name: 'Encuesta de Excel',
          iconProps: {
            iconName: 'ExcelDocument',
          },
        },
        {
          key: 'PlainTextDocument',
          name: 'Documento de texto plano',
          iconProps: {
            iconName: 'TextDocument',
          },
        },
      ],
    },
  },
  {
    key: 'Upload',
    name: 'Subir',
    iconProps: {
      iconName: 'Upload',
    },
    subMenuProps: {
      items: [
        {
          key: 'Files',
          name: 'Archivos',
        },
        {
          key: 'Carpeta',
          name: 'Carpeta',
        },
      ],
    },
  },
]

const innerCommandBarFarItems: ICommandBarItemProps[] = [
  {
    key: 'Sort',
    name: 'Ordenar',
    iconProps: {
      iconName: 'SortLines',
    },
    subMenuProps: {
      items: [
        {
          key: 'Name',
          name: 'Nombre',
        },
        {
          key: 'Modified',
          name: 'Modificado',
        },
        {
          key: 'Size',
          name: 'Tamaño',
        },
        {
          key: 'Divider2',
          itemType: ContextualMenuItemType.Divider,
        },
        {
          key: 'Ascending',
          name: 'Ascendente',
        },
        {
          key: 'Descending',
          name: 'Descendente',
        },
        {
          key: 'Divider3',
          itemType: ContextualMenuItemType.Divider,
        },
        {
          key: 'SaveSortOrder',
          name: 'Guardar orden',
        },
      ],
    },
  },
  {
    key: 'ViewAll',
    iconOnly: true,
    iconProps: {
      iconName: 'ViewAll',
    },
  },
  {
    key: 'Info',
    iconOnly: true,
    iconProps: {
      iconName: 'Info',
    },
  },
]




export default function CuartoFrioBerenjenaTest(): JSX.Element {
  const [productos, setProductos] = React.useState<ICuartoFrioState[]>([])

  React.useEffect(() => {
    axios.get('https://localhost:44394/api/GetPepinoSunset').then((response) => {
      setProductos(response.data)
      console.log(response.data)
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
      onRender: (item: ICuartoFrioState) => {
        return <img src={Images.product03} alt="producto" />
      },
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
      name: 'Nom Producto',
      fieldName: 'NomProducto',
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
      key: 'column9',
      name: 'Etiqueta',
      fieldName: 'NomEtiqueta',
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
    <Stack
      horizontalAlign="space-evenly"
      tokens={{
        childrenGap: 20,
        maxHeight: '100%',
        maxWidth: '100%',
      }}
    >
      <Stack
        horizontalAlign="center"
        verticalAlign="center"
        tokens={{ childrenGap: 20 }}
      >

      </Stack>
      <Stack.Item>
        <CommandBar
          items={innerCommandBarItems}
          farItems={innerCommandBarFarItems}
          styles={innerCommandBarStyles}
        />
      </Stack.Item>
      <Stack
        horizontal
        wrap
        tokens={{ padding: '0px 0px 0px 30px', childrenGap: 10 }}
      >
          <DetailsList 
          // items={productos.filter(producto => producto.NomEtiqueta === 'FRELLO')}
          items={productos}
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
            // onRenderDetailsFooter={productos.filter(producto => producto.NomEtiqueta === 'FRELLO').length > 0 ? () => {
            //   return (
            //     <Stack
            //       horizontal
            //       wrap
            //       tokens={{ padding: '0px 0px 0px 30px', childrenGap: 10 }}
            //     >
            //      <Stack.Item>
            //      <Text variant="xLarge">
            //        Total: {productos.filter(producto => producto.NomEtiqueta === 'FRELLO').length}
            //      </Text>
            //    </Stack.Item>
            //     <Stack.Item>
            //       <Text variant="xLarge">
            //         Bultos: {productos.filter(producto => producto.NomEtiqueta === 'FRELLO').map(producto => producto.Empacado).reduce((a, b) => a + b, 0)}
            //       </Text>
            //     </Stack.Item>
            //     <Stack.Item>
            //       <Text variant="xLarge">
            //         Parrillas: {productos.filter(producto => producto.NomEtiqueta === 'FRELLO').map(producto => producto.ParrillasEmpActivas).reduce((a, b) => a + b, 0)}
            //       </Text>
            //     </Stack.Item>
            //     <Stack.Item>
            //       <Text variant="xLarge">
            //         Parrillas CHEP: {productos.filter(producto => producto.NomEtiqueta === 'FRELLO').map(producto => producto.Parrillas_Chep).reduce((a, b) => a + b, 0)}
            //       </Text>
            //     </Stack.Item>
            //     <Stack.Item>
            //       <Text variant="xLarge">
            //         Parrillas Embarcadas: {productos.filter(producto => producto.NomEtiqueta === 'FRELLO').map(producto => producto.Embarcado).reduce((a, b) => a + b, 0)}
            //       </Text>
            //     </Stack.Item>
            //     <Stack.Item>
            //       <Text variant="xLarge">
            //         Bachas: {productos.filter(producto => producto.NomEtiqueta === 'FRELLO').map(producto => producto.ParrillasEmpParciales).reduce((a, b) => a + b, 0)}
            //       </Text>
            //     </Stack.Item>
            //     <Stack.Item>
            //       <Text variant="xLarge">
            //         Bultos/Bachas: {productos.filter(producto => producto.NomEtiqueta === 'FRELLO').map(producto => producto.BultosParciales).reduce((a, b) => a + b, 0)}
            //       </Text>
            //     </Stack.Item>
            //   </Stack>
            //   )
            // } : undefined}
          />
          <DetailsList 
          items={productos.filter(producto => producto.NomEtiqueta === 'GRECOS', productos.filter(producto => producto.NomProducto === 'PEPINO'))}
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
            />
      </Stack>
    </Stack>
  )
}
//const mapStateToProps = (state: { productos: { productos: any; loading: any; error: any } }) => {
//  return {
//    productos: state.productos.productos,
//    loading: state.productos.loading,
//    error: state.productos.error,
//  }
//}


// function onRenderCheckForFooterRow(props: IDetailsFooterProps, defaultRender?: IRenderFunction<IDetailsFooterProps>): JSX.Element {
//   return (
//     <div>
//       {defaultRender!(props)}
//       <Stack horizontal tokens={{ childrenGap: 10 }}>
//         <Stack.Item>
//           <Text variant="mediumPlus" styles={{ root: { fontWeight: 'bold' } }}>
//             Total:
//           </Text>
//         </Stack.Item>
//       </Stack>
//     </div>
//   )
// }

// const renderDetailsFooterItemColumn: IDetailsRowBaseProps['onRenderItemColumn'] = (column: IColumn,item: any,) => {
//     if(column){
//       return (
//         <div>
//           <b>{column.fieldName}</b>
//         </div>
//       );
//     }
//     return undefined;
//   }
  
// const onRenderCheckForFooterRow: IDetailsRowBaseProps['onRenderCheck'] = (props): JSX.Element => {
//   return <DetailsRowCheck {...props} selected={true} />;
// };


