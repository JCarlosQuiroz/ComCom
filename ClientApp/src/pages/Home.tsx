import {
  AuthenticatedTemplate,
  UnauthenticatedTemplate,
  useIsAuthenticated,
} from "@azure/msal-react";
import {
  DocumentCard,
  DocumentCardDetails,
  DocumentCardImage,
  DocumentCardTitle,
  IDocumentCardStyles,
  Stack,
} from "@fluentui/react";

import { Images } from "../styles/Theme";
import WelcomeName from "../ui-components/CustomTestComponents/WelcomeName";
import { MainMenu } from "../ui-components/MainMenu";


// import MainMenu from "../ui-components/MainMenu";
import { SignInButton } from "../ui-components/UtilityComponents/SignInButton";
import { SignOutButton } from "../ui-components/UtilityComponents/SignOutButton";
import { AvatarUser } from "./AvatarUser";
import CardsSection from "./CardsSection";
import { DocumentsLists } from "./DocumentsLists";
import HeaderNav from "./HeaderNav";
import MenuSolution from "./MenuSolutions";
import SideNav from "./SideNav";

export function Home() {
  const isAuthenticated = useIsAuthenticated();
  const cardStyles: IDocumentCardStyles = {
    root: {
      textAlign: "center",
      margin: "auto",
      marginTop: "50px",
      width: "100%",
      maxWidth: "500px",
    },
  };

  return (
    <>
        <AuthenticatedTemplate>
          <WelcomeName/>
          <MenuSolution/>
          <AvatarUser/>
          {/* <HeaderNav/>
          <DocumentsLists/>
          <CardsSection/>
          <SideNav/>
          // <AvatarUser/> */}
        {/* <MainMenu/> */}
        </AuthenticatedTemplate>

      <UnauthenticatedTemplate>
        <Stack
          horizontal
          wrap
          tokens={{ padding: "0px 0px 0px 30px", childrenGap: 10 }}
        >

          <DocumentCard styles={cardStyles}>
            <DocumentCardImage
              height={250}
              width={500}
              imageFit={1}
              imageSrc={Images.comcomlogo}
            />
            <DocumentCardDetails 
              styles={{
                root: {
                  width: "100%",
                  maxWidth: "500px",
                },
              }}
            >
              <DocumentCardTitle
                title="Porfavor ingrese sus credenciales para acceder a la aplicaci??n."
                shouldTruncate
              />
            <Stack.Item grow>
            {isAuthenticated ? <SignOutButton /> : <SignInButton />}
            </Stack.Item>
            </DocumentCardDetails>
          </DocumentCard>
        </Stack>
      </UnauthenticatedTemplate>
    </>
  );
}