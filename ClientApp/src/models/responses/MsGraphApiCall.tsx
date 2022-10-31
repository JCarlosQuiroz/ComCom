import { msalInstance } from "../..";
import { graphConfig, loginRequest } from "../../authConfig";

export async function callMsGraph() {

    const account = msalInstance.getActiveAccount();
    if (!account) {
        throw Error("Cuenta no activa, Verfique que su usuario es correcto");
    }

    const response = await msalInstance.acquireTokenSilent({
        ...loginRequest,
        account: account
    });
    const headers = new Headers();
    const bearer = `Bearer ${response.accessToken}`;
    headers.append("Authorization", bearer);

    const options = {
        method: "GET",
        headers: headers
    };

    return fetch(graphConfig.graphMeEndpoint, options)
        .then(response => response.json())
        .catch(error => console.log(error));
        
}