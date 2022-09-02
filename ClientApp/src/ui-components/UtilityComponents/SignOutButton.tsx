import { useMsal } from "@azure/msal-react";
import {  ActionButton, IIconProps, Stack } from "@fluentui/react";

/**
 * Renders a sign-out button
 */


  
export const SignOutButton = () => {
    const { instance } = useMsal();

    
      const authIcon: IIconProps = { iconName: 'FollowUser' };
    const handleLogout = (logoutType: string) => {
        if (logoutType === "popup") {
            instance.logoutPopup({
                postLogoutRedirectUri: "/",
                mainWindowRedirectUri: "/"
            });
        } else if (logoutType === "redirect") {
            instance.logoutRedirect({
                postLogoutRedirectUri: "/",
            });
        }
    }

    return (
        <Stack horizontal horizontalAlign="end" tokens={{ childrenGap: 20 }}>
                {/* <PrimaryButton text="Cerrar Sesion" onClick={() => { handleLogout("popup") }} iconProps={authIcon}  allowDisabledFocus={true} title="Cerrar Sesion" /> */}
                <ActionButton text="Salir" onClick={() => { handleLogout("popup") }} iconProps={authIcon}  allowDisabledFocus={true} title="Cerrar Sesion"/>
        </Stack>
    );
}