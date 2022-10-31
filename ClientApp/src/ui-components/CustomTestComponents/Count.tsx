import {
    Breadcrumb,
    DefaultButton,
    PrimaryButton,
    Stack,
    Text,
  } from "@fluentui/react";
  import * as React from "react";
  import {
    itemsWithHeading,
    _getCustomDivider,
    _getCustomOverflowIcon,
  } from "../../constants/Breadcrum";
  
  export default function Count() {
    const [count, setCount] = React.useState(0);
  
    return (
      <Stack>
        <Breadcrumb
          style={{
            fontSize: "1rem",
          }}
          styles={{
            root: {
              margin: "0px 0px 0px 0px",
              selectors: {
                "&:not(:first-child)": {
                  marginTop: 24,
                },
              },
            },
          }}
          items={itemsWithHeading.filter((item) => item.text !== "Counter")}
          maxDisplayedItems={3}
          dividerAs={_getCustomDivider}
          onRenderOverflowIcon={_getCustomOverflowIcon}
        />
        <Stack horizontalAlign="center">
          <h1>Contador</h1>
        </Stack>
        <Stack
          horizontal
          horizontalAlign="space-evenly"
          tokens={{ childrenGap: 0 }}
        >
          <PrimaryButton text="Aumentar" onClick={() => setCount(count * 100)} />
          <DefaultButton text="Disminuir" onClick={() => setCount(count - 1)} />
        </Stack>
        <Stack
          horizontal
          horizontalAlign="space-evenly"
          tokens={{ childrenGap: 0 }}
        >
          <Text variant="mega" styles={{ root: { fontWeight: "bold" } }}>
            {count}
          </Text>
        </Stack>
        <Stack
          horizontal
          horizontalAlign="space-evenly"
          tokens={{ childrenGap: 0 }}
        >
          <PrimaryButton text="Reiniciar" onClick={() => setCount(0)} />
        </Stack>
      </Stack>
  
      // <Stack>
      // <Stack
      //   horizontalAlign="start"
      //   verticalAlign="baseline"
      //   horizontal
      //   wrap
      //     tokens={{ padding: "0px 0px 0px 0px", childrenGap: 0 }}
      // >
      //   <Breadcrumb
      //     items={itemsWithHeading.filter(item => item.text !== "Counter")}
      //     maxDisplayedItems={3}
      //     dividerAs={_getCustomDivider}
      //     onRenderOverflowIcon={_getCustomOverflowIcon}
      //   />
      //   </Stack>
      // <Stack horizontalAlign="center">
      //   <h1>Contador</h1>
      //   </Stack>
      //   <Stack horizontal horizontalAlign="space-evenly" tokens={{ childrenGap: 0 }}>
      //     <PrimaryButton text="Aumentar" onClick={() => setCount(count + 1)} />
      //     <DefaultButton text="Disminuir" onClick={() => setCount(count - 1)} />
      //   </Stack>
      //   <Stack horizontal horizontalAlign="space-evenly" tokens={{ childrenGap: 0 }}>
      //     <Text
      //       variant="mega"
      //       styles={{ root: { fontWeight: "bold" } }}
      //     >{count}</Text>
      //   </Stack>
      //   <Stack horizontal horizontalAlign="space-evenly" tokens={{ childrenGap: 0 }}>
      //     <PrimaryButton text="Reiniciar" onClick={() => setCount(0)} />
      //   </Stack>
      // </Stack>
    );
  }
  