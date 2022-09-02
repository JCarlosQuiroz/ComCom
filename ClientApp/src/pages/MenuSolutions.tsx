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
import { Theme } from "../styles/Theme";


  
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
        marginRight: 20,
        marginBottom: 20,
        width: 100,
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
          padding: "10px 0px 0px 0px",
          childrenGap: "0%",
          maxHeight: "100%",
          maxWidth: "100%",
        }}
      >
        <Separator theme={Theme} styles={ISepStyles}>
          Utilidades y Servicios
        </Separator>
  
        <Stack
          horizontalAlign="center"
          verticalAlign="baseline"
          horizontal
          wrap
          tokens={{ padding: "0px 0px 0px 0px", childrenGap: 0 }}
        >
          {/* <DocumentCard
            aria-hidden={true}
            styles={cardStyles}
            onClickHref="/fetch-data"
          >
            <DocumentCardImage
              height={80}
              imageFit={ImageFit.centerContain}
              imageSrc={Images.contabilidad}
            />
            <DocumentCardDetails />
            <DocumentCardTitle
              styles={stylesf}
              title="Contabilidad"
              shouldTruncate
            />
          </DocumentCard>
  
          <DocumentCard styles={cardStyles} onClickHref="/counter">
            <DocumentCardImage
              height={80}
              imageFit={ImageFit.centerContain}
              imageSrc={Images.administracion}
            />
            <DocumentCardDetails />
            <DocumentCardTitle
              styles={stylesf}
              title="Administracion"
              shouldTruncate
            />
          </DocumentCard>
  
          <DocumentCard styles={cardStyles} onClickHref="/clientList/addclient">
            <DocumentCardImage
              height={80}
              imageFit={ImageFit.centerContain}
              imageSrc={Images.recursoshumanos}
            />
            <DocumentCardDetails />
            <DocumentCardTitle
              styles={stylesf}
              title="Recursos Humanos"
              shouldTruncate
            />
          </DocumentCard>
  
          <DocumentCard styles={cardStyles} onClickHref="/clientList/editclient">
            <DocumentCardImage
              height={80}
              imageFit={ImageFit.centerContain}
              imageSrc={Images.ventas}
            />
            <DocumentCardDetails />
            <DocumentCardTitle styles={stylesf} title="Ventas" shouldTruncate />
          </DocumentCard>
  
          <DocumentCard styles={cardStyles} onClickHref="/clientList/showclient">
            <DocumentCardImage
              height={80}
              imageFit={ImageFit.centerContain}
              imageSrc={Images.marketing}
            />
            <DocumentCardDetails />
            <DocumentCardTitle
              styles={stylesf}
              title="Marketing"
              shouldTruncate
            />
          </DocumentCard>
  
          <DocumentCard styles={cardStyles} onClickHref="/test6">
            <DocumentCardImage
              height={80}
              imageFit={ImageFit.centerContain}
              imageSrc={Images.ecommerce}
            />
            <DocumentCardDetails />
            <DocumentCardTitle
              styles={stylesf}
              title="Ecommerce"
              shouldTruncate
            />
          </DocumentCard>
  
          <DocumentCard styles={cardStyles} onClickHref="/test7">
            <DocumentCardImage
              height={80}
              imageFit={ImageFit.centerContain}
              imageSrc={Images.cuentasxcobrar}
            />
            <DocumentCardDetails />
            <DocumentCardTitle
              styles={stylesf}
              title="Credito y Cobranza"
              shouldTruncate
            />
          </DocumentCard>
  
          <DocumentCard styles={cardStyles} onClickHref="/test8">
            <DocumentCardImage
              height={80}
              imageFit={ImageFit.centerContain}
              imageSrc={Images.helpdesk}
            />
            <DocumentCardDetails />
            <DocumentCardTitle
              styles={stylesf}
              title="Help Desk"
              shouldTruncate
            />
          </DocumentCard>
  
          <DocumentCard styles={cardStyles} onClickHref="/zerodriveUI">
            <DocumentCardImage
              height={80}
              imageFit={ImageFit.centerContain}
              imageSrc={Images.finanzas}
            />
            <DocumentCardDetails />
            <DocumentCardTitle
              styles={stylesf}
              title="Finzanzas"
              shouldTruncate
            />
          </DocumentCard>
  
          <DocumentCard styles={cardStyles} onClickHref="/activeshare">
            <DocumentCardImage
              height={80}
              imageFit={ImageFit.centerContain}
              imageSrc={Images.logistica}
            />
            <DocumentCardDetails />
            <DocumentCardTitle
              styles={stylesf}
              title="Logistica"
              shouldTruncate
            />
          </DocumentCard>
  
          <DocumentCard styles={cardStyles} onClickHref="/almacen">
            <DocumentCardImage
              height={80}
              imageFit={ImageFit.centerContain}
              iconProps={{
                iconName: "Packages",
                styles: {
                  root: {
                    color: "#6a4d87",
                    fontSize: "80px",
                    width: "auto",
                    height: "auto",
                  },
                },
              }}
            />
            <DocumentCardDetails />
            <DocumentCardTitle styles={stylesf} title="Almacen" shouldTruncate />
          </DocumentCard>
  
          <DocumentCard styles={cardStyles} onClickHref="/activegroup">
            <DocumentCardImage
              height={80}
              imageFit={ImageFit.centerContain}
              iconProps={{
                iconName: "BankSolid",
                styles: {
                  root: {
                    color: "#6a4d87",
                    fontSize: "80px",
                    width: "auto",
                    height: "auto",
                  },
                },
              }}
            />
            <DocumentCardDetails />
            <DocumentCardTitle styles={stylesf} title="Bancos" shouldTruncate />
          </DocumentCard>
  
          <DocumentCard styles={cardStyles} onClickHref="/deactivegroup">
            <DocumentCardImage
              height={80}
              imageFit={ImageFit.centerContain}
              iconProps={{
                iconName: "ShopServer",
                styles: {
                  root: {
                    color: "#6a4d87",
                    fontSize: "80px",
                    width: "auto",
                    height: "auto",
                  },
                },
              }}
            />
            <DocumentCardDetails />
            <DocumentCardTitle styles={stylesf} title="Compras" shouldTruncate />
          </DocumentCard>
  
          <DocumentCard styles={cardStyles} onClickHref="/rapshow">
            <DocumentCardImage
              height={80}
              imageFit={ImageFit.centerContain}
              iconProps={{
                iconName: "Money",
                styles: {
                  root: {
                    color: "#6a4d87",
                    fontSize: "80px",
                    width: "auto",
                    height: "auto",
                  },
                },
              }}
            />
            <DocumentCardDetails />
            <DocumentCardTitle styles={stylesf} title="Costos" shouldTruncate />
          </DocumentCard>
  
          <DocumentCard styles={cardStyles} onClickHref="/empaque">
            <DocumentCardImage
              height={80}
              imageFit={ImageFit.centerContain}
              iconProps={{
                iconName: "Product",
                styles: {
                  root: {
                    color: "#6a4d87",
                    fontSize: "80px",
                    width: "auto",
                    height: "auto",
                  },
                },
              }}
            />
            <DocumentCardDetails />
            <DocumentCardTitle styles={stylesf} title="Empaque" shouldTruncate />
          </DocumentCard>
  
          <DocumentCard styles={cardStyles} onClickHref="/factspend">
            <DocumentCardImage
              height={80}
              imageFit={ImageFit.centerContain}
              iconProps={{
                iconName: "Feedback",
                styles: {
                  root: {
                    color: "#6a4d87",
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
              title="Recepcion"
              shouldTruncate
            />
          </DocumentCard>
  
          <DocumentCard styles={cardStyles} onClickHref="/carpetas">
            <DocumentCardImage
              height={80}
              imageFit={ImageFit.centerContain}
              iconProps={{
                iconName: "AuthenticatorApp",
                styles: {
                  root: {
                    color: "#6a4d87",
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
              title="Monitoreo y Seguridad"
              shouldTruncate
            />
          </DocumentCard>
  
          <DocumentCard styles={cardStyles} onClickHref="/almacen">
            <DocumentCardImage
              height={80}
              imageFit={ImageFit.centerContain}
              iconProps={{
                iconName: "ManagerSelfService",
                styles: {
                  root: {
                    color: "#6a4d87",
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
              title="Servicios"
              shouldTruncate
            />
          </DocumentCard> */}
  
          <DocumentCard styles={cardStyles} onClickHref="/catalmacenes">
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
          </DocumentCard>
  
          <DocumentCard styles={cardStyles} onClickHref="/CatProved">
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
          </DocumentCard>
  
          <DocumentCard styles={cardStyles} onClickHref="/Counter">
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
          </DocumentCard>
  
          <DocumentCard styles={cardStyles} onClickHref="/Custom01">
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
          </DocumentCard>
  
          <DocumentCard styles={cardStyles} onClickHref="/FetchData">
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
          </DocumentCard>
  
          <DocumentCard styles={cardStyles} onClickHref="/Loading">
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
          </DocumentCard>
  
          <DocumentCard styles={cardStyles} onClickHref="/MyFiles">
            <DocumentCardImage
              height={80}
              imageFit={1}
              iconProps={{
                iconName: "OneDriveFolder16",
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
              title="One Drive"
              shouldTruncate
            />
          </DocumentCard>
  
          <DocumentCard styles={cardStyles} onClickHref="/ProgressIndicatorNav">
            <DocumentCardImage
              height={80}
              imageFit={1}
              iconProps={{
                iconName: "ProgressRingDots",
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
          </DocumentCard>
        </Stack>
      </Stack>
    );
  }
  