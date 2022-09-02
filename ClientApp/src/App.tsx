import { BrowserRouter, Route, Switch, useHistory } from "react-router-dom";
import { Image } from "@fluentui/react";
import * as React from 'react';

// MSAL imports
import { MsalProvider } from "@azure/msal-react";
import { IPublicClientApplication } from "@azure/msal-browser";
import { CustomNavigationClient } from "./utils/NavigationClient";

// Sample app imports

import { IImageProps } from "@fluentui/react";

import routes from "./constants/RouteConfig";
import { PageLayout } from "./pages/PageLayout";
import { Images } from "./styles/Theme";

type AppProps = {
  pca: IPublicClientApplication;
};

export const imageProps: Partial<IImageProps> = {
  imageFit: 4,
  src: Images.comcomlogo,
  alt: "Logotipo Valhpac Horizontal",
  style: {
    position: "fixed",
    margin: "auto",
    marginTop: "50px",
    marginLeft: "auto",
    marginRight: "auto",
    display: "block",
    width: "auto",
    height: "auto",
    maxWidth: "100%",
    minWidth: "50%",
    transform: "translate(-50%, -50%)",
    border: "none",
    borderRadius: "0px",
    boxShadow: "none",
    backgroundColor: "transparent",
    backgroundRepeat: "no-repeat",
    backgroundPosition: "center",
    backgroundSize: "cover",
    opacity: "20%",
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



export default function App({ pca }: AppProps) {
  // The next 3 lines are optional. This is how you configure MSAL to take advantage of the router's navigate functions when MSAL redirects between pages in your app
  const history = useHistory();
  const navigationClient = new CustomNavigationClient(history);
  pca.setNavigationClient(navigationClient);

  return (
    <React.Fragment>
    {/* <MsalProvider instance={pca}> */}
      <BrowserRouter>
      <PageLayout />
      <Image {...imageProps} />
        <Switch>
        {routes.map(route => 
          <Route key={route.path} path={route.path} exact={route.exact}>
            <route.component/>
          </Route>)}
        </Switch>
      </BrowserRouter>
    {/* </MsalProvider> */}
    </React.Fragment>
  );
}











