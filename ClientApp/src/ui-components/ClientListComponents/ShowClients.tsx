import * as React from 'react';
import { mergeStyles, MarqueeSelection,DetailsList, DetailsListLayoutMode, Selection, 
  IColumn, Announced, CommandBar, IButtonProps, ICommandBarItemProps, IStackItemStyles, 
  IStackStyles, Stack, TextField, ITextFieldStyles } from '@fluentui/react';
import axios from 'axios';

import { AddClients } from './AddClients';
// import { urlClientes } from '../../services/endpoints';




const clientViewContainerStyle: IStackStyles ={
  root: {
    minHeight: "100vh",
    display: "flex",
    flexDirection: "column",
    marginLeft: "7%",
  }
};

const clientViewTitleAreaStyle: IStackItemStyles = {
  root: {
    order: 0,
    minWidth: "100vh",
    flexGrow: 0,
    flexShrink: 0,
    padding: 0,
    "text-align": "center",

  }
};

const clientViewCommandBarStyle: IStackItemStyles = {
  root: {
    order: 0,
    minWidth: "100vh",
    flexGrow: 0,
    flexShrink: 0,
    padding: 0,
    textAlign: "center"
  }

};

const clientViewCommandBarSearchBoxStyle: IStackItemStyles= {
  root: {
    width: "220px"
  }
};

const Clients = mergeStyles({
  display: 'block',
  marginBottom: '10px',
});

const textFieldStyles: Partial<ITextFieldStyles> = { 
  root: { 
    maxWidth: '300px' 
  } 
};

export interface IClientList {
  CodigoCliente: string;
  ClienteNombre: string;
  Telefono: string;
  RFC: string;
  CondiciondePago: string;
  LineaCredito: number;
  Ciudad: string;
  Estado: string;
}

export interface IClientListState {
  items: IClientList [];
  selectionDetails: string;
}


export class ShowClients extends React.Component<{}, IClientListState> {
  
async componentDidMount(){
  const res = await axios.get('https://localhost:44394/api/GetPepinoSunset');
  this.setState({items: res.data});
  console.log(res.data);
}
  private _selection: Selection;
  private _allItems: IClientList [];
  private _columns: IColumn[];
  private overflowProps: IButtonProps = { ariaLabel: 'More commands' };  
  private _navItems: ICommandBarItemProps[] = [
    {
        key: 'addclient',
        text: 'Agregar',
        ariaLabel: 'Agregar',
        iconProps: { iconName: 'Add' },
        onClick: () => alert(`Item invoked: ${this._allItems[0].CodigoCliente}`),
      },
      {
        key: 'editclient',
        text: 'Editar',
        ariaLabel: 'Editar',
        iconProps: { iconName: 'Edit' },
        onClick: () => console.log('Download'),
      },
      {
        key: 'download',
        text: 'Descargar',
        ariaLabel: 'Download',
        iconProps: { iconName: 'Download' },
        onClick: () => console.log('Download'),
      },
      {
        key: 'share',
        text: 'Compartir',
        ariaLabel: 'Share',
        iconProps: { iconName: 'Share' },
        onClick: () => console.log('Share'),
      },
      {
        key: 'upload',
        text: 'Cargar',
        ariaLabel: 'Upload',
        iconProps: { iconName: 'Upload' },
        href: '/',
      },
  ];
  private _navFarItems: ICommandBarItemProps[] = [
    {
      key: 'tile',
      text: 'Vista de cuadricula',
      // This needs an ariaLabel since it's icon-only
      ariaLabel: 'Grid view',
      iconOnly: true,
      iconProps: { iconName: 'Tiles' },
      onClick: () => console.log('Tiles'),
    },
    {
      key: 'info',
      text: 'Info',
      // This needs an ariaLabel since it's icon-only
      ariaLabel: 'Info',
      iconOnly: true,
      iconProps: { iconName: 'Info' },
      onClick: () => console.log('Info'),
    },
  ];

  constructor(props: {}) {
    super(props);

    this._selection = new Selection({
      onSelectionChanged: () => this.setState({ selectionDetails: this._getSelectionDetails() }),
    });

//    this._allItems = [
    this._allItems = [];
    for (let i = 0; i < 1; i++) {
      this._allItems.push({
        CodigoCliente: 'Item ' + i,
        ClienteNombre: 'Item ' + i,
        Telefono: 'Item ' + i,
        RFC: 'Item ' + i,
        CondiciondePago: 'Item ' + i,
        LineaCredito: i,
        Ciudad: 'Item ' + i,
        Estado: 'Item ' + i,
      });
    }

    this._columns = [
      { key: 'CardCode', name: 'Codigo', fieldName: 'CodigoCliente', minWidth: 40, maxWidth: 50, isResizable: true, },
      { key: 'CardName', name: 'Nombre', fieldName: 'ClienteNombre', minWidth: 200, maxWidth: 300, isResizable: true },
      { key: 'Phone1', name: 'Telefono', fieldName: 'Telefono', minWidth: 60, maxWidth: 100, isResizable: true },
      { key: 'LicTradNum', name: 'RFC', fieldName: 'RFC', minWidth: 100, maxWidth: 100, isResizable: true },
      { key: 'GroupNum', name: 'Condicion de Pago', fieldName: 'CondiciondePago', minWidth: 60, maxWidth: 120, isResizable: true },
      { key: 'CreditLine', name: 'Limite de Credito', fieldName: 'LineaCredito', minWidth: 60, maxWidth: 120, isResizable: true },
      { key: 'City', name: 'Ciudad', fieldName: 'Ciudad', minWidth: 60, maxWidth: 100, isResizable: true },
      { key: 'State', name: 'Estado', fieldName: 'Estado', minWidth: 60, maxWidth: 100, isResizable: true },
      { key: 'Options', name: 'Opciones', fieldName: 'Options', minWidth: 60, maxWidth: 80, isResizable: true },
    ];
 


    this.state = {
      items: this._allItems,
      selectionDetails: this._getSelectionDetails(),
    };
  }

  
  public render(): JSX.Element {
    const { items, selectionDetails } = this.state;
    return (
      <Stack horizontalAlign='center' verticalAlign='center' verticalFill styles={clientViewContainerStyle}>
        <Stack.Item styles={clientViewTitleAreaStyle}><h2>Listado de clientes VALPAH</h2></Stack.Item>
        <Stack.Item styles={clientViewCommandBarStyle}>
        <Announced styles={clientViewCommandBarSearchBoxStyle} message={selectionDetails} />
          <TextField
            className={Clients}
            styles={textFieldStyles}
            label="Filtrar por nombre:"
            onChange={this._onFilter}
            placeholder="Buscar..."/>
          <Announced message={`Número de elementos después del filtrado : ${items.length}.`} />
          <CommandBar
            items={this._navItems}
            overflowButtonProps={this.overflowProps}
            farItems={this._navFarItems}
            ariaLabel="Use left and right arrow keys to navigate between commands" />  
          </Stack.Item>
          <Stack.Item>
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
          </Stack.Item>
          <Stack.Item>
          <AddClients/>
          </Stack.Item>
      </Stack>
    );
  }

  private _getSelectionDetails(): string {
    const selectionCount = this._selection.getSelectedCount();

    switch (selectionCount) {
      case 0:
        return 'No hay clientes seleccionados';
      case 1:
        return '1 cliente seleccionado: ' + (this._selection.getSelection()[0] as IClientList ).CodigoCliente;
      default:
        return `${selectionCount} clientes seleccionados`;
    }
  }

  private _onFilter = (_ev: React.FormEvent<HTMLInputElement | HTMLTextAreaElement>, text: string | undefined): void => {
    this.setState({
      items: text ? this._allItems.filter(i => i.CodigoCliente.toLowerCase().indexOf(text) > -1) : this._allItems,
    });
  };

  private _onItemInvoked = (item: IClientList ): void => {
    alert(`Item invoked: ${item.ClienteNombre}`);
  };
}
export default ShowClients;