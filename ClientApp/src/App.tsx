import React from 'react';
import { BrowserRouter, Route, Switch, useHistory } from "react-router-dom";
import { IImageProps } from "@fluentui/react";
import { IPublicClientApplication } from '@azure/msal-browser';
import { Images } from './styles/Theme';
import { CustomNavigationClient } from './utils/NavigationClient';
import { MsalProvider } from '@azure/msal-react';
import { PageLayout } from './pages/PageLayout';
import routes from './constants/RouteConfig';

export const imageProps: Partial<IImageProps> = {
  imageFit: 4,
  src: Images.comcomlogo,
  alt: "reactLogo",
  style: {
    position: "fixed",
    margin: "auto",
    marginTop: "150px",
    marginLeft: "auto",
    marginRight: "auto",
    display: "block",
    width: "auto",
    height: "auto",
    maxWidth: "100%",
    minWidth: "100%",
    transform: "translate(-50%, -50%)",
    border: "none",
    borderRadius: "0px",
    boxShadow: "none",
    backgroundColor: "transparent",
    backgroundRepeat: "no-repeat",
    backgroundPosition: "center",
    backgroundSize: "cover",
    opacity: "29%",
    filter: "none",
    WebkitFilter: "none",
    WebkitBackdropFilter: "none",
    WebkitMask: "none",
    WebkitMaskImage: "none",
    WebkitMaskPosition: "0% 0%",
    WebkitMaskRepeat: "no-repeat",
    WebkitMaskSize: "auto",
    WebkitMaskOrigin: "border-box",
    WebkitMaskBoxImage: "none",
    WebkitMaskBoxImageSource: "none",
    WebkitMaskBoxImageSlice: "0 fill",
    WebkitMaskBoxImageWidth: "0",
    WebkitMaskBoxImageRepeat: "stretch",
    WebkitMaskClip: "border-box",
    WebkitMaskComposite: "add",
    zIndex: "1",
  },
  // Show a border around the image (just for demonstration purposes)
  styles: (props: { theme: { palette: { themeDark: string } } }) => ({
    root: { border: "no border" + props.theme.palette.themeDark },
  }),
};

type AppProps = {
  pca: IPublicClientApplication;
};

export default function App({ pca }: AppProps) {
  const history = useHistory();
  const navigationClient = new CustomNavigationClient(history);
  pca.setNavigationClient(navigationClient);

  return (
    <React.Fragment>
    <MsalProvider instance={pca}>
      <BrowserRouter>
      <PageLayout />
        <Switch>
        {routes.map(route => 
          <Route key={route.path} path={route.path} exact={route.exact}>
            <route.component/>
          </Route>)}
        </Switch>
      </BrowserRouter>
    </MsalProvider>
    </React.Fragment>
  );
}