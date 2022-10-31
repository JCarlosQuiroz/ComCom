import * as React from 'react';
import {
  MarqueeSelection, DetailsList, DetailsListLayoutMode, Selection,
  IColumn, Stack, Separator, ISeparatorStyles, CommandBar, ContextualMenuItemType, ICommandBarItemProps, ICommandBarStyles
} from '@fluentui/react';
import axios from 'axios';
import { Theme } from '../../styles/Theme';
// import { urlCatProved } from '../../services/endpoints';


const theme = Theme;

const ISepStyles: ISeparatorStyles = {
  root: {
    backgroundColor: theme.palette.themePrimary,
    height: 2,
    width: '100%',
    marginTop: 20,
    marginBottom: 5,
  },
  content: {
    fontSize: '30px',
    fontWeight: "400",
    fontStyle: "normal",
    color: "#00a54f",
    bottom: 20,
  }
};

const innerCommandBarStyles: ICommandBarStyles = {
  root: {
    height: '100%'
  }
};

const innerCommandBarItems: ICommandBarItemProps[] = [
  {
    key: "Nuevo",
    name: "Nuevo",
    iconProps: {
      iconName: "Add"
    },
    subMenuProps: {
      items: [
        {
          key: "Folder",
          name: "Carpeta",
          iconProps: {
            iconName: "FolderHorizontal"
          }
        },
        {
          key: "Divider1",
          itemType: ContextualMenuItemType.Divider
        },
        {
          key: "WordDocument",
          name: "Documento de Word",
          iconProps: {
            iconName: "WordDocument"
          }
        },
        {
          key: "ExcelWorkbook",
          name: "Libro de Excel",
          iconProps: {
            iconName: "ExcelDocument"
          }
        },
        {
          key: "PowerPointPresentation",
          name: "Presentación de PowerPoint",
          iconProps: {
            iconName: "PowerPointDocument"
          }
        },
        {
          key: "OneNoteNotebook",
          name: "Cuaderno de OneNote",
          iconProps: {
            iconName: "OneNoteLogo"
          }
        },
        {
          key: "ExcelSurvey",
          name: "Encuesta de Excel",
          iconProps: {
            iconName: "ExcelDocument"
          }
        },
        {
          key: "PlainTextDocument",
          name: "Documento de texto plano",
          iconProps: {
            iconName: "TextDocument"
          }
        }
      ]
    }
  },
  {
    key: "Upload",
    name: "Subir",
    iconProps: {
      iconName: "Upload"
    },
    subMenuProps: {
      items: [
        {
          key: "Files",
          name: "Archivos",
        },
        {
          key: "Carpeta",
          name: "Carpeta",
        }
      ]
    }
  }
];

const innerCommandBarFarItems: ICommandBarItemProps[] = [
  {
    key: "Sort",
    name: "Ordenar",
    iconProps: {
      iconName: "SortLines"
    },
    subMenuProps: {
      items: [
        {
          key: "Name",
          name: "Nombre",
        },
        {
          key: "Modified",
          name: "Modificado",
        },
        {
          key: "Size",
          name: "Tamaño",
        },
        {
          key: "Divider2",
          itemType: ContextualMenuItemType.Divider
        },
        {
          key: "Ascending",
          name: "Ascendente",
        },
        {
          key: "Descending",
          name: "Descendente",
        },
        {
          key: "Divider3",
          itemType: ContextualMenuItemType.Divider
        },
        {
          key: "SaveSortOrder",
          name: "Guardar orden",
        }
      ]
    }
  },
  {
    key: "ViewAll",
    iconOnly: true,
    iconProps: {
      iconName: "ViewAll"
    }
  },
  {
    key: "Info",
    iconOnly: true,
    iconProps: {
      iconName: "Info"
    }
  }
];

interface ICatProved {
  CodigoProvedor: string;
  CodigoProduccion: string;
  Ciudad: string;
  CP: string;
  Col: string;
  Email: string;
  Domicilio: string;
  Estado: string;
  Fax: string;
  UltimoPago: string;
  ImporteUltPago: string;
  TipoMercado: string;
  NombreEmpresa: string;
  RFC: string;
  NombreRepresentante: string;
  Tel: string;
  TipoSat: string;
}
interface ICatProvedState {
  items: ICatProved[];
  selectionDetails: string;
}


export class CatProved extends React.Component<{}, ICatProvedState> {

  async componentDidMount() {
    const res = await axios.get('https://localhost:44394/api/GetPepinoSunset');
    this.setState({ items: res.data });
    console.log(res.data);
  }
  private _selection: Selection;
  private _allItems: ICatProved[];
  private _columns: IColumn[];

  constructor(props: {}) {
    super(props);

    this._selection = new Selection({
      onSelectionChanged: () => this.setState({ selectionDetails: this._getSelectionDetails() }),
    });

    //    this._allItems = [
    this._allItems = [];
    for (let i = 0; i < 1; i++) {
      this._allItems.push({
        CodigoProvedor: 'Item ' + i,
        CodigoProduccion: 'Item ' + i,
        Ciudad: 'Item ' + i,
        CP: 'Item ' + i,
        Col: 'Item ' + i,
        Email: 'Item ' + i,
        Domicilio: 'Item ' + i,
        Estado: 'Item ' + i,
        Fax: 'Item ' + i,
        UltimoPago: 'Item ' + i,
        ImporteUltPago: 'Item ' + i,
        TipoMercado: 'Item ' + i,
        NombreEmpresa: 'Item ' + i,
        RFC: 'Item ' + i,
        NombreRepresentante: 'Item ' + i,
        Tel: 'Item ' + i,
        TipoSat: 'Item ' + i,
      });
    }

    this._columns = [
      { key: 'CodigoProduccion', name: 'Entidad de Produccion', fieldName: 'CodigoProduccion', minWidth: 40, maxWidth: 50, isResizable: true },
      { key: 'CodigoProvedor', name: 'Codigo de Proveedor', fieldName: 'CodigoProvedor', minWidth: 40, maxWidth: 50, isResizable: true, },
      { key: 'NombreEmpresa', name: 'Nombre de la Empresa', fieldName: 'NombreEmpresa', minWidth: 200, maxWidth: 200, isResizable: true },
      { key: 'NombreRepresentante', name: 'Nombre de Representante', fieldName: 'NombreRepresentante', minWidth: 200, maxWidth: 200, isResizable: true },
      { key: 'Ciudad', name: 'Ciudad', fieldName: 'Ciudad', minWidth: 60, maxWidth: 100, isResizable: true },
      { key: 'CP', name: 'Codigo Postal', fieldName: 'CP', minWidth: 40, maxWidth: 40, isResizable: true },
      { key: 'Col', name: 'Colonia', fieldName: 'Col', minWidth: 60, maxWidth: 120, isResizable: true },
      { key: 'Email', name: 'Correo Electronico', fieldName: 'Email', minWidth: 60, maxWidth: 120, isResizable: true },
      { key: 'Domicilio', name: 'Domicilio', fieldName: 'Domicilio', minWidth: 60, maxWidth: 100, isResizable: true },
      { key: 'Estado', name: 'Estado', fieldName: 'Estado', minWidth: 60, maxWidth: 100, isResizable: true },
      { key: 'Fax', name: 'Fax', fieldName: 'Fax', minWidth: 60, maxWidth: 80, isResizable: true },
      { key: 'UltimoPago', name: 'Ultimo Pago', fieldName: 'UltimoPago', minWidth: 40, maxWidth: 50, isResizable: true, },
      { key: 'ImporteUltPago', name: 'Importe de Ultimo Pago', fieldName: 'ImporteUltPago', minWidth: 40, maxWidth: 50, isResizable: true },
      { key: 'TipoMercado', name: 'Tipo de Mercado', fieldName: 'TipoMercado', minWidth: 60, maxWidth: 100, isResizable: true },
      { key: 'RFC', name: 'Registro Federal de Contribuyente', fieldName: 'RFC', minWidth: 60, maxWidth: 120, isResizable: true },
      { key: 'Tel', name: 'Telefono', fieldName: 'Tel', minWidth: 60, maxWidth: 100, isResizable: true },
      { key: 'TipoSat', name: 'Tipo de Contribuyente', fieldName: 'TipoSat', minWidth: 60, maxWidth: 100, isResizable: true },
    ];
    this.state = {
      items: this._allItems,
      selectionDetails: this._getSelectionDetails(),
    };
  }


  public render(): JSX.Element {
    const { items } = this.state;
    return (
      <Stack horizontalAlign='space-evenly' tokens={{ padding: '0px 0px 0px 0px', childrenGap: '1%', maxHeight: '100%', maxWidth: '100%' }}>
        <Separator theme={theme} styles={ISepStyles}>Proveedores</Separator>
        <CommandBar
          items={innerCommandBarItems}
          farItems={innerCommandBarFarItems}
          styles={innerCommandBarStyles}
        />
        <Stack horizontalAlign='center' horizontal wrap tokens={{ padding: '0px 0px 0px 0px', childrenGap: 0 }}>
          <MarqueeSelection selection={this._selection}>
            <DetailsList
              items={items}
              columns={this._columns}
              setKey="set"
              layoutMode={DetailsListLayoutMode.justified}
              selection={this._selection}
              selectionPreservedOnEmptyClick={true}
              ariaLabelForSelectionColumn="Toggle selection"
              ariaLabelForSelectAllCheckbox="Toggle selection for all items"
              checkButtonAriaLabel="select row"
              onItemInvoked={this._onItemInvoked}
            />
          </MarqueeSelection>
        </Stack>
      </Stack>
    );
  }

  private _getSelectionDetails(): string {
    const selectionCount = this._selection.getSelectedCount();

    switch (selectionCount) {
      case 0:
        return 'No hay clientes seleccionados';
      case 1:
        return '1 cliente seleccionado: ' + (this._selection.getSelection()[0] as ICatProved).CodigoProvedor;
      default:
        return `${selectionCount} clientes seleccionados`;
    }
  }


  private _onItemInvoked = (item: ICatProved): void => {
    alert(`Item invoked: ${item.CodigoProvedor}`);
  };
}
export default CatProved;