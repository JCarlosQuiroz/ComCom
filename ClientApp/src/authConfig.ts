import { Configuration, LogLevel } from "@azure/msal-browser";

// Config object to be passed to Msal on creation
export const msalConfig: Configuration = {
    auth: {
        clientId: "5c2132d6-850f-496f-9546-5fc27d5db1bd",
        authority: "https://login.microsoftonline.com/13a997af-eb34-44c3-8ea9-177642002dc6",
        knownAuthorities: ["https://login.microsoftonline.com/common"],
        redirectUri: "https://localhost:44441/",
        postLogoutRedirectUri: "https://comcombusinessapp.comcomindustries.onmicrosoft.com/?appproxy=logout",
        navigateToLoginRequestUrl: true,
    },
    cache: {
        cacheLocation: "sessionStorage",
        storeAuthStateInCookie: true,
        secureCookies: true,
    },
    system: {
        loggerOptions: {
            loggerCallback: (
                level: LogLevel,
                message: string,
                containsPii: boolean
                ): void => {
                if (containsPii) {
                    return;
                }
                switch (level) {
                    case LogLevel.Error:
                        console.error(message);
                        return;
                    case LogLevel.Info:
                        console.info(level, message);
                        return;
                    case LogLevel.Verbose:
                        console.debug(message);
                        return;
                    case LogLevel.Warning:
                        console.warn(message);
                        return;
                }
            },
            piiLoggingEnabled: false,
        },
        windowHashTimeout: 60000,
        iframeHashTimeout: 60000,
        loadFrameTimeout: 0,
    },
};

// Add here scopes for id token to be used at MS Identity Platform endpoints.
export const loginRequest = {
    scopes: ["User.Read"]
};

/**
  * Agregue aquí los alcances a solicitar al obtener un token de acceso para MS Graph API. Para más información, ver:
  * https://github.com/AzureAD/microsoft-authentication-library-for-js/blob/dev/lib/msal-browser/docs/resources-and-scopes.md
  */
export const graphConfig = {
    graphMeEndpoint: "https://graph.microsoft.com/v1.0/me",
};



// export const graphClient = MicrosoftGraph.Client.initWithMiddleware({ authProvider });
// //Get user info from Graph
// const async function getUser(accessToken: string) {
//     ensureScope('user.read');
//     return await graphClient
//         .api('/me')
//         .select('id,displayName')
//         .get();
// }