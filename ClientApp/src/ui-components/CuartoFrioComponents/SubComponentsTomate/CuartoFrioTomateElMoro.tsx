import { ConstrainMode, DetailsList, DetailsListLayoutMode, IColumn, ImageFit,Image, Stack, IImageProps } from '@fluentui/react';
import axios from 'axios';
import { Images, Theme } from '../../../styles/Theme'
import * as React from 'react';
import {  urlGetTomateElMoro } from '../../../services/endpoints';
import { ICuartoFrioState } from '../../../models/Productos';

const imageProps: Partial<IImageProps> = {
    imageFit: ImageFit.cover,
    src: Images.imgNotFound,
    alt: 'frello',
    style: {
      width: '120px',
      height: 'auto',
      alignContent: 'center',
      justifyContent: 'center',
      display: 'flex',
      alignItems: 'center',
      position: 'relative',

      marginLeft: '100px',
    },
  }

export class CuartoFrioTomateElMoro extends React.Component<{}, ICuartoFrioState> {
    async componentDidMount() {
        const response = await axios.get(urlGetTomateElMoro);
        this.setState({ items: response.data })
        console.log(response.data);
    }

    private _columns: IColumn[];

    constructor(props: {}) {
        super(props);
        this.state = {
            items: [],
            Parrillas_Chep: 0,
            BultosParciales: 0,
            Empacado: 0,
            ParrillasEmpActivas: 0,
            ParrillasEmpParciales: 0,
            Embarcado: 0,
            NomEtiqueta: '',
            NomProducto: '',
          }

        this._columns = [
            {
                key: 'Tamaño',
                name: 'Tamaño',
                fieldName: 'NomTamano',
                minWidth: 100,
                maxWidth: 200,
                isResizable: true
            },
            {
                key: 'Bultos',
                name: 'Bultos',
                fieldName: 'Empacado',
                minWidth: 100,
                maxWidth: 200,
                isResizable: true
            },
            {
                key: 'Parrillas',
                name: 'Parrillas',
                fieldName: 'ParrillasEmpActivas',
                minWidth: 100,
                maxWidth: 200,
                isResizable: true,
            },
            {
                key: 'ParrillasChep',
                name: 'Parrillas CHEP',
                fieldName: '',
                minWidth: 100,
                maxWidth: 200,
                isResizable: true,
            },
            {
                key: 'ParrillasEmbarcadas',
                name: 'Parrillas Embarcadas',
                fieldName: 'Embarcado',
                minWidth: 100,
                maxWidth: 200,
                isResizable: true,
            },
            {
                key: 'Bachas',
                name: 'Bachas',
                fieldName: 'ParrillasEmpParciales',
                minWidth: 40,
                maxWidth: 200,
                isResizable: true
            },
            {
                key: 'Bultos_Bachas',
                name: 'Bultos/Bachas',
                fieldName: 'BultosParciales',
                minWidth: 40,
                maxWidth: 200,
                isResizable: true
            },
        ];
    }
    public render(): JSX.Element {
        return (
            <Stack >
                <Stack horizontal >
                    <Stack.Item>
                        {/* <DocumentCard type={DocumentCardType.normal} styles={{ root: { backgroundColor: Theme.palette.themePrimary }, }}>
                            <DocumentCardImage height={80} imageFit={ImageFit.centerContain} imageSrc={Images.sunsetLogo} styles={{ root: { backgroundColor: Theme.palette.neutralLight }, }} />
                        </DocumentCard> */}
                        <Image {...imageProps} />
                    </Stack.Item>
                    <DetailsList
                        items={this.state.items}
                        columns={this._columns}
                        layoutMode={DetailsListLayoutMode.fixedColumns}
                        constrainMode={ConstrainMode.unconstrained}
                        setKey="set"
                        usePageCache={true}
                        useReducedRowRenderer={true}
                        isHeaderVisible={false}
                        enableUpdateAnimations={true}
                        compact={true}
                        checkboxVisibility={2}
                        selectionMode={2}
                        styles={{
                            root: {
                                backgroundColor: Theme.palette.white,
                                padding: '10px',
                                margin: '10px',
                                marginRight: '800px',
                                marginLeft: 'auto',
                                marginTop: '4px',
                                width: '100%',
                                height: '100%',
                                display: 'flex',
                                flexDirection: 'column',
                                alignItems: 'center',
                                justifyContent: 'center',
                                overflow: 'hidden',
                                overflowY: 'auto',
                                overflowX: 'hidden',
                                WebkitOverflowScrolling: 'touch',
                            },
                        }}
                    />
                </Stack>
            </Stack>
        );
    }
}


export default CuartoFrioTomateElMoro;

