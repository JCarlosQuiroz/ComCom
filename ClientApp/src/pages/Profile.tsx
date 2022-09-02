import { useEffect, useState } from "react";

// Msal imports
import {
  MsalAuthenticationTemplate,
  useIsAuthenticated,
  useMsal,
} from "@azure/msal-react";
import {
  InteractionStatus,
  InteractionType,
  InteractionRequiredAuthError,
  AccountInfo,
} from "@azure/msal-browser";
import { loginRequest } from "../authConfig";

// Sample app imports



import { callMsGraph } from "../utils/MsGraphApiCall";

// Material-ui imports
import { Callout, Link, Persona, PersonaCoin, Stack } from "@fluentui/react";

import { useBoolean, useId } from "@fluentui/react-hooks";

import { SignOutButton } from "../ui-components/UtilityComponents/SignOutButton";
import { Theme } from "../styles/Theme";
import {Loading} from "../ui-components/CustomTestComponents/Loading";
import { ErrorComponent } from "../ui-components/UtilityComponents/ErrorComponent";
import { GraphData } from "./ProfileData";
import { personaStyles, styles } from "./NavBar";
import { SignInButton } from "../ui-components/UtilityComponents/SignInButton";

export const ProfileContent = () => {
  const { instance, inProgress } = useMsal();
  const [graphData, setGraphData] = useState<null | GraphData>(null);

  useEffect(() => {
    if (!graphData && inProgress === InteractionStatus.None) {
      callMsGraph()
        .then((response) => setGraphData(response))
        .catch((e) => {
          if (e instanceof InteractionRequiredAuthError) {
            instance.acquireTokenRedirect({
              ...loginRequest,
              account: instance.getActiveAccount() as AccountInfo,
            });
          }
        });
    }
  }, [inProgress, graphData, instance]);

  return (
    // <Paper>
    //     { graphData ? <ProfileData graphData={graphData} /> : null }
    // </Paper>
    <Persona
      // imageUrl='https://graph.microsoft.com/v1.0/me/photo/$value'
      // imageInitials={graphData ? graphData.displayName.substring(0) : "?"}
      text={graphData ? graphData.displayName : "Loading..."}
      secondaryText={graphData ? graphData.jobTitle : ""}
      tertiaryText={graphData ? graphData.mail : ""}
      optionalText={graphData ? graphData.officeLocation : ""}
      hidePersonaDetails={false}
        coinSize={90}
      presence={2}
      styles={personaStyles}
    />
  );
};

export const PersonProfile = () => {
  const { instance, inProgress } = useMsal();
  const [graphData, setGraphData] = useState<null | GraphData>(null);
  const [isCalloutVisible, { toggle: toggleIsCalloutVisible }] =
    useBoolean(false);
  const buttonId = useId("callout-button");
  const labelId = useId("callout-label");
  const descriptionId = useId("callout-description");
  const isAuthenticated = useIsAuthenticated();
  useEffect(() => {
    if (!graphData && inProgress === InteractionStatus.None) {
      callMsGraph()
        .then((response) => setGraphData(response))
        .catch((e) => {
          if (e instanceof InteractionRequiredAuthError) {
            instance.acquireTokenRedirect({
              ...loginRequest,
              account: instance.getActiveAccount() as AccountInfo,
            });
          }
        });
    }
  }, [inProgress, graphData, instance]);

  return (
    <Persona
      // imageUrl={''}// imagen de perfil del usuario
      // imageInitials={''}// esto se renderiza en automatico con las iniciales en caso de no haber image
      // text={''}// agregar nombre de usuario
      // secondaryText={''} // agregar jobtitle o en su defecto el correo
      // tertiaryText={'Disponible'}// agregar parametro de disponibilidad
      // optionalText={'Disponible hasta las 6:00pm'} //Agregar paramatro de estatus de usuario
      // initialsColor={PersonaInitialsColor.purple}// color de iniciales si no hay imagen de usuario
      // size={PersonaSize.size40}//tamaño de persona en el commandbar
      // presence={PersonaPresence.online}// estatus del usuario agregar parametro de estatus
      // styles={personaStyles}// estilos de persona
      // imageUrl='https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/persona-'
      // imageInitials='AL'
      // text='Juan Perez'
      // secondaryText='Administrador'
      // tertiaryText='Disponible'
      // optionalText='Disponible hasta las 6:00pm'
      hidePersonaDetails={false}
      initialsColor={21}
      initialsTextColor={Theme.palette.white}
      presence={2}
      size={11}
      styles={{
        root: {
          position: "relative",
          display: "flex",
          alignItems: "center",
          height: "40px",
          width: "100%",
        },
      }}
      // theme={Theme}// tema de persona
      // hidePersonaDetails={true}// ocultar detalles de persona
      // imageAlt="UserProfileImage"// alt de imagen de persona
      // // componentRef?: IRefObject<IPersona>;
      onRenderPersonaCoin={() => {
        //   const WelcomeName = () => {
        //     const { accounts } = useMsal();
        //     const account = useAccount(accounts[0] || {});
        //     const [name, setName] = React.useState("");
        //     React.useEffect(() => {
        //       if (account && account.name) {
        //         setName(account.name);
        //       } else {
        //         setName("");
        //       }
        //     }, [account]);
        //     if (name) {
        //       return <Text variant="medium">Bienvenido, {name}</Text>;
        //     } else {
        //       return null;
        //     }
        //   };

        return (
          <Stack.Item>
            <PersonaCoin
              id={buttonId}
              onClick={toggleIsCalloutVisible}
              initialsColor={12}
              initialsTextColor={Theme.palette.white}
              text={graphData ? graphData.displayName : "Loading..."}
              secondaryText={graphData ? graphData.jobTitle : ""}
              tertiaryText={graphData ? graphData.mail : ""}
              optionalText={graphData ? graphData.officeLocation : ""}
              hidePersonaDetails={false}
              size={11}
              imageUrl={graphData ? graphData.photoUrl : "https://graph.microsoft.com/v1.0/me/photo/$value"
              }
              coinSize={36}
            />
            {isCalloutVisible && (
              <Callout
                className={styles.callout}
                ariaLabelledBy={labelId}
                ariaDescribedBy={descriptionId}
                role="dialog"
                gapSpace={0}
                target={`#${buttonId}`}
                onDismiss={toggleIsCalloutVisible}
                setInitialFocus={true}
              >
                <Stack.Item>
                  <ProfileContent />
                </Stack.Item>
                <p />
                <Stack.Item>
                  <Link
                    href="https://myaccount.microsoft.com/?ref=MeControl"
                    underline
                  >
                    Ver perfil
                  </Link>
                </Stack.Item>
                <p/>
                <Stack.Item>
                  <Link
                    href="https://myaccount.microsoft.com/?ref=MeControl"
                    underline
                  >
                    Mis Permisos
                  </Link>
                </Stack.Item>
                <Stack.Item>
                  {isAuthenticated ? <SignOutButton /> : <SignInButton />}
                </Stack.Item>
              </Callout>
            )}
          </Stack.Item>
        );
      }}
    />
  );
};

export function Profile() {
  const authRequest = {
    ...loginRequest,
  };

  return (
    <MsalAuthenticationTemplate
      interactionType={InteractionType.Redirect}
      authenticationRequest={authRequest}
      errorComponent={ErrorComponent}
      loadingComponent={Loading}
    >
      <ProfileContent />
    </MsalAuthenticationTemplate>
  );
}
