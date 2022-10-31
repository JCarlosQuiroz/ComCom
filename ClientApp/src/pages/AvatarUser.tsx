import * as React from 'react';
import { IPersonaSharedProps, Persona, PersonaSize, PersonaPresence } from '@fluentui/react/lib/Persona';
import { Checkbox } from '@fluentui/react/lib/Checkbox';
import { Label } from '@fluentui/react/lib/Label';
import { Stack } from '@fluentui/react/lib/Stack';
import { GraphData } from '../modules/core/domain/models/GraphData';
import { callMsGraph } from '../models/responses/MsGraphApiCall';
import { useMsal } from '@azure/msal-react';
import { InteractionRequiredAuthError, InteractionStatus } from '@azure/msal-browser';
import { loginRequest } from '../authConfig';
import { Shimmer } from '@fluentui/react';
import { useBoolean } from '@fluentui/react-hooks';


export const AvatarUser: React.FunctionComponent = () => {
  const { instance, inProgress } = useMsal();
  // const [renderDetails, updateRenderDetails] = React.useState(true);
  const [graphData, setGraphData] = React.useState<null | GraphData>(null);
  const [graphPhoto, setGraphPhoto] = React.useState<string>("");
  const [isLoading, setLoading] = useBoolean(false);

  React.useEffect(() => {
    if (!graphData && inProgress === InteractionStatus.None) {
      callMsGraph() 
        .then((response) => setGraphData(response))
        .catch(async (e) => {
          if (e instanceof InteractionRequiredAuthError) {
           await instance.acquireTokenRedirect({
              ...loginRequest,
              account: instance.getAllAccounts()[0],
            });
          }
        });
    }
  }, [inProgress, graphData, instance]);

  React.useEffect(() => {
    const getPhoto = async () => {
      const tokenPhoto = await instance.acquireTokenSilent({
        ...loginRequest,
        account: instance.getAllAccounts()[0],
      });
      const headers = new Headers();
      const bearer = `Bearer ${tokenPhoto.accessToken}`;
      headers.append("Authorization", bearer);

      const options = {
        method: "GET",
        headers: headers,       
    };
    const response = await fetch("https://graph.microsoft.com/v1.0/me/photo/$value", options);
    const blob = await response.blob();
    const url = URL.createObjectURL(blob);

    setGraphPhoto(url);
    }
    getPhoto();
  }, [instance]);



  const dataProfile: IPersonaSharedProps = {
    imageUrl: graphPhoto,
    imageInitials:graphData ? graphData.displayName?.charAt(0) : "",
    text: graphData ? graphData.displayName : "",
    secondaryText:graphData ?  graphData.jobTitle : "",
    tertiaryText: graphData ?  graphData.mail : "",
    optionalText: graphData ?  graphData.mobilePhone : "",
    presence: PersonaPresence.online,
  };
  console.log("🚀 ~ file: AvatarUser.tsx ~ line 68 ~ dataProfile", dataProfile)
  

  return (
    <Stack tokens={{ childrenGap: 10 }}>

      <Persona
        {...dataProfile}
        hidePersonaDetails={false}
        // hidePersonaDetails={!renderDetails}
        imageAlt="dont put anything here"
      />
      <Shimmer isDataLoaded={dataProfile} ariaLabel="Loading content">
        <Stack
          style={{
            overflow: 'hidden',
            textOverflow: 'ellipsis',
            whiteSpace: 'nowrap',
            lineHeight: '1',
            minHeight: '16px',
          }}
        >
          {contentOne}
          {contentOne}
          {contentOne}
        </Stack>
      </Shimmer>

    </Stack>
  );
};
