import * as React from 'react';
import { useConst } from '@fluentui/react-hooks';
import {
    Separator, Stack, StackItem, Announced,
    DetailsList, DetailsListLayoutMode, Selection, IColumn, IDetailsList,
    IconButton, PrimaryButton, IButtonStyles,
    Dialog, DialogFooter,
    TextField, ITextField,
    createArray,
    CommandBar,
    ICommandBarStyles,
    ICommandBarItemProps,
    ContextualMenuItemType} from '@fluentui/react';


const iconButtonStyles: Partial<IButtonStyles> = { 
    root: { 
        float: 'right', height: 'inherit' 
    }
 };

interface IClientList {
    CodigoCliente: string;
    ClienteNombre: string;
    Telefono: string;
    RFC: string;
    CondiciondePago: string;
    LineaCredito: number;
    Ciudad: string;
    Estado: string;
  }

export const OxxoPaysComponent: React.FunctionComponent = () => {
 
    const detailsList = React.useRef<IDetailsList>(null);

    const textField = React.useRef<ITextField>(null);

    const selection = useConst(() => new Selection());

    const [items, setItems] = React.useState<IClientList[]>(() =>
        createArray(1, i => ({
            CodigoCliente: 'Item ' + i,
            ClienteNombre: 'Item ' + i,
            Telefono: 'Item ' + i,
            RFC: 'Item ' + i,
            CondiciondePago: 'Item ' + i,
            LineaCredito: i,
            Ciudad: 'Item ' + i,
            Estado: 'Item ' + i,
        })),
    );

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
                        key: "Folder",
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
                        key: "Divider1",
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
                        key: "Divider2",
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
    const [dialogContent, setDialogContent] = React.useState<JSX.Element | undefined>(undefined);

    const [announced, setAnnounced] = React.useState<JSX.Element | undefined>(undefined);

    const deleteItem = React.useCallback((index: number): void => {
        setItems(prevItems => prevItems.filter((_item, i) => i !== index));
        setAnnounced(<Announced message="Item deleted" aria-live="assertive" />);
    }, []);

    const renameItem = React.useCallback((item: IClientList, index: number): void => {

        const updateItemName = () => {

            if (textField && textField.current) {
                setItems(prevItems => {
                    const renamedItems = [...prevItems];
                    renamedItems[index] = { ...prevItems[index], ClienteNombre: textField.current?.value || renamedItems[index].ClienteNombre };
                    return renamedItems;
                });
                setDialogContent(undefined);
                setAnnounced(<Announced message="Item renamed" aria-live="assertive" />);
            }
        };

        setDialogContent(
            <>
                <TextField componentRef={textField} label="Editar" defaultValue={item.ClienteNombre} />
                <DialogFooter/>
                    <PrimaryButton
                        // eslint-disable-next-line react/jsx-no-bind
                        onClick={updateItemName}
                        text="Guardar"
                    />

            </>,
        );
    }, []);

    const columns = useConst((): IColumn[] => [
        {
            key: 'CardCode',
            name: 'Codigo de Cliente',
            fieldName: 'CardCode',
            minWidth: 100,
            maxWidth: 200,
            onRender: (item: any) => (
                <div>
                    {item.name}
                </div>
            ),
        },
        {
            key: 'ClienteNombre',
            name: 'Nombre del Cliente',
            fieldName: 'ClienteNombre',
            minWidth: 100,
            maxWidth: 200,
            onRender: (item: any) => (
                <div>
                    {item.name}
                </div>
            ),
        },
        {
            key: 'LicTradNum',
            name: 'RFC',
            fieldName: 'LicTradNum',
            minWidth: 100,
            maxWidth: 200,
            onRender: (item: any) => (
                <div>
                    {item.name}
                </div>
            ),
        },
        {
            key: 'PymntGroup',
            name: 'Condicion de Pago',
            fieldName: 'PymntGroup',
            minWidth: 100,
            maxWidth: 200,
            onRender: (item: any) => (
                <div>
                    {item.name}
                </div>
            ),
        },
        {
            key: 'Num de Referencia',
            name: 'Numero de Referencia',
            fieldName: 'ReferenciaOxxo',
            minWidth: 100,
            maxWidth: 200,
            onRender: (item: any, index: any) => (
                <div>
                    {item.name}
                    <IconButton
                        menuIconProps={{ iconName: 'MoreVertical' }}
                        role="button"
                        aria-haspopup
                        aria-label="Show actions"
                        styles={iconButtonStyles}
                        menuProps={{
                            items: [
                                {
                                    key: 'Eliminar',
                                    text: 'Eliminar',
                                    onClick: () => deleteItem(index),
                                },
                                {
                                    key: 'Editar',
                                    text: 'Editar',
                                    onClick: () => renameItem(item, index),
                                },
                            ],
                        }}
                    />
                </div>
            ),
        },
    ]);

    const closeRenameDialog = React.useCallback((): void => {
        setDialogContent(undefined);
    }, []);

    return (
        <Stack horizontalAlign='space-evenly'  tokens={{padding:'10px 0px 0px 205px',childrenGap:'2%', maxHeight:'100%',maxWidth:'100%' }}>
            <Separator><h1>Catalogo Undefined</h1></Separator>
            {announced}
            <CommandBar items={innerCommandBarItems} farItems={innerCommandBarFarItems} styles={innerCommandBarStyles} />
            <StackItem>
                <DetailsList
                    componentRef={detailsList}
                    items={items}
                    columns={columns}
                    layoutMode={DetailsListLayoutMode.fixedColumns}
                    selection={selection}
                    selectionPreservedOnEmptyClick={false}
                    ariaLabelForSelectionColumn="Toggle selection"
                    ariaLabelForSelectAllCheckbox="Toggle selection for all items"
                    checkButtonAriaLabel="select row" />
                <Dialog hidden={!dialogContent} onDismiss={closeRenameDialog} closeButtonAriaLabel="Cerrar"/>{dialogContent}

            </StackItem>
        </Stack>
    );
};

