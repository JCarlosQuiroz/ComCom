import * as React from "react";
import {
  DetailsList,
  DetailsListLayoutMode,
  Stack,
  CommandBar,
  ICommandBarItemProps,
  ICommandBarStyles,
  IStackItemStyles,
  IStackStyles,
  IButtonProps,
  SearchBox,
  Text,
  SelectionMode,
  ConstrainMode,
} from "@fluentui/react";
import axios from "axios";
import { IUsers, userColumns, _navItems } from "../models/Users";
import {userSecurity } from "../services/endpoints";



export default function CatProved() {
  const [users, setUsers] = React.useState<IUsers[]>([]);

  const overflowProps: IButtonProps = { ariaLabel: "More commands" };



  const _navFarItems: ICommandBarItemProps[] = [
    {
      key: "spViewSearch",
      onRender: () => {
        return (
          <SearchBox
            className="searchBox"
            styles={spViewCommandBarSearchBoxStyle}
          />
        );
      },
    },
    {
      key: "tile",
      text: "Vista de cuadricula",
      // This needs an ariaLabel since it's icon-only
      ariaLabel: "Grid view",
      iconOnly: true,
      iconProps: { iconName: "Tiles" },
    },
    {
      key: "info",
      text: "Info",
      // This needs an ariaLabel since it's icon-only
      ariaLabel: "Info",
      iconOnly: true,
      iconProps: { iconName: "Info" },
      onClick: () => console.log("Info"),
    },
  ];

  const spViewContainerStyle: IStackStyles = {
    root: {
      minHeight: "100vh",
      display: "flex",
      flexDirection: "column",
    },
  };

  const spViewTitleAreaStyle: IStackItemStyles = {
    root: {
      order: 0,
      minWidth: "100vh",
      flexGrow: 0,
      flexShrink: 0,
      padding: 0,
      textAlign: "center",
    },
  };

  const spViewCommandBarStyle: IStackItemStyles = {
    root: {
      order: 0,
      minWidth: "100vh",
      flexGrow: 0,
      flexShrink: 0,
      padding: 0,
    },
  };

  const spViewCommandBarSearchBoxStyle = {
    root: {
      width: "220px",
    },
  };

  const CommBStyles: ICommandBarStyles = {
    root: {
      height: "100%",
    },
  };

  React.useEffect(() => {
    axios
      .get(userSecurity)
      .then((response) => {
        setUsers(response.data);

        console.log(response.data);
      })
      .catch((error) => {
      });
  }, []);

  return (
    <Stack styles={spViewContainerStyle}>
      <Stack.Item styles={spViewTitleAreaStyle}>
        <Text variant="xLarge">Catalogo de Proveedores</Text>
      </Stack.Item>
      <Stack.Item styles={spViewCommandBarStyle}>
        <CommandBar
          styles={CommBStyles}
          items={_navItems}
          overflowButtonProps={overflowProps}
          farItems={_navFarItems}
        />
      </Stack.Item>
      <Stack.Item>
        <DetailsList
          items={users}
          columns={userColumns}
          setKey="set"
          layoutMode={DetailsListLayoutMode.justified}
          selectionPreservedOnEmptyClick={true}
          compact={true}
          isHeaderVisible={true}
          selectionMode={SelectionMode.single}
          enterModalSelectionOnTouch={true}
          constrainMode={ConstrainMode.horizontalConstrained}
          usePageCache={true}
          enableUpdateAnimations={true}
          useReducedRowRenderer={true}
          onItemInvoked={(item: IUsers) => {
            console.log(item);
          }}
        />
      </Stack.Item>
    </Stack>
  );
}
