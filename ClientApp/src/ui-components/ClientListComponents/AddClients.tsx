import React from 'react';

// import { viewIcon, contentStyles, iconButtonStyles, cancelIcon, labelStyles, stackTokens, stackStyles, columnProps, usoCDFI, dropdownStyles, tipoPersona, editIcon, U_SO1_GRUP, addIcon } from 'constants/FluentStylesContext';

export const AddClients: React.FunctionComponent = () => {

    // Normally the drag options would be in a constant, but here the toggle can modify keepInBounds

    // Use useId() to ensure that the IDs are unique on the page.
    // (It's also okay to use plain strings and manually ensure uniqueness.)
    // Only for the first checkbox, which is controlled
    return (
        <div>

            {/* <PrimaryButton iconProps={viewIcon} onClick={showModal} text="Visualizar Cliente" />
            <Modal
                titleAriaId={titleId}
                isOpen={isModalOpen}
                onDismiss={hideModal}
                isBlocking={false}
                containerClassName={contentStyles.container}
                dragOptions={isDraggable ? dragOptions : undefined}
            >
                <div className={contentStyles.header}>
                    <span id={titleId}>Catalogo de Proveedores Valhpac</span>
                    <IconButton
                        styles={iconButtonStyles}
                        iconProps={cancelIcon}
                        ariaLabel="Close popup modal"
                        onClick={hideModal}
                    />
                </div>
                <div className={contentStyles.body}>
                    <Pivot aria-label="Listado de Clientes SERDI">
                        <PivotItem headerText="General">
                            <Label styles={labelStyles}>

                                <Stack horizontal tokens={stackTokens} styles={stackStyles}>
                                    <Stack {...columnProps}>
                                        <TextField label="Cliente" />
                                        <TextField label="Nombre o razon social" />
                                        <TextField label="RFC" />
                                        <TextField label="Tipo de socio" />
                                        <Dropdown placeholder='Seleccione una opcion' label="Uso CFDI" options={usoCDFI} styles={dropdownStyles} />
                                    </Stack>
                                    <Stack {...columnProps}>
                                        <Dropdown
                                            placeholder="Seleccione una opción"
                                            label="Tipo de Persona"
                                            options={tipoPersona}
                                            styles={dropdownStyles}
                                        />
                                        <TextField label="Telefono" />
                                        <TextField label="Correo electronico" />
                                        <br />
                                        <Checkbox label='Cliente Consolidador' boxSide='start' />
                                        <Checkbox label='Activo' boxSide="start" />
                                        <PrimaryButton iconProps={editIcon} text="Actualizar" />
                                    </Stack>
                                    <Stack {...columnProps}>
                                        <TextField label="Contacto" />
                                        <TextField label="Metodo de pago" />
                                        <TextField label="Numero de cuenta" />
                                        <Dropdown placeholder="Seleccione una opcion" label="Grupo de clientes" options={U_SO1_GRUP} styles={dropdownStyles} />
                                        <DefaultButton iconProps={addIcon} text="Nuevo" />
                                    </Stack>
                                </Stack>
                            </Label>
                        </PivotItem>

                        <PivotItem headerText="Direccion Fiscal">
                            <Label styles={labelStyles}>
                                <Stack horizontal tokens={stackTokens} styles={stackStyles}>
                                    <Stack {...columnProps}>
                                        <TextField label="Identificador" />
                                        <TextField label="Calle" />
                                        <TextField label="Numero Exterior" />
                                        <TextField label="Numero Interior" />
                                        <TextField label="Colonia" />
                                    </Stack>
                                    <Stack {...columnProps}>
                                        <TextField label="Ciudad" />
                                        <TextField label="Delegacion o Municipio" />
                                        <TextField label="Codigo Postal" />
                                        <TextField label="Pais aqui va un desplegable" />
                                        <TextField label="Estado aqui tambien va un desplegable" />
                                    </Stack>
                                </Stack>
                            </Label>
                        </PivotItem>
                        <PivotItem headerText="Direccion de entrega">
                            <Label styles={labelStyles}>
                                <Stack horizontal tokens={stackTokens} styles={stackStyles}>
                                    <Stack {...columnProps}>
                                        <TextField label="Identificador" />
                                        <TextField label="Calle" />
                                        <TextField label="Numero Exterior" />
                                        <TextField label="Numero Interior" />
                                        <TextField label="Colonia" />
                                    </Stack>
                                    <Stack {...columnProps}>
                                        <TextField label="Ciudad" />
                                        <TextField label="Delegacion o Municipio" />
                                        <TextField label="Codigo Postal" />
                                        <TextField label="Pais aqui va un desplegable" />
                                        <TextField label="Estado aqui tambien va un desplegable" />
                                    </Stack>
                                </Stack>
                            </Label>
                        </PivotItem>
                    </Pivot>

                </div>
            </Modal> */}

        </div>
    );
};

export default AddClients;