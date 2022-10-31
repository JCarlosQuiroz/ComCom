import { InteractionRequiredAuthError, InteractionStatus, InteractionType } from "@azure/msal-browser";
import {
  MsalAuthenticationTemplate,
  useMsal,
} from "@azure/msal-react";
import {
  Callout,
  ContextualMenu,
  IconButton,
  IContextualMenuProps,
  Image,
  IPersonaCoinStyles,
  Persona,
  PersonaCoin,
  PersonaSize,
  Stack,
  Text,
} from "@fluentui/react";
import { useBoolean, useId } from "@fluentui/react-hooks";
import { useState, useEffect } from "react";
import { loginRequest } from "../authConfig";
import { GraphData } from "../models/GraphData";
import { callMsGraph } from "../models/responses/MsGraphApiCall";
import { Images, Theme } from "../styles/Theme";
import { Loading } from "../ui-components/CustomTestComponents/Loading";
import { ErrorComponent } from "../ui-components/UtilityComponents/ErrorComponent";
import { personaStyles, styles } from "./NavBar";





/**
 * Renders information about the user obtained from MS Graph
 * @param props
 */

 const personaCoinStyles: Partial<IPersonaCoinStyles> = {
  coin: {
    width: 50,
  },
};

export const NavBarProfile = () => {
  const { instance, inProgress } = useMsal();
  const [graphData, setGraphData] = useState<null | GraphData>(null);
  const [graphPhoto,setGraphPhoto] = useState<null | string>(null);
  const [isCalloutVisible, { toggle: toggleIsCalloutVisible }] = useBoolean(false);
  const buttonId = useId("callout-button");
  const labelId = useId("callout-label");
  const descriptionId = useId("callout-description");
  
  // async componentDidMount(){
  //   const res = await axios.get(urlClientes);
  //   this.setState({items: res.data});
  //   console.log(res.data);
  // }

  useEffect(() => {
    if (!graphData && inProgress === InteractionStatus.None) {
      callMsGraph() 
        .then((response) => setGraphData(response))
        .catch(async (e) => {
          if (e instanceof InteractionRequiredAuthError) {
           await instance.acquireTokenRedirect({
              ...loginRequest,
              account: instance.getAllAccounts()[0],
            });
          }
        });
    }
  }, [inProgress, graphData, instance]);

  useEffect(() => {
    const getPhoto = async () => {
      const tokenPhoto = await instance.acquireTokenSilent({
        ...loginRequest,
        account: instance.getAllAccounts()[0],
      });
      const headers = new Headers();
      const bearer = `Bearer ${tokenPhoto.accessToken}`;
      headers.append("Authorization", bearer);

      const options = {
        method: "GET",
        headers: headers,       
    };
    const response = await fetch("https://graph.microsoft.com/v1.0/me/photo/$value", options);
    const blob = await response.blob();
    const url = URL.createObjectURL(blob);

    setGraphPhoto(url);
    }
    getPhoto();
  }, [instance]);

  const menuProps: IContextualMenuProps = {
    items: [
      {
        key: "account",
        text: "Ver mi cuenta",
        iconProps: { iconName: "CRMServices" },
        onClick: () => {
          window.location.href = "https://myaccount.microsoft.com/?ref=MeControl";
        },

      },
      {
        key: "config",
        text: "Configuracion y Privacidad",
        iconProps: { iconName: "Settings" },
        onClick: () => {
          window.location.href = "https://myaccount.microsoft.com/settingsandprivacy";
        }
      },
      {
        key: "logout",
        text: "Salir",
        iconProps: { iconName: "FollowUser" },
        onClick: () => {
            instance.logoutRedirect();
        },
      },
    ],
    directionalHintFixed: true,
  };
  return (
    <Stack.Item>
      <PersonaCoin
        id={buttonId}
        onClick={toggleIsCalloutVisible}
        initialsColor={Theme.palette.themeDark}
        initialsTextColor={Theme.palette.white}
        presence={2}
        imageInitials={graphData ? graphData.displayName[0] : ""}
        imageUrl={graphPhoto ? graphPhoto : undefined}
        coinSize={36}
        styles={personaCoinStyles}
      />
      {isCalloutVisible && (
        <Callout
          className={styles.callout}
          styles={{
            root: {
              width: 380,
              height: 200,
              padding: 10,
              borderRadius: 50,
              boxShadow: "0 0 20px rgba(0.6, 0.6, 0.6, 0.6)",
              zIndex: 1000,
            },
          }}
          ariaLabelledBy={labelId}
          ariaDescribedBy={descriptionId}
          role="dialog"
          gapSpace={0}
          target={`#${buttonId}`}
          onDismiss={toggleIsCalloutVisible}
          setInitialFocus={true}
        >
          <Stack>
          <Stack tokens={{ childrenGap: 8 }} horizontal horizontalAlign="space-between">
          <Image
            src={Images.navbarLogo}
            width={80}
            height={35}
            alt="Logo"
            // styles={{ root: { borderRadius: 50 } }}
            />

          {/* <Persona
            imageUrl={Images.navbarLogo}
            imageInitials=""
            text="React Template®"
            size={PersonaSize.size32}
            hidePersonaDetails={true}
            styles={{
              root: {
                backgroundColor: "transparent",
                color: Theme.palette.themeTertiary,
                fontSize: 12,
                fontWeight: "bold",
                height: 38,
                marginLeft: 8,
                minHeight: 38,
                maxHeight: 38,
                lineHeight: 38,
                textAlign: "center",
              },
            }}
          /> */}
          <Text
              styles={{
                root: {
                  fontSize: 16,
                  fontWeight: 600,
                  color: Theme.palette.themePrimary,
                  padding: 10,
                },
              }}
            >
              {graphData && graphData.officeLocation
                ? graphData.officeLocation
                : "Sin Asignacion"}
          </Text>
          </Stack>
          <Stack>
            <Stack >
              <Persona
                hidePersonaDetails={false}
                initialsColor={Theme.palette.themePrimary}
                imageUrl={graphPhoto ? graphPhoto : undefined}
                text={graphData ? graphData.displayName : ""}
                presence={2}
                secondaryText={
                  graphData && graphData.jobTitle
                    ? graphData.jobTitle
                    : "No tiene puesto asignado"
                }
                tertiaryText={
                  graphData && graphData.mail
                    ? graphData.mail
                    : "No tiene correo asignado"
                }
                size={PersonaSize.size100}
                styles={personaStyles}
              />
            </Stack>
          </Stack>
          <Stack tokens={{ childrenGap: 8 }} horizontal horizontalAlign="end">
            <IconButton
              iconProps={{
                iconName: "Encryption",
                styles: {
                  root: {
                    backgroundColor: Theme.palette.white,
                    color: Theme.palette.themePrimary,
                    fontSize: 26,
                    padding: 7,
                    borderRadius: 48,
                    border: "1px solid Theme.palette.themePrimary",
                  },
                },
              }}
              styles={{
                root: {
                  backgroundColor: Theme.palette.white,
                  color: Theme.palette.white,
                  borderRadius: 48,
                  padding: 7,
                },
                rootHovered: {
                  backgroundColor: Theme.palette.white,
                  width: 80,
                  color: Theme.palette.themePrimary,
                  borderRadius: 48,
                  borderColor: Theme.palette.neutralTertiary,
                  borderStyle: "solid",
                  transition: "all 0.5s ease-in-out",
                  ":hover": {
                    TransformStream: "scale(1.2)",
                    borderColor: Theme.palette.themePrimary,
                  },
                  cursor: "pointer",
                },
                rootPressed: {
                  backgroundColor: Theme.palette.white,
                  color: Theme.palette.white,
                  borderColor: Theme.palette.neutralTertiary,
                  borderRadius: 48,
                  padding: 7,
                },
                iconPressed: {
                  color: Theme.palette.themePrimary,
                  fontSize: "1em",
                  animationIterationCount: "1",
                  animationDuration: "0.1s",
                  textAlign: "center",
                  cursor: "pointer",
                  outline: "none",
                  boxShadow: "none",

                  ":hover": {
                    TransformStream: "scale(1em, 1em)",
                    borderColor: Theme.palette.themePrimary,
                    borderRadius: 48,
                  },
                },
              }}
              menuProps={menuProps}
              menuAs={_getMenu}
              persistMenu={true}
              allowDisabledFocus
            />
          </Stack>

          </Stack>
        </Callout>
      )}
    </Stack.Item>
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
    ></MsalAuthenticationTemplate>
  );
}
function _getMenu(props: IContextualMenuProps): JSX.Element {
  return <ContextualMenu {...props} />;
}