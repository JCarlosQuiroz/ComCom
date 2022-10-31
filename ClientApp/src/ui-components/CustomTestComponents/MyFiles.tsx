import {
    Stack,
    StackItem,
    CommandBar,
    ContextualMenuItemType,
    ICommandBarItemProps,
    ICommandBarStyles,
    ITextStyles,
    DocumentCard,
    DocumentCardDetails,
    DocumentCardTitle,
    ImageFit,
    DocumentCardImage,
    Breadcrumb
} from '@fluentui/react';
import { itemsWithHeading, _getCustomDivider, _getCustomOverflowIcon } from '../../constants/Breadcrum';

function MyFiles(): JSX.Element {
    // Component styles
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

    return (
        
        <Stack horizontalAlign='space-evenly' tokens={{ padding: '10px 0px 0px 205px', childrenGap: '2%', maxHeight: '100%', maxWidth: '100%' }}>
        <Breadcrumb
          style={{
            fontSize: "1rem",
          }}
          styles={{
            root: {
              margin: "0px 0px 0px 0px",
              selectors: {
                "&:not(:first-child)": {
                  marginTop: 24,
                },
              },
            },
          }}
          items={itemsWithHeading.filter((item) => item.text !== "Counter")}
          maxDisplayedItems={3}
          dividerAs={_getCustomDivider}
          onRenderOverflowIcon={_getCustomOverflowIcon}
        />
            <Stack horizontalAlign='center' verticalAlign='center' tokens={{ childrenGap: 20 }}>
               <h2>Mis Carpetas</h2>
            </Stack>
            <StackItem>
            <CommandBar
                items={innerCommandBarItems}
                farItems={innerCommandBarFarItems}
                styles={innerCommandBarStyles}
            />
            </StackItem>
            <Stack horizontal wrap tokens={{ padding: '0px 0px 0px 30px', childrenGap: 10 }}>
                {getFolderButtons()}
            </Stack>
        </Stack>
    );
}

const getFolderButtons = (): JSX.Element[] => {


    const dateTextStyles: ITextStyles = {
        root: {
            textAlign: 'center',
        }
    };

    let buttonArray: JSX.Element[] = [];
    for (let i = 1; i <= 10; i++) {
        const day = Math.ceil(Math.random() * 28);
        const month = Math.ceil(Math.random() * 12);
        const year = Math.ceil(Math.random() * 5) + 2016;

        const button: JSX.Element = (
            <div>
                <DocumentCard
                    styles={dateTextStyles}
                    onClickHref="/">
                    <DocumentCardImage height={100} imageFit={ImageFit.centerCover} iconProps={{ iconName: "Folder" }} />
                    <DocumentCardDetails/>
                        <DocumentCardTitle shouldTruncate title={'Carpeta'} />
                        Archivo {i},
                        {month}/{day}/{year}
                </DocumentCard>

            </div>
        );
        buttonArray.push(button);
    }
    return buttonArray;
};
export default MyFiles;