import { MsalAuthenticationResult } from "@azure/msal-react";


export const ErrorComponent: React.FunctionComponent<MsalAuthenticationResult> = ({ error }) => {
    return (
        <div id="error-div">
            <p><strong>Ah ocurrido un error: </strong> {error ? error.errorCode: "Error Desconocido"}</p>
        </div>
    );
}

export default ErrorComponent;



