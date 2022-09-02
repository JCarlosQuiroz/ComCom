import React from 'react';
import {
    Stack, IStackStyles, IStackItemStyles, SearchBox, DetailsList, DetailsListLayoutMode, IColumn,
    CommandBar, ICommandBarItemProps, IButtonProps, ITheme, createTheme, IStackTokens, Separator, StackItem} from "@fluentui/react";
import { RapAddEdit } from './Rap-Add-Edit';




const Theme: ITheme = createTheme({
    fonts: {
        medium: {
            fontFamily: 'Segoe UI,Roboto,Oxygen,Ubuntu,Cantarell,Fira Sans',
            fontSize: '30px',
            display: 'inline-block', marginBottom: 60, top: 40
        },
    },
});

const stackTokens: IStackTokens = { childrenGap: 12 };

export interface RetailClientList {

    CardCode: string;
    CardName: string;
    LicTradNum: string;
    PymntGroup: string;
    ReferenciaHSBC: number;
    Opciones: any;
}

const ViewContainerStyle: IStackStyles = {
    root: {
        minHeight: "100vh",
        display: "flex",
        flexDirection: "column",
        textAlign: "center"
    }
};


const ViewCommandBarStyle: IStackItemStyles = {
    root: {
        order: 0,
        minWidth: "100vh",
        flexGrow: 0,
        flexShrink: 0,
        padding: 0,
        textAlign: "center",
    }

};

const ViewCommandBarSearchBoxStyle = {
    root: {
        width: "300px",
        textAlign: "center",

    }
};

export default class RapShowComponent extends React.Component {


    private overflowProps: IButtonProps = { ariaLabel: 'More commands' };

    private _navItems: ICommandBarItemProps[] = [

    ];

    private _navFarItems: ICommandBarItemProps[] = [
        {
            key: 'ViewSearch',
            onRender: () => {
                return (
                    <SearchBox className="searchBox" styles={ViewCommandBarSearchBoxStyle} />);
            }
        }
    ];


    private _columns: IColumn[];
    private _items: RetailClientList[];


    constructor(props: {}) {
        super(props);

        this._columns = [
            {
                key: 'CardCode',
                name: 'Codigo Cliente',
                fieldName: 'CardCode',
                minWidth: 80,
                maxWidth: 120,
                isResizable: true
            },
            {
                key: 'CardName',
                name: 'Nombre del Cliente',
                fieldName: 'CardName',
                minWidth: 100,
                maxWidth: 200,
                isResizable: true
            },
            {
                key: 'LicTradNum',
                name: 'RFC',
                fieldName: 'LicTradNum',
                minWidth: 100,
                maxWidth: 150,
                isResizable: true
            },
            {
                key: 'PymntGroup',
                name: 'Condicion de Pago',
                fieldName: 'PymntGroup',
                minWidth: 100,
                maxWidth: 150,
                isResizable: true
            },
            {
                key: 'Num de Referencia',
                name: 'Numero de Referencia',
                fieldName: 'ReferenciaHSBC',
                minWidth: 100,
                maxWidth: 200,
                isResizable: true
            }
        ];

        this._items = [
            {
                CardCode: "CAH769",
                CardName: "JORGE HERNANDEZ RODRIGUEZ",
                LicTradNum: "HERJ400206CC4",
                PymntGroup: "CONTADO",
                ReferenciaHSBC: 31872005,
                Opciones: ""
            }
        ];

    }

    render = () => {
        return (
            <Stack tokens={stackTokens}>
                <Separator theme={Theme}>Listado de referencias RAP HSBC</Separator>
                <StackItem>
            <Stack styles={ViewContainerStyle}>
                <Stack.Item styles={ViewCommandBarStyle}>
                    <CommandBar
                        items={this._navItems}
                        overflowButtonProps={this.overflowProps}
                        farItems={this._navFarItems}
                        ariaLabel="Use left and right arrow keys to navigate between commands" />
                </Stack.Item>
                <Stack.Item>
                    <RapAddEdit />
                </Stack.Item>
                <Stack.Item>
                    <DetailsList items={this._items} columns={this._columns} layoutMode={DetailsListLayoutMode.justified} />
                </Stack.Item>
                    </Stack>
                </StackItem>
            </Stack>

        );

    }
}