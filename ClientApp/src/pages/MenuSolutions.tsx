// import Ventas from '../assets/img/icons/Ventas.png';
import {
    ISeparatorStyles,
    IDocumentCardStyles,
    Stack,
    Separator,
    DocumentCard,
    DocumentCardImage,
    DocumentCardDetails,
    DocumentCardTitle,
    IDocumentCardTitleStyles,
  } from "@fluentui/react";
import { Images, Theme } from "../styles/Theme";



  export default function MenuSolution(props: any) {
    // const icondocImgStyles: IDocumentCardImageProps = {
    //     imageFit: ImageFit.centerContain,
    //     width: 100,
    //     height: 100,
    //     styles: {
    //         root: {
    //             overflow: 'hidden',
    //             backgroundColor: '#ffffff00',
    //             color: '#ffffff00',
    //         }
    //     }
    //// };
    //const stylesf: IDocumentCardTitleStyles = {
    //  root: {},
    //}

    const ISepStyles: ISeparatorStyles = {
      root: {
        backgroundColor: Theme.palette.themePrimary,
        height: 2,
        width: "100%",
        marginTop: 20,
        marginBottom: 40,
      },
      content: {
        fontSize: "26px",
        fontWeight: "400",
        fontStyle: "normal",
        color: Theme.palette.neutralPrimary,
        bottom: 28,
      },
    };
    const cardStyles: IDocumentCardStyles = {
      root: {
        display: "inline-block",
        marginRight: 15,
        marginBottom: 15,
        width: 10,
        backgroundColor: Theme.palette.neutralLighter,
        color: Theme.palette.neutralPrimary,
        border: "1px solid #ffffff00",
        borderRadius: 5,
        boxShadow: "0 0 0 0",
        transition: "box-shadow 0.2s ease-in-out",
        ":hover": {
          boxShadow: "0 0 0 0",
          border: "1px solid #ffffff00",
          backgroundColor: Theme.palette.neutralLighter,
          color: Theme.palette.neutralPrimary,
        },
        ":focus": {
          boxShadow: "0 0 0 0",
          border: "1px solid #ffffff00",
          backgroundColor: Theme.palette.neutralLighter,
          color: Theme.palette.neutralPrimary,
        },
      },
    };

    const stylesf: IDocumentCardTitleStyles = {
      root: {
        fontSize: "18px",
        fontWeight: "normal",
        color: Theme.palette.neutralPrimary,
        textAlign: "center",
        fontFamily: "Segoe UI",
        paddingTop: "10px",
        paddingBottom: "10px",
      },
    };

    return (
      <Stack
        horizontalAlign="center"
        tokens={{
          padding: "20px 0px 0px 0px",
          childrenGap: 50,
          maxHeight: "100%",
          maxWidth: "100%",
        }}
      >
        {/* <Separator theme={Theme} styles={ISepStyles}>
          Utilidades y Servicios
        </Separator> */}

        <Stack
          horizontalAlign="center"
          verticalAlign="baseline"
          horizontal
          wrap
          tokens={{ padding: "0px 0px 0px 0px", childrenGap: 0 }}
        >
          {/* <DocumentCard styles={cardStyles} onClickHref="/catalmacenes">
            <DocumentCardImage
              height={80}
              imageFit={1}
              iconProps={{
                iconName: "ProductCatalog",
                styles: {
                  root: {
                    color: Theme.palette.themePrimary,
                    fontSize: "80px",
                    width: "auto",
                    height: "auto",
                  },
                },
              }}
            />
            <DocumentCardDetails />
            <DocumentCardTitle
              styles={stylesf}
              title="Catalogo Almacenes"
              shouldTruncate
            />
          </DocumentCard> */}

          {/* <DocumentCard styles={cardStyles} onClickHref="/CatProved">
            <DocumentCardImage
              height={80}
              imageFit={1}
              iconProps={{
                iconName: "TextDocumentShared",
                styles: {
                  root: {
                    color: Theme.palette.themePrimary,
                    fontSize: "80px",
                    width: "auto",
                    height: "auto",
                  },
                },
              }}
            />
            <DocumentCardDetails />
            <DocumentCardTitle
              styles={stylesf}
              title="Catalogo Proveedores"
              shouldTruncate
            />
          </DocumentCard> */}

          {/* <DocumentCard styles={cardStyles} onClickHref="/Counter">
            <DocumentCardImage
              height={80}
              imageFit={1}
              iconProps={{
                iconName: "CPlusPlus",
                styles: {
                  root: {
                    color: Theme.palette.themePrimary,
                    fontSize: "80px",
                    width: "auto",
                    height: "auto",
                  },
                },
              }}
            />
            <DocumentCardDetails />
            <DocumentCardTitle styles={stylesf} title="Contador" shouldTruncate />
          </DocumentCard> */}

          {/* <DocumentCard styles={cardStyles} onClickHref="/Custom01">
            <DocumentCardImage
              height={80}
              imageFit={1}
              iconProps={{
                iconName: "Quantity",
                styles: {
                  root: {
                    color: Theme.palette.themePrimary,
                    fontSize: "80px",
                    width: "auto",
                    height: "auto",
                  },
                },
              }}
            />
            <DocumentCardDetails />
            <DocumentCardTitle
              styles={stylesf}
              title="Custom 01"
              shouldTruncate
            />
          </DocumentCard> */}

          {/* <DocumentCard styles={cardStyles} onClickHref="/FetchData">
            <DocumentCardImage
              height={80}
              imageFit={1}
              iconProps={{
                iconName: "Cloudy",
                styles: {
                  root: {
                    color: Theme.palette.themePrimary,
                    fontSize: "80px",
                    width: "auto",
                    height: "auto",
                  },
                },
              }}
            />
            <DocumentCardDetails />
            <DocumentCardTitle
              styles={stylesf}
              title="Pronostico del tiempo"
              shouldTruncate
            />
          </DocumentCard> */}

          <DocumentCard styles={cardStyles} onClickHref="/MyFiles">
            <DocumentCardImage
              height={65}
              imageFit={1}
              imageSrc={Images.reportsLogo}
              // iconProps={{
              //   iconName: "OneDriveFolder16",
              //   styles: {
              //     root: {
              //       color: Theme.palette.themePrimary,
              //       fontSize: "80px",
              //       width: "auto",
              //       height: "auto",
              //     },
              //   },
              // }}
            />
            <DocumentCardDetails />
            <DocumentCardTitle
              styles={stylesf}
              title="Reportes"
              shouldTruncate
            />
          </DocumentCard>

          {/* <DocumentCard styles={cardStyles} onClickHref="/Loading">
            <DocumentCardImage
              height={80}
              imageFit={1}
              iconProps={{
                iconName: "ProgressLoopOuter",
                styles: {
                  root: {
                    color: Theme.palette.themePrimary,
                    fontSize: "80px",
                    width: "auto",
                    height: "auto",
                  },
                },
              }}
            />
            <DocumentCardDetails />
            <DocumentCardTitle styles={stylesf} title="Loading" shouldTruncate />
          </DocumentCard> */}

          <DocumentCard styles={cardStyles} onClickHref="/onedrive">
            <DocumentCardImage
              height={65}
              imageFit={1}
              imageSrc={Images.onedriveLogo}
              // iconProps={{
              //   iconName: "OneDriveFolder16",
              //   styles: {
              //     root: {
              //       color: Theme.palette.themePrimary,
              //       fontSize: "65px",
              //       width: "auto",
              //       height: "auto",
              //     },
              //   },
              // }}
            />
            <DocumentCardDetails />
            <DocumentCardTitle
              styles={stylesf}
              title="One Drive"
              shouldTruncate
            />
          </DocumentCard>

          <DocumentCard styles={cardStyles} onClickHref="/MyFiles">
            <DocumentCardImage
              height={65}
              imageFit={1}
              imageSrc={Images.outlookLogo}
              // iconProps={{
              //   iconName: "OneDriveFolder16",
              //   styles: {
              //     root: {
              //       color: Theme.palette.themePrimary,
              //       fontSize: "65px",
              //       width: "auto",
              //       height: "auto",
              //     },
              //   },
              // }}
            />
            <DocumentCardDetails />
            <DocumentCardTitle
              styles={stylesf}
              title="Outlook"
              shouldTruncate
            />
          </DocumentCard>

          <DocumentCard styles={cardStyles} onClickHref="/MyFiles">
            <DocumentCardImage
              height={65}
              imageFit={1}
              imageSrc={Images.powerPointLogo}
              // iconProps={{
              //   iconName: "OneDriveFolder16",
              //   styles: {
              //     root: {
              //       color: Theme.palette.themePrimary,
              //       fontSize: "65px",
              //       width: "auto",
              //       height: "auto",
              //     },
              //   },
              // }}
            />
            <DocumentCardDetails />
            <DocumentCardTitle
              styles={stylesf}
              title="Power Point"
              shouldTruncate
            />
          </DocumentCard>

          <DocumentCard styles={cardStyles} onClickHref="/MyFiles">
            <DocumentCardImage
              height={65}
              imageFit={1}
              imageSrc={Images.wordLogo}
              // iconProps={{
              //   iconName: "OneDriveFolder16",
              //   styles: {
              //     root: {
              //       color: Theme.palette.themePrimary,
              //       fontSize: "65px",
              //       width: "auto",
              //       height: "auto",
              //     },
              //   },
              // }}
            />
            <DocumentCardDetails />
            <DocumentCardTitle
              styles={stylesf}
              title="Word"
              shouldTruncate
            />
          </DocumentCard>


          <DocumentCard styles={cardStyles} onClickHref="/MyFiles">
            <DocumentCardImage
              height={65}
              imageFit={1}
              imageSrc={Images.todoLogo}
              // iconProps={{
              //   iconName: "OneDriveFolder16",
              //   styles: {
              //     root: {
              //       color: Theme.palette.themePrimary,
              //       fontSize: "65px",
              //       width: "auto",
              //       height: "auto",
              //     },
              //   },
              // }}
            />
            <DocumentCardDetails />
            <DocumentCardTitle
              styles={stylesf}
              title="To Do"
              shouldTruncate
            />
          </DocumentCard>


          <DocumentCard styles={cardStyles} onClickHref="/MyFiles">
            <DocumentCardImage
              height={65}
              imageFit={1}
              imageSrc={Images.powerBiLogo}
              // iconProps={{
              //   iconName: "OneDriveFolder16",
              //   styles: {
              //     root: {
              //       color: Theme.palette.themePrimary,
              //       fontSize: "65px",
              //       width: "auto",
              //       height: "auto",
              //     },
              //   },
              // }}
            />
            <DocumentCardDetails />
            <DocumentCardTitle
              styles={stylesf}
              title="Power BI"
              shouldTruncate
            />
          </DocumentCard>

          <DocumentCard styles={cardStyles} onClickHref="/MyFiles">
            <DocumentCardImage
              height={65}
              imageFit={1}
              imageSrc={Images.teamsLogo}
              // iconProps={{
              //   iconName: "OneDriveFolder16",
              //   styles: {
              //     root: {
              //       color: Theme.palette.themePrimary,
              //       fontSize: "65px",
              //       width: "auto",
              //       height: "auto",
              //     },
              //   },
              // }}
            />
            <DocumentCardDetails />
            <DocumentCardTitle
              styles={stylesf}
              title="Teams"
              shouldTruncate
            />
          </DocumentCard>

          <DocumentCard styles={cardStyles} onClickHref="/MyFiles">
            <DocumentCardImage
              height={65}
              imageFit={1}
              imageSrc={Images.sharePointLogo}
              // iconProps={{
              //   iconName: "OneDriveFolder16",
              //   styles: {
              //     root: {
              //       color: Theme.palette.themePrimary,
              //       fontSize: "65px",
              //       width: "auto",
              //       height: "auto",
              //     },
              //   },
              // }}
            />
            <DocumentCardDetails />
            <DocumentCardTitle
              styles={stylesf}
              title="Share Point"
              shouldTruncate
            />
          </DocumentCard>

          <DocumentCard styles={cardStyles} onClickHref="/MyFiles">
            <DocumentCardImage
              height={65}
              imageFit={1}
              imageSrc={Images.excelLogo}
              // iconProps={{
              //   iconName: "OneDriveFolder16",
              //   styles: {
              //     root: {
              //       color: Theme.palette.themePrimary,
              //       fontSize: "65px",
              //       width: "auto",
              //       height: "auto",
              //     },
              //   },
              // }}
            />
            <DocumentCardDetails />
            <DocumentCardTitle
              styles={stylesf}
              title="Excel"
              shouldTruncate
            />
          </DocumentCard>

          {/* <DocumentCard styles={cardStyles} onClickHref="/ProgressIndicatorNav">
            <DocumentCardImage
              height={65}
              imageFit={1}
              iconProps={{
                iconName: "ProgressRingDots",
                styles: {
                  root: {
                    color: Theme.palette.themePrimary,
                    fontSize: "65px",
                    width: "auto",
                    height: "auto",
                  },
                },
              }}
            />
            <DocumentCardDetails />
            <DocumentCardTitle
              styles={stylesf}
              title="Indicador de progreso"
              shouldTruncate
            />
          </DocumentCard>

          <DocumentCard styles={cardStyles} onClickHref="/ShimmerCustom">
            <DocumentCardImage
              height={80}
              imageFit={1}
              iconProps={{
                iconName: "BuildDefinition",
                styles: {
                  root: {
                    color: Theme.palette.themePrimary,
                    fontSize: "80px",
                    width: "auto",
                    height: "auto",
                  },
                },
              }}
            />
            <DocumentCardDetails />
            <DocumentCardTitle styles={stylesf} title="Shimmer" shouldTruncate />
          </DocumentCard> */}
        </Stack>
      </Stack>
    );
  }
