import { useMsal } from "@azure/msal-react";

import { IIconProps, PrimaryButton, Stack } from "@fluentui/react";
import { loginRequest } from "../../authConfig";


const authIcon: IIconProps = { iconName: 'AuthenticatorApp' };

export const SignInButton = () => {
    const { instance } = useMsal();

    const handleLogin = (loginType: string) => {
        if (loginType === "popup") {
            instance.loginPopup(loginRequest).catch((e: any) => {
                console.log(e);
            });
        } else if (loginType === "redirect") {
            instance.loginRedirect(loginRequest).catch((e: any) => {
                console.log(e);
            });
        }
    }
    return (
        <Stack horizontal horizontalAlign="center">
            <PrimaryButton text="Iniciar Sesion" onClick={() => { handleLogin("popup") }} iconProps={authIcon} allowDisabledFocus={true} />
        </Stack>
    )
}