import { ISeparatorStyles, Separator, Stack } from '@fluentui/react';
import * as React from 'react';
import CuartoFrioTomates from './CuartoFrioTomates';
import { Theme } from '../../styles/Theme';


export interface IEmpaque {
    CodEntProduccion: string;
    CodEmpaque: string;
    NomEmpaque: string;
    Fecha: string;
    Tipo: string;
    NomTipo: string;
    Producto: string;
    NomProducto: string;
    Tamano: string;
    NomTamano: string;
    Clasificacion: string;
    NomClasificacion: string;
    Etiqueta: string;
    NomEtiqueta: string;
    Empacado: string;
    ParrillasEmpActivas: string;
    ParrillasEmpActivas1: string;
    Embarcado: string;
    ParrillasEmbarcado: string;
}



const ISepStyles: ISeparatorStyles = {
    root: {
        backgroundColor: Theme.palette.themePrimary,
        height: 2,
        width: '100%',
        marginTop: 20,
        marginBottom: 40,
    },
    content: {
        fontSize: '35px',
        fontWeight: "400",
        fontStyle: "normal",
        color: "#00a54f",
        bottom: 30,
    }
};
export const CuartoFrioMain: React.FunctionComponent = () => {
    return (
        <Stack horizontalAlign='stretch' horizontal wrap tokens={{ padding: '20px 0px 0px 0px', childrenGap: 30 }}>
            <Separator theme={Theme} styles={ISepStyles}>Reporte de Cuarto Frio</Separator>
            

            <CuartoFrioTomates/>

        </Stack>
    );
};

export default CuartoFrioMain;