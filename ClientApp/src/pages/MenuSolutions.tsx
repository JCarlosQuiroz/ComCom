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
import { useHistory } from "react-router-dom";
import { Images, Theme } from "../styles/Theme";



  export default function MenuSolution(props: any) {
    const history = useHistory();
    const navigateTo = (path: string) => {
      history.push(path);
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
  
          <DocumentCard styles={cardStyles}
            onClick={() => navigateTo("/reportes")}
          >
            <DocumentCardImage
              height={65}
              imageFit={1}
              imageSrc={Images.reportsLogo}
            />
            <DocumentCardDetails />
            <DocumentCardTitle
              styles={stylesf}
              title="Reportes"
              shouldTruncate
            />
          </DocumentCard>




          <DocumentCard styles={cardStyles} 
            onClick={() => navigateTo("/forecast")}
          >
            <DocumentCardImage
              height={65}
              imageFit={1}
              imageSrc={Images.comcomlogo3}
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
              title="Forecast"
              shouldTruncate
            />
          </DocumentCard>
          <DocumentCard styles={cardStyles} 
            onClick={() => navigateTo("/onedrive")}
          >
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

          <DocumentCard styles={cardStyles} 
            onClick={() => navigateTo("/custom")}
          >
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

          <DocumentCard styles={cardStyles} onClick={() => navigateTo("/teams")}>
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
