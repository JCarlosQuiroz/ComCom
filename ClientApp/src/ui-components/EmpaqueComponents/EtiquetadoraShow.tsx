import * as React from 'react';
import {
  DetailsList,
  DetailsListLayoutMode,
  IColumn,
  DetailsRow,
  SelectionMode,
  DetailsRowCheck,
  IDetailsRowBaseProps,
  IDetailsRowCheckStyles} from '@fluentui/react/lib/DetailsList';
import { DocumentCard, DocumentCardDetails, DocumentCardImage, DocumentCardTitle, IDocumentCardStyles, ImageFit, Stack, StackItem } from '@fluentui/react';
import axios from 'axios';
import grecos from '../../assets/img/logos/grecoLogo.png';
// import { urlRprtPalletsDets } from '../../services/endpoints';



export interface IEmpaque {
  key: number;
  name: string;
  value: number;
  etiqueta: string;
  tamanho: string;
  bultos: number;
  parrillas: number;
  parrillas_CHEP: number;
  parrillas_Emb: number;
  bachas: number;
  bultos_bachas: number;
}

export interface IEmpaqueState{
  items: IEmpaque[];
  selectionDetails: string;
}

export class EtiquetadoraShow extends React.Component<{}, IEmpaqueState> {
  async componentDidMount(){
    const res = await axios.get('https://localhost:44394/api/Empaque');
    this.setState({items: res.data});
    console.log(res.data);
  }
  
  
  private _allItems: IEmpaque[];
  private _columns: IColumn[];

  constructor(props: {}) {
    super(props);

    this._allItems = [];
    for (let i = 0; i < 5; i++) {
      this._allItems.push({
        key: i,
        name: 'Item ' + i,
        value: i,
        etiqueta: 'Etiqueta ' + i,
        tamanho: 'tamanho ' + i,
        bultos: i,
        parrillas: i,
        parrillas_CHEP: i,
        parrillas_Emb: i,
        bachas: i,
        bultos_bachas: i
      });
    }

    this._columns = [
      { key: 'column1', name: 'Etiqueta', fieldName: 'name', minWidth: 100, maxWidth: 200, isResizable: true },
      { key: 'column2', name: 'Nombre', fieldName: 'value', minWidth: 100, maxWidth: 200, isResizable: true },
      { key: 'column3', name: 'Tamaño', fieldName: 'tamanho', minWidth: 100, maxWidth: 200, isResizable: true },
      { key: 'column4', name: 'Bultos', fieldName: 'bultos', minWidth: 100, maxWidth: 200, isResizable: true },
      { key: 'column5', name: 'Parrillas', fieldName: 'parrillas', minWidth: 100, maxWidth: 200, isResizable: true },
      { key: 'column6', name: 'Parrillas CHEP', fieldName: 'parrillas_CHEP', minWidth: 100, maxWidth: 200, isResizable: true },
      { key: 'column7', name: 'Parrillas Emb', fieldName: 'parrillas_Emb', minWidth: 100, maxWidth: 200, isResizable: true },
      { key: 'column8', name: 'Bachas', fieldName: 'bachas', minWidth: 100, maxWidth: 200, isResizable: true },
      { key: 'column9', name: 'Bultos / Bachas', fieldName: 'bultos_bachas', minWidth: 100, maxWidth: 200, isResizable: true },   
    ];  
  }

 

  public render(): JSX.Element {

    const cardStyles: IDocumentCardStyles = {
        root: {
            textAlign: 'center',
            margin: 'auto',
            marginTop: '50px',
            width: '100%',
            maxWidth: '500px',
        }
    };
    
    return (


        <Stack horizontalAlign='space-evenly'  tokens={{padding:'0px 0px 0px 204px',childrenGap:'5%', maxHeight:'100%',maxWidth:'100%' }}>

        <Stack horizontalAlign='center' verticalAlign='center' tokens={{ childrenGap: 20 }}>
    
        <h1>Etiquetadora</h1>
        
        </Stack>

    <Stack horizontal wrap tokens={{ padding: '0px 0px 0px 30px', childrenGap: 10}}>
        
    <DocumentCard
            styles={cardStyles}
            >
            <DocumentCardImage height={250} width={500} imageFit={ImageFit.centerContain} imageSrc={grecos} />
            <DocumentCardDetails>    
            <DocumentCardTitle title="Grecos" shouldTruncate />
      <DetailsList
        items={this._allItems}
        columns={this._columns}
        setKey="set"
        layoutMode={DetailsListLayoutMode.justified}
        selectionPreservedOnEmptyClick={true}
        ariaLabelForSelectionColumn="Toggle selection"
        ariaLabelForSelectAllCheckbox="Toggle selection for all items"
        checkButtonAriaLabel="select row"
        onRenderDetailsFooter={this._onRenderDetailsFooter}
      />

            </DocumentCardDetails>
    </DocumentCard>

    <DocumentCard
            styles={cardStyles}>
            <DocumentCardImage height={250} width={500} imageFit={ImageFit.centerContain} imageSrc={grecos} />
            <DocumentCardDetails>    
            <DocumentCardTitle title="Sunset" shouldTruncate />
      <DetailsList
        items={this._allItems}
        columns={this._columns}
        setKey="set"
        layoutMode={DetailsListLayoutMode.justified}
        selectionPreservedOnEmptyClick={true}
        ariaLabelForSelectionColumn="Toggle selection"
        ariaLabelForSelectAllCheckbox="Toggle selection for all items"
        checkButtonAriaLabel="select row"
        onRenderDetailsFooter={this._onRenderDetailsFooter}
      />

            </DocumentCardDetails>

    </DocumentCard>

    <DocumentCard
            styles={cardStyles}>
            <DocumentCardImage height={250} width={500} imageFit={ImageFit.centerContain} imageSrc={grecos} />
            <DocumentCardDetails>    
            <DocumentCardTitle title="Sunny Fresh" shouldTruncate />
      <DetailsList
        items={this._allItems}
        columns={this._columns}
        setKey="set"
        layoutMode={DetailsListLayoutMode.justified}
        selectionPreservedOnEmptyClick={true}
        ariaLabelForSelectionColumn="Toggle selection"
        ariaLabelForSelectAllCheckbox="Toggle selection for all items"
        checkButtonAriaLabel="select row"
        onRenderDetailsFooter={this._onRenderDetailsFooter}
      />

            </DocumentCardDetails>
    </DocumentCard>

    <DocumentCard
            styles={cardStyles}>
            <DocumentCardImage height={250} width={500} imageFit={ImageFit.centerContain} imageSrc={grecos} />
            <DocumentCardDetails>    
            <DocumentCardTitle title="Pure Flavor" shouldTruncate />
      <DetailsList
        items={this._allItems}
        columns={this._columns}
        setKey="set"
        layoutMode={DetailsListLayoutMode.justified}
        selectionPreservedOnEmptyClick={true}
        ariaLabelForSelectionColumn="Toggle selection"
        ariaLabelForSelectAllCheckbox="Toggle selection for all items"
        checkButtonAriaLabel="select row"
        onRenderDetailsFooter={this._onRenderDetailsFooter}
      />

            </DocumentCardDetails>
    </DocumentCard>

    <DocumentCard
            styles={cardStyles}>
            <DocumentCardImage height={250} width={500} imageFit={ImageFit.centerContain} imageSrc={grecos} />
            <DocumentCardDetails>    
            <DocumentCardTitle title="Frello" shouldTruncate />
      <DetailsList
        items={this._allItems}
        columns={this._columns}
        setKey="set"
        layoutMode={DetailsListLayoutMode.justified}
        selectionPreservedOnEmptyClick={true}
        ariaLabelForSelectionColumn="Toggle selection"
        ariaLabelForSelectAllCheckbox="Toggle selection for all items"
        checkButtonAriaLabel="select row"
        onRenderDetailsFooter={this._onRenderDetailsFooter}
      />

            </DocumentCardDetails>
    </DocumentCard>

    <DocumentCard
            styles={cardStyles}>
            <DocumentCardImage height={250} width={500} imageFit={ImageFit.centerContain} imageSrc={grecos} />
            <DocumentCardDetails>    
            <DocumentCardTitle title="El Moro" shouldTruncate />
      <DetailsList
        items={this._allItems}
        columns={this._columns}
        setKey="set"
        layoutMode={DetailsListLayoutMode.justified}
        selectionPreservedOnEmptyClick={true}
        ariaLabelForSelectionColumn="Toggle selection"
        ariaLabelForSelectAllCheckbox="Toggle selection for all items"
        checkButtonAriaLabel="select row"
        onRenderDetailsFooter={this._onRenderDetailsFooter}
      />

            </DocumentCardDetails>
    </DocumentCard>
</Stack>
</Stack>



    );
  }

  private _onRenderDetailsFooter(_IDetailsFooterProps: any): JSX.Element {
    return (
        <StackItem>
      <DetailsRow
        {..._IDetailsFooterProps}
        columns={_IDetailsFooterProps.columns}
        item={{}}
        itemIndex={-1}
        groupNestingDepth={_IDetailsFooterProps.groupNestingDepth}
        selectionMode={SelectionMode.single}
        selection={_IDetailsFooterProps.selection}
        onRenderItemColumn={_renderDetailsFooterItemColumn}
        onRenderCheck={_onRenderCheckForFooterRow}
      />
        </StackItem>
    );
  }
}

const _renderDetailsFooterItemColumn: IDetailsRowBaseProps['onRenderItemColumn'] = (item, index, column) => {
  if (column) {
    return (
      <div>
        <b>{column.name}</b>
      </div>
    );
  };
};

const detailsRowCheckStyles: Partial<IDetailsRowCheckStyles> = { root: { visibility: 'hidden' } };

const _onRenderCheckForFooterRow: IDetailsRowBaseProps['onRenderCheck'] = (props): JSX.Element => {
  return <DetailsRowCheck {...props} styles={detailsRowCheckStyles} selected={true} />;
};


export default EtiquetadoraShow;