import { CommandBar, ContextualMenuItemType, ICommandBarItemProps, ICommandBarStyles, Stack } from '@fluentui/react';


export default function Contabilidad() {
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
    
    return (
        <Stack horizontalAlign='space-evenly'  tokens={{padding:'0px 0px 0px 204px',childrenGap:'5%', maxHeight:'100%',maxWidth:'100%' }}>

        <Stack horizontalAlign='center' verticalAlign='center' tokens={{ childrenGap: 5 }}>
        <h2>Contabilidad</h2>
        <div>
        <CommandBar 
        items={innerCommandBarItems} 
        styles={innerCommandBarStyles}
        />
        </div>
        </Stack>
        </Stack>
    );
}
