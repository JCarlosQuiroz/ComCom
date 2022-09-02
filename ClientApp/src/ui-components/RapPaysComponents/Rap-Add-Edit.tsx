import React from 'react';
import { useId, useBoolean } from '@fluentui/react-hooks';
import {
    mergeStyleSets,
    FontWeights,
    ContextualMenu,
    Modal,
    TextField,
    IDragOptions,
    IIconProps,
    Stack,
    IStackProps,
    PrimaryButton,
    IconButton,
    IButtonStyles,
    IStackStyles,
    IStyleSet,
    ILabelStyles,
    Label,
    Pivot,
    PivotItem,
    IDropdownStyles,
    IDropdownOption,
    Dropdown,
    DatePicker,
    defaultDatePickerStrings,
    DayOfWeek,
} from '@fluentui/react';
import { Theme } from '../../styles/Theme';






const stackTokens = { childrenGap: 50 };

const viewIcon: IIconProps = {
    iconName: 'View',
};
const cancelIcon: IIconProps = {
    iconName: 'Cancel'
};


const addIcon: IIconProps = {
    iconName: "Add"
};

const stackStyles: Partial<IStackStyles> = {
    root: {
        height: "auto",
    }
};

const columnProps: Partial<IStackProps> = {
    tokens: {
        childrenGap: 15
    },
    styles: {
        root: {
            width: 300
        }
    },
};



const labelStyles: Partial<IStyleSet<ILabelStyles>> = {
    root: { marginTop: 10 },
};


const dropdownStyles: Partial<IDropdownStyles> = {
    dropdown: { width: 300 },
};


const cuentadestino: IDropdownOption[] = [
    { key: 'HSBC', text: 'HSBC' },
    { key: 'Santander', text: 'Santander' },
    { key: 'Bancomer', text: 'Bancomer' },
    { key: 'Banamex', text: 'Banamex' }
];


const formapago: IDropdownOption[] = [
    { key: 'Contado', text: 'Contado' },
    { key: 'Credito', text: 'Credito' },
]

const contentStyles = mergeStyleSets({
    container: {
        display: 'flex',
        flexFlow: 'column nowrap',
        alignItems: 'stretch',
    },
    header: [

        Theme.fonts.xLarge,
        {
            flex: '1 1 auto',
            borderTop: `4px solid ${Theme.palette.themePrimary}`,
            color: Theme.palette.neutralPrimary,
            display: 'flex',
            alignItems: 'center',
            fontWeight: FontWeights.semibold,
            padding: '12px 12px 14px 24px',
        },
    ],
    body: {
        flex: '4 4 auto',
        padding: '0 24px 24px 24px',
        overflowY: 'hidden',
        selectors: {
            p: { margin: '14px 0' },
            'p:first-child': { marginTop: 0 },
            'p:last-child': { marginBottom: 0 },
        },
    },
});
const iconButtonStyles: Partial<IButtonStyles> = {
    root: {
        color: Theme.palette.neutralPrimary,
        marginLeft: 'auto',
        marginTop: '4px',
        marginRight: '2px',
    },
    rootHovered: {
        color: Theme.palette.neutralDark,
    },
};

export const RapAddEdit: React.FunctionComponent = () => {

    const [isModalOpen, {
        setTrue: showModal,
        setFalse: hideModal
    }] = useBoolean(false);
    const [isDraggable] = useBoolean(false);
    const [keepInBounds] = useBoolean(false);
    // Normally the drag options would be in a constant, but here the toggle can modify keepInBounds
    const dragOptions = React.useMemo(
        (): IDragOptions => ({
            moveMenuItemText: 'Move',
            closeMenuItemText: 'Close',
            menu: ContextualMenu,
            keepInBounds,
        }),
        [keepInBounds],
    );

    // Use useId() to ensure that the IDs are unique on the page.
    // (It's also okay to use plain strings and manually ensure uniqueness.)
    const titleId = useId('title');
    // Only for the first checkbox, which is controlled
    const [firstDayOfWeek] = React.useState(DayOfWeek.Sunday);
    return (
        <div>
            <PrimaryButton iconProps={viewIcon} onClick={showModal} text="Nueva Referencia" />

            <Modal
                titleAriaId={titleId}
                isOpen={isModalOpen}
                onDismiss={hideModal}
                isBlocking={false}
                containerClassName={contentStyles.container}
                dragOptions={isDraggable ? dragOptions : undefined}>

                <div className={contentStyles.header}>
                    <span id={titleId}>Generar Referencia</span>
                    <IconButton
                        styles={iconButtonStyles}
                        iconProps={cancelIcon}
                        ariaLabel="Close popup modal"
                        onClick={hideModal}
                    />
                </div>
                <div className={contentStyles.body}>

                    <Pivot>

                        <PivotItem headerText="General">
                            <Label styles={labelStyles}>
                                <PrimaryButton iconProps={addIcon} onClick={addReference } text="Generar Referencia" />
                                <Stack horizontal tokens={stackTokens} styles={stackStyles}>

                                    <Stack {...columnProps}>
                                        <DatePicker
                                            firstDayOfWeek={firstDayOfWeek}
                                            placeholder="Seleccione la fecha"
                                            label="Desde.."
                                            // DatePicker uses English strings by default. For localized apps, you must override this prop.
                                            strings={defaultDatePickerStrings} />
                                        
                                        <TextField label="Cliente" />
                                    </Stack>

                                    <Stack {...columnProps}>
                                        <DatePicker
                                            firstDayOfWeek={firstDayOfWeek}
                                            placeholder="Seleccione la fecha"
                                            label="Hasta.."
                                            // DatePicker uses English strings by default. For localized apps, you must override this prop.
                                            strings={defaultDatePickerStrings}
                                        />
                                        <TextField label="Comentarios" />

                                    </Stack>

                                    <Stack {...columnProps}>
                                        <Dropdown placeholder='Seleccione una opcion' label="Forma de Pago" options={formapago} styles={dropdownStyles} />

                                    <Stack {...columnProps}>
                                            <Dropdown
                                                placeholder="Seleccione una opción"
                                                label="Cuenta de destino"
                                                options={cuentadestino}
                                                styles={dropdownStyles}/>
                                        </Stack>

                                        <TextField label="Importe" placeholder="$" />


                                    </Stack>

                                </Stack>
                            </Label>

                        </PivotItem>

                    </Pivot>

                </div>

            </Modal>

        </div>
    );

    function addReference() {

        const CardCode = 'CAH720';
        for (var i = 0; i < CardCode.length; i++) {

            console.log(' Caracter ' + CardCode[i]);
        };

        alert('referencia generada');
    }
};
