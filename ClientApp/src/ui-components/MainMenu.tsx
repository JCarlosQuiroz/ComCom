import {
  Stack,
  Separator,
  ImageIcon,
  IImageProps,
  DocumentCard,
  DocumentCardActivity,
  DocumentCardDetails,
  DocumentCardTitle,
  IDocumentCardActivityPerson,
  IDocumentCardStyles,
} from "@fluentui/react";
import { Images, ISepStyles, Theme } from "../styles/Theme";
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
    display: "inline-block",
    marginRight: 20,
    marginBottom: 20,
    width: 320,
  },
};

// function documentLinks(props: IButtonProps) {
//   return (
//     <NavLink
//       to="/empaque"
//       style={{
//         textDecoration: "none",
//         color: "#00a54f",
//         fontSize: "20px",
//         fontWeight: "300",
//         fontStyle: "normal",
//         textAlign: "center",
//         display: "inline-block",
//         marginLeft: "38px",
//         justifyContent: "center",
//         alignItems: "center",
//       }}
//       role="link"
//     >
//       Empaque
//     </NavLink>
//   );
// }

export const MainMenu = () => {
  const history = useHistory();
  const navigateTo = (path: string) => {
    history.push(path);
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
        Menu Principal
      </Separator>
      {/* <WelcomeName/> */}
      <Stack
        horizontalAlign="center"
        verticalAlign="baseline"
        horizontal
        wrap
        tokens={{ padding: "0px 0px 0px 0px", childrenGap: 0 }}
      >
        {/* <NavLink to="/">
          <PrimaryButton>
            <Icon iconName="Home" />
            Home
          </PrimaryButton>
        </NavLink>
        <NavLink to="/about">
          <PrimaryButton>
            <Icon iconName="Info" />
            About
          </PrimaryButton>
        </NavLink>
        <NavLink to="/contact">
          <PrimaryButton>
            <Icon iconName="ContactInfo" />
            Contact
          </PrimaryButton>
        </NavLink>

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
        <ImageIcon
          imageProps={{
            src: Images.helpdesk,
            alt: "solutions",
            imageFit: 1,
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
          title="Soporte Tecnico"
        />
        <ImageIcon
          imageProps={{
            src: Images.recursoshumanos,
            alt: "solutions",
            imageFit: 1,
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
        <ImageIcon
          imageProps={{
            src: Images.ventas,
            alt: "solutions",
            imageFit: 1,
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

        <ImageIcon
          imageProps={{
            src: Images.metodosdepago,
            alt: "solutions",
            imageFit: 1,
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
        /> */}
      </Stack>


      <Stack
        horizontalAlign="center"
        horizontal
        wrap
        tokens={{ padding: "0px 0px 0px 0px", childrenGap: 20 }}
      >
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
              shouldTruncate
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
              shouldTruncate
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
              shouldTruncate
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
              shouldTruncate
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
              shouldTruncate
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
              shouldTruncate
            />
          </DocumentCardDetails>
          <DocumentCardActivity
            activity="Modificado el 13 de marzo de 2018"
            people={people.slice(0, 3)}
          />
        </DocumentCard>

        {/* <div>
             <Persona
               imageUrl={Images.profileUser}
               imageInitials=""
               text=""
               size={PersonaSize.size40}
               hidePersonaDetails={false}
               presence={1}
             />
         </div> */}
      </Stack>
    </Stack>
  );
};
export default MainMenu;
