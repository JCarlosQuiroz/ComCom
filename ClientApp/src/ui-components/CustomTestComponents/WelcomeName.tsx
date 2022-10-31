import { useEffect, useState } from "react";
import { useMsal, useAccount } from "@azure/msal-react";
import { Text } from "@fluentui/react";
import { Stack } from "@fluentui/react/lib/Stack";

const WelcomeName = () => {
  const { accounts } = useMsal();
  const account = useAccount(accounts[0] || {});
  const [name, setName] = useState("");
  const [time, setTime] = useState(new Date().toLocaleTimeString());
  const [date, setDate] = useState(new Date().toLocaleDateString());
  useEffect(() => {
    if (account && account.name) {
      setName(account.name);
    } else {
      setName("");
    }
  }, [account]);

  useEffect(() => {
    const timer = setInterval(() => {
      setTime(new Date().toLocaleTimeString());
      setDate(new Date().toLocaleDateString());
    }, 1000);
    return () => clearInterval(timer);
  }, []);


  if (name) {
    return (
      // 'start' | 'end' | 'center' | 'space-between' | 'space-around' | 'space-evenly' | 'baseline' | 'stretch'
      <Stack  horizontalAlign="center">
        <Text variant="xxLarge" block>
          Bienvenido {name}!
        </Text>
        <Text variant="xLarge">
          {date}, {time}
        </Text>
        </Stack>
    );
  } else {
    return null;
  }
};

export default WelcomeName;