import * as React from 'react';
import { CommandBar, ICommandBarItemProps, Stack, ContextualMenuItemType, ICommandBarStyles,Separator, StackItem } from '@fluentui/react';
import axios from 'axios';




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

interface IClientListState {
    items: IClientList[];
    setItems: string;
}



export class ShowFactsPendsComponent extends React.Component<{}, IClientListState> {
    async componentDidMount() {
        const res = await axios.get('https://localhost:44394/api/Client');
        this.setState({ items: res.data });
        console.log(res.data);
    }
   public render(): JSX.Element{
    return(
        <Stack horizontalAlign='space-evenly' tokens={{ padding: '10px 0px 0px 205px', childrenGap: '2%', maxHeight: '100%', maxWidth: '100%' }}>
            <Separator> Listado de Referencias Oxxo</Separator>
    <CommandBar items={innerCommandBarItems} farItems={innerCommandBarFarItems} styles={innerCommandBarStyles} />
    <StackItem>
        
    </StackItem>
</Stack>
      
      
      
      
      );
    }
}
export default ShowFactsPendsComponent;