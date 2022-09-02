import {
  ConstrainMode,
  DetailsList,
  DetailsListLayoutMode,
  IColumn,
  IImageProps,
  Image,
  ImageFit,
  Stack,
} from '@fluentui/react'
import axios from 'axios'
import { Images, Theme } from '../../../styles/Theme'
import * as React from 'react'
import { urlGetTomateGrecos } from '../../../services/endpoints'
import { ICuartoFrioState } from '../../../models/Productos';

const imageProps: Partial<IImageProps> = {
  imageFit: ImageFit.cover,
  src: Images.grecosLogo,
  alt: 'Grecos',
  style: {
    width: '100px',
    height: 'auto',
    alignContent: 'center',
    justifyContent: 'center',
    display: 'flex',
    alignItems: 'center',
    position: 'relative',
    marginTop: '140px',
    marginLeft: '140px',
  },
}

// const previewProps: IDocumentCardPreviewProps = {
//     previewImages: [
//       {
//         name: 'Revenue stream proposal fiscal year 2016 version02.pptx',
//         previewImageSrc: Images.grecosLogo,
//         iconSrc: Images.product00,
//         imageFit: ImageFit.centerContain,
//         width: 318,
//         height: 196,
//       },
//         {
//         name: 'Revenue stream proposal fiscal year 2016 version02.pptx',
//         previewImageSrc: Images.grecosLogo,
//         iconSrc: Images.product00,
//         imageFit: ImageFit.centerContain,
//         width: 318,
//         height: 196,
//         },
    

//     ],
//   };
//   const DocumentCardActivityPeople = [{ name: 'Annie Lindqvist', profileImageSrc: Images.avatar01 }];







export class CuartoFrioTomateGrecos extends React.Component<
  {},
  ICuartoFrioState
> {
  async componentDidMount() {
    const response = await axios.get(urlGetTomateGrecos)
    this.setState({ items: response.data })
    console.log(response.data)
  }

  private _columns: IColumn[]

  constructor(props: {}) {
    super(props)
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
        isResizable: true,
      },
      {
        key: 'Bultos',
        name: 'Bultos',
        fieldName: 'Empacado',
        minWidth: 100,
        maxWidth: 200,
        isResizable: true,
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
        isResizable: true,
      },
      {
        key: 'Bultos_Bachas',
        name: 'Bultos/Bachas',
        fieldName: 'BultosParciales',
        minWidth: 40,
        maxWidth: 200,
        isResizable: true,
      },
    ]
  }
  public render(): JSX.Element {
    return (
      <Stack>
        <Stack horizontal>
          <Stack.Item>
            <Image {...imageProps} />
            {/* <DocumentCard
              aria-label="Default Document Card with large file name. Created by Annie Lindqvist a few minutes ago."
              onClickHref="http://bing.com"
            >
              <DocumentCardPreview {...previewProps} />
              <DocumentCardTitle
                title={
                  'Large_file_name_with_underscores_used_to_separate_all_of_the_words_and_there_are_so_many_words_' +
                  'it_needs_truncating.pptx'
                }
                shouldTruncate
              />
              <DocumentCardActivity
                activity="Created a few minutes ago"
                people={DocumentCardActivityPeople}
              />
            </DocumentCard> */}
          </Stack.Item>
          <DetailsList
            items={this.state.items}
            columns={this._columns}
            layoutMode={DetailsListLayoutMode.fixedColumns}
            constrainMode={ConstrainMode.unconstrained}
            setKey="set"
            usePageCache={true}
            useReducedRowRenderer={true}
            isHeaderVisible={true}
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
    )
  }
}

export default CuartoFrioTomateGrecos;
