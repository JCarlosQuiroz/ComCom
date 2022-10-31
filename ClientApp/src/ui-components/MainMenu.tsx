import {
  ImageIcon,
  IImageProps,
  DocumentCard,
  DocumentCardActivity,
  DocumentCardDetails,
  DocumentCardTitle,
  IDocumentCardActivityPerson,
  IDocumentCardStyles,
  Stack,
  IStackStyles,
  IStackTokens,
} from "@fluentui/react";
import { Images, Theme } from "../styles/Theme";
import { useHistory } from "react-router-dom";

const stylesImg: Partial<IImageProps> = {
  styles: {
    root: {
      
      width: "150px",
      height: "150px",
      display: "flex",
      marginTop: "0px",
      marginRight: "0px",
      marginLeft: "78px",
      justifyContent: "center",
      alignItems: "center",
      borderRadius: "50%",
      borderColor: Theme.palette.neutralPrimary,
      borderWidth: "2x",
      borderStyle: "solid",
      transition: "all 0.2s ease-in-out",
      ":hover": {
        transform: "scale(0.9, 0.9)",
        borderColor: Theme.palette.themePrimary,
      },
    },
  },
};

const people: IDocumentCardActivityPerson[] = [
  {
    name: "Annie Lindqvist",
    profileImageSrc: Images.profileUser,
    initials: "AL",
  },
  { name: "Roko Kolar", profileImageSrc: "", initials: "RK" },
  { name: "Aaron Reid", profileImageSrc: Images.profileUser },
  { name: "Christian Bergqvist", profileImageSrc: "", initials: "CB" },
];

const cardStyles: IDocumentCardStyles = {
  root: {
    marginRight: 20,
    marginBottom: 20,
    width: 320,
  },
};
export const stackTokens: IStackTokens = { childrenGap: 15 };
export const stackStyles: Partial<IStackStyles> = {
    root: {
      background: Theme.palette.neutralLighter,
      height: "100%",
      width: "100%",
      overflow: "hidden",
      maxHeight: "100vh",
      maxWidth: "100vw",
      // margin: '0px 0px',
      // textAlign: 'center',
      // color: '#605e5c',
      selectors: {
        p: { margin: "14px 100px" },
        a: { color: "#0078d4" },
        "a:hover": { textDecoration: "underline" },
        "p:hover": { textAlign: "center" },
      },
    },
  };
export const MainMenu = () => {
  const history = useHistory();
  const navigateTo = (path: string) => {
    history.push(path);
  };
  return (
    
<Stack  horizontalAlign="center" tokens={stackTokens} styles={stackStyles} >
    <DocumentCard
          aria-label={
            "Documento Tarjeta con imagen. Cómo hacer un buen diseño." +
            "Modificado por última vez por Annie Lindqvist y otras 2 personas el 13 de marzo de 2018."
          }
          styles={cardStyles}

          role="link"
        >
        <ImageIcon
          onClick={() => navigateTo("/dashboard")}
          imageProps={{
            imageFit: 1,
            src: Images.contabilidad,
            alt: "solutions",
            styles: stylesImg.styles,
            style: {
              position: "static",
              width: "110px",
              height: "110px",
              backgroundRepeat: "no-repeat",
              backgroundPosition: "center",
              backgroundSize: "cover",
              cursor: "pointer",
            },
          }}
          title="Contabilidad"
        />
          <DocumentCardDetails>
            <DocumentCardTitle
              title="Contabilidad"
              styles={{
                root: {
                  fontSize: "20px",
                  fontWeight: "300",
                  fontStyle: "normal",
                  color: Theme.palette.themePrimary,
                  textAlign: "center",
                },
              }}
            />
          </DocumentCardDetails>
          <DocumentCardActivity
            activity="Modificado el 13 de marzo de 2018"
            people={people.slice(0, 3)}
          />
        </DocumentCard>

        <DocumentCard
          aria-label={
            "Documento Tarjeta con imagen. Cómo hacer un buen diseño." +
            "Modificado por última vez por Annie Lindqvist y otras 2 personas el 13 de marzo de 2018."
          }
          styles={cardStyles}

          role="link"
        >
        <ImageIcon
          onClick={() => navigateTo("/dashboard")}
          imageProps={{
            imageFit: 1,
            src: Images.helpdesk,
            alt: "solutions",
            styles: stylesImg.styles,
            style: {
              position: "static",
              width: "110px",
              height: "110px",
              backgroundRepeat: "no-repeat",
              backgroundPosition: "center",
              backgroundSize: "cover",
              cursor: "pointer",
            },
          }}
          title="Contabilidad"
        />
          <DocumentCardDetails>
            <DocumentCardTitle
              title="Soporte Tecnico"
              styles={{
                root: {
                  fontSize: "20px",
                  fontWeight: "300",
                  fontStyle: "normal",
                  color: Theme.palette.themePrimary,
                  textAlign: "center",
                },
              }}

            />
          </DocumentCardDetails>
          <DocumentCardActivity
            activity="Modificado el 13 de marzo de 2018"
            people={people.slice(0, 3)}
          />
        </DocumentCard>

        <DocumentCard
          aria-label={
            "Documento Tarjeta con imagen. Cómo hacer un buen diseño." +
            "Modificado por última vez por Annie Lindqvist y otras 2 personas el 13 de marzo de 2018."
          }
          styles={cardStyles}

          role="link"
        >
        <ImageIcon
          onClick={() => navigateTo("/dashboard")}
          imageProps={{
            imageFit: 1,
            src: Images.metodosdepago,
            alt: "solutions",
            styles: stylesImg.styles,
            style: {
              position: "static",
              width: "110px",
              height: "110px",
              backgroundRepeat: "no-repeat",
              backgroundPosition: "center",
              backgroundSize: "cover",
              cursor: "pointer",
            },
          }}
          title="Pagos en Linea"
        />
          <DocumentCardDetails>
            <DocumentCardTitle
              title="Pagos en Linea"
              styles={{
                root: {
                  fontSize: "20px",
                  fontWeight: "300",
                  fontStyle: "normal",
                  color: Theme.palette.themePrimary,
                  textAlign: "center",
                },
              }}
            />
          </DocumentCardDetails>
          <DocumentCardActivity
            activity="Modificado el 13 de marzo de 2018"
            people={people.slice(0, 3)}
          />
        </DocumentCard>


        <DocumentCard
          aria-label={
            "Documento Tarjeta con imagen. Cómo hacer un buen diseño." +
            "Modificado por última vez por Annie Lindqvist y otras 2 personas el 13 de marzo de 2018."
          }
          styles={cardStyles}

          role="link"
        >
        <ImageIcon
          onClick={() => navigateTo("/dashboard")}
          imageProps={{
            imageFit: 1,
            src: Images.ventas,
            alt: "solutions",
            styles: stylesImg.styles,
            style: {
              position: "static",
              width: "110px",
              height: "110px",
              backgroundRepeat: "no-repeat",
              backgroundPosition: "center",
              backgroundSize: "cover",
              cursor: "pointer",
            },
          }}
          title="Ventas"
        />
          <DocumentCardDetails>
            <DocumentCardTitle
              title="Ventas"
              styles={{
                root: {
                  fontSize: "20px",
                  fontWeight: "300",
                  fontStyle: "normal",
                  color: Theme.palette.themePrimary,
                  textAlign: "center",
                },
              }}
              
            />
          </DocumentCardDetails>
          <DocumentCardActivity
            activity="Modificado el 13 de marzo de 2018"
            people={people.slice(0, 3)}
          />
        </DocumentCard>

        
        <DocumentCard
          aria-label={
            "Documento Tarjeta con imagen. Cómo hacer un buen diseño." +
            "Modificado por última vez por Annie Lindqvist y otras 2 personas el 13 de marzo de 2018."
          }
          styles={cardStyles}

          role="link"
        >
        <ImageIcon
          onClick={() => navigateTo("/dashboard")}
          imageProps={{
            imageFit: 1,
            src: Images.recursoshumanos,
            alt: "solutions",
            styles: stylesImg.styles,
            style: {
              position: "static",
              width: "110px",
              height: "110px",
              backgroundRepeat: "no-repeat",
              backgroundPosition: "center",
              backgroundSize: "cover",
              cursor: "pointer",
            },
          }}
          title="Recursos Humanos"
        />
          <DocumentCardDetails>
            <DocumentCardTitle
              title="Recursos Humanos"
              styles={{
                root: {
                  fontSize: "20px",
                  fontWeight: "300",
                  fontStyle: "normal",
                  color: Theme.palette.themePrimary,
                  textAlign: "center",
                },
              }}
            />
          </DocumentCardDetails>
          <DocumentCardActivity
            activity="Modificado el 13 de marzo de 2018"
            people={people.slice(0, 3)}
          />
        </DocumentCard>

        <DocumentCard
          styles={cardStyles}
          role="link"
        >
        <ImageIcon
          onClick={() => navigateTo("/users")}
          imageProps={{
            imageFit: 1,
            src: Images.administracion,
            alt: "solutions",
            styles: stylesImg.styles,
            style: {
              position: "static",
              width: "110px",
              height: "110px",
              backgroundRepeat: "no-repeat",
              backgroundPosition: "center",
              backgroundSize: "cover",
              cursor: "pointer",
            },
          }}
          title="Usuarios"
        />
          <DocumentCardDetails>
            <DocumentCardTitle
              title="Contabilidad"
              styles={{
                root: {
                  fontSize: "20px",
                  fontWeight: "300",
                  fontStyle: "normal",
                  color: Theme.palette.themePrimary,
                  textAlign: "center",
                },
              }}

            />
          </DocumentCardDetails>
          <DocumentCardActivity
            activity="Modificado el 13 de marzo de 2018"
            people={people.slice(0, 3)}
          />
        </DocumentCard>
        </Stack>
  );
};

