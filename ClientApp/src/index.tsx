import ReactDOM from 'react-dom';
import { BrowserRouter as Router } from "react-router-dom";

import App, { imageProps } from "./App";

import {
  PublicClientApplication,
  AuthenticationResult,
  EventMessage,
  EventType,
} from "@azure/msal-browser";

import { msalConfig } from "./authConfig";
import { getInitialResponsiveMode, initializeIcons, mergeStyles, ThemeProvider,Image } from '@fluentui/react';
// import { Theme } from 'assets/styles/Theme';
import * as serviceWorkerRegistration from './serviceWorkerRegistration';
import reportWebVitals from './reportWebVitals';
import { MsalProvider } from '@azure/msal-react';
import { Theme } from './styles/Theme';


export const msalInstance = new PublicClientApplication(msalConfig);
const rootElement = document.getElementById('root');
const baseUrl = document.getElementsByTagName('base')[0].getAttribute('href') || undefined;


const accounts = msalInstance.getAllAccounts();
if (accounts.length > 0) {
  msalInstance.setActiveAccount(accounts[0]);
}

msalInstance.addEventCallback((event: EventMessage) => {
  if(event.eventType === EventType.LOGIN_SUCCESS && event.payload) {
    const payload = event.payload as AuthenticationResult;
    const account = payload.account;
    msalInstance.setActiveAccount(account);
  }
});

initializeIcons();
getInitialResponsiveMode();
mergeStyles({':global(body,html,#root)': {
    margin: 0,
    padding: 0,
    minHeight: '100vh',
    minWidth: '100vw',
    maxHeight: '100vh',
    maxWidth: '100vw',
    backgroundColor: "transparent",
  },
});

ReactDOM.render(
    <Router basename={baseUrl}>
        <ThemeProvider theme={Theme} applyTo='body'>
        <Image {...imageProps} />
        <MsalProvider instance={msalInstance}>
        <App pca={msalInstance} />
        </MsalProvider>
        </ThemeProvider>
    </Router>,
    rootElement
  );

serviceWorkerRegistration.unregister();

reportWebVitals(
  (onPerfEntry: { name: any; }) => {
    if (onPerfEntry && onPerfEntry.name) {
      console.log(onPerfEntry.name);
    }
  }
);