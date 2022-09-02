import React from 'react';
import ReactDOM from 'react-dom';
import { BrowserRouter as Router } from "react-router-dom";


import App from './App';

// MSAL imports
import { PublicClientApplication, EventType, EventMessage, AuthenticationResult } from "@azure/msal-browser";
import { msalConfig } from "./authConfig";
import { getInitialResponsiveMode, initializeIcons, mergeStyles, ThemeProvider } from '@fluentui/react';
import { Theme } from './styles/Theme';

export const msalInstance = new PublicClientApplication(msalConfig);

// Account selection logic is app dependent. Adjust as needed for different use cases.
const accounts = msalInstance.getAllAccounts();
if (accounts.length > 0) {
    msalInstance.setActiveAccount(accounts[0]);
}

msalInstance.addEventCallback((event: EventMessage) => {
    if (event.eventType === EventType.LOGIN_SUCCESS && event.payload) {
        const payload = event.payload as AuthenticationResult;
        const account = payload.account;
        msalInstance.setActiveAccount(account);
    }
});
initializeIcons();
getInitialResponsiveMode();
mergeStyles({
    ':global(body,html,#root)': {
      margin: 0,
      padding: 0,
      height: '100vh',
    },
  });

ReactDOM.render(
    <Router>
        <ThemeProvider theme={Theme}>
            <App pca={msalInstance} />
        </ThemeProvider>
    </Router>,
    document.getElementById('root')
);
