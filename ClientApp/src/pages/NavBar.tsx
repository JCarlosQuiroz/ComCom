import {NavLink} from "react-router-dom";
import {
  Stack,
  CommandBar,
  IPersonaStyles,
  IButtonStyles,
  ICommandBarItemProps,
  ICommandBarStyles,
  IIconStyles,
  mergeStyleSets,
  SearchBox,
  ISearchBoxProps,
  IButtonProps,
  IconButton
} from "@fluentui/react";
import { useIsAuthenticated } from "@azure/msal-react";
import { Theme } from "../styles/Theme";
import SideBar from "./SideBar";
import { PersonProfile } from "../pages/Profile";


const outerCommandBarStyles: ICommandBarStyles = {
  root: {
    backgroundColor: Theme.palette.themePrimary,
    margin: 0,
    padding: 0,
    height: "100%",
    width: "100%",
  },
};

export const styles = mergeStyleSets({
  button: {
    width: 130,
  },
  callout: {
    width: 320,
    maxWidth: "100%",
    padding: "20px 24px",
  },
  title: {
    marginBottom: 12,
    fontWeight: 600,
    color: Theme.palette.themePrimary,
    fontSize: "1em",
  },
  link: {
    display: "block",
    marginTop: 20,
  },
  Text: {
    color: Theme.palette.themePrimary,
  },
  secondaryText: {
    color: Theme.palette.neutralTertiary,
  },
  icon: {
    color: Theme.palette.themePrimary,
  },
  personaContainer: {
    display: "inline-block",
    margin: "0 auto",
  },
  buttonContainer: {
    margin: "10px 0",
  },
  calloutContent: {
    marginLeft: "20px",
    marginRight: "20px",
    marginTop: "20px",
    marginBottom: "20px",
    display: "flex",
    flexDirection: "column",
    alignItems: "center",
    justifyContent: "center",
  },
  calloutHeader: {
    fontSize: "1.5em",
    fontWeight: 600,
    color: Theme.palette.themePrimary,
    marginBottom: "10px",
  },
  calloutHeaderText: {
    fontSize: "1.5em",
    fontWeight: 600,
    color: Theme.palette.themePrimary,
    marginBottom: "10px",
  },
});

export const commandBarIconButtonStyles: IButtonStyles = {
  root: {
    backgroundColor: Theme.palette.themePrimary,
    width: "40px",
    height: "40px",
    fill: Theme.palette.white,
  },
  rootHovered: {
    backgroundColor: Theme.palette.white,
    width: 40,
    color: Theme.palette.themePrimary,
    // borderColor: Theme.palette.themeTertiary,
    // borderWidth: 1,
    // borderStyle: 'solid',
    borderRadius: "50%",
    borderColor: Theme.palette.neutralPrimary,
    borderWidth: "2x",
    borderStyle: "solid",
    transition: "all 0.2s ease-in-out",
    ":hover": {
      transform: "scale(0.9, 0.9)",
      borderColor: Theme.palette.themePrimary,
    },
    padding: 0,
    margin: 0,
    height: 40,
    minWidth: 40,
    maxWidth: 40,
    minHeight: 40,
    maxHeight: 40,
    fontSize: '1.5em',
    fontWeight: 'bold',
    textAlign: 'center',
    textTransform: 'uppercase',
    lineHeight: '40px',
    cursor: 'pointer',
    outline: 'none',
    boxShadow: 'none',
  },
  rootPressed: {
    backgroundColor: Theme.palette.themePrimary,
    width: 40,
    color: Theme.palette.themePrimary,
    borderColor: Theme.palette.neutralPrimary,
    animationIterationCount: '2',
    animationDuration: '0.3s',
    borderWidth: 1,
    borderStyle: 'solid',
    borderRadius: 0,
    padding: 0,
    margin: 0,
    height: 40,
    minWidth: 40,
    maxWidth: 40,
    minHeight: 40,
    maxHeight: 40,
    fontSize: '1.5em',
    fontWeight: 'bold',
    textAlign: 'center',
    textTransform: 'uppercase',
    lineHeight: '40px',
    cursor: 'pointer',
    outline: 'none',
    boxShadow: 'none',
  },
  rootChecked: {
    backgroundColor: Theme.palette.themePrimary,
    width: 40,
    color: Theme.palette.themePrimary,
    borderColor: Theme.palette.neutralPrimary,
    borderWidth: 1,
    borderStyle: 'solid',
    borderRadius: 0,
    padding: 0,
    margin: 0,
    height: 40,
    minWidth: 40,
    maxWidth: 40,
    minHeight: 40,
    maxHeight: 40,
    fontSize: '1.5em',
    fontWeight: 'bold',
    textAlign: 'center',
    textTransform: 'uppercase',
    lineHeight: '40px',
    cursor: 'pointer',
    outline: 'none',
    boxShadow: 'none',
  },
  rootExpanded: {
    backgroundColor: Theme.palette.themePrimary,
    width: 40,
    color: Theme.palette.themePrimary,
    borderColor: Theme.palette.neutralPrimary,
    borderWidth: 1,
    borderStyle: 'solid',
    borderRadius: 0,
    padding: 0,
    margin: 0,
    height: 40,
    minWidth: 40,
    maxWidth: 40,
    minHeight: 40,
    maxHeight: 40,
    fontSize: '1.5em',
    fontWeight: 'bold',
    textAlign: 'center',
    textTransform: 'uppercase',
    lineHeight: '40px',
    cursor: 'pointer',
    outline: 'none',
    boxShadow: 'none',
  },
  rootDisabled: {
    backgroundColor: Theme.palette.neutralTertiaryAlt,
    width: 40,
    color: Theme.palette.neutralTertiaryAlt,
    borderColor: Theme.palette.neutralTertiaryAlt,
    borderWidth: 1,
    borderStyle: 'solid',
    borderRadius: 0,
    padding: 0,
    margin: 0,
    height: 40,
    minWidth: 40,
    maxWidth: 40,
    minHeight: 40,
    maxHeight: 40,
    fontSize: '1.5em',
    fontWeight: 'bold',
    textAlign: 'center',
    textTransform: 'uppercase',
    lineHeight: '40px',
    cursor: 'pointer',
    outline: 'none',
    boxShadow: 'none',
  },
  icon: {
    textAlign: 'center',
    textTransform: 'uppercase',
    cursor: 'pointer',
    outline: 'none',
    boxShadow: 'none',
  },
  iconHovered: {
    fontSize: '1em',
    textAlign: 'center',
    textTransform: 'uppercase',
    cursor: 'pointer',
    outline: 'none',
    boxShadow: 'none',
    color: Theme.palette.themePrimary,
  },
  iconPressed: {
    color: Theme.palette.themePrimary,
    fontSize: '1em',
    animationIterationCount: '2',
    animationDuration: '0.3s',
    textAlign: 'center',
    textTransform: 'uppercase',
    cursor: 'pointer',
    outline: 'none',
    boxShadow: 'none',
  },
  iconChecked: {
    color: Theme.palette.themePrimary,
    textAlign: 'center',
    textTransform: 'uppercase',
    lineHeight: '40px',
    cursor: 'pointer',
    outline: 'none',
    boxShadow: 'none',
  },
  iconExpanded: {
    fontSize: '1.5em',
    fontWeight: 'bold',
    textAlign: 'center',
    textTransform: 'uppercase',
    lineHeight: '40px',
    cursor: 'pointer',
    outline: 'none',
    boxShadow: 'none',
  },
  iconDisabled: {
    fontSize: '1.5em',
    fontWeight: 'bold',
    textAlign: 'center',
    textTransform: 'uppercase',
    lineHeight: '40px',
    cursor: 'pointer',
    outline: 'none',
    boxShadow: 'none',
  },
};

export const commandBarIconButtonIconStyles: IIconStyles = {
  root: {
    color: Theme.palette.white,
    fontSize: 18,
  },
};
// Accesorios relacionados con CommandBar

const _itemsAuth: ICommandBarItemProps[] = [
  {
    key: "Menu",
    iconOnly: true,
    onRender: () => {
      return (
        <div>
          <SideBar />
        </div>
      );
    },
  },
  {
    key: "PACC",
    name: "Portal Administrativo Com Com®",
    title: "Portal Administrativo Com Com®",
    buttonStyles: {
      root: {
        backgroundColor: Theme.palette.themePrimary,
        fontSize: "15px ",
        padding: "0px 20px 0px 20px",
        display: "inline-block",
        height: "40px",
        lineHeight: "40px",
        fontWeight: 600,
      },
      rootHovered: {
        backgroundColor: "transparent",
      },
      rootPressed: {
        backgroundColor: "transparent",
      },
      label: {
        color: "white",
        margin: 0,
      },
    },
    
  },
  {
    key: "Search",
    onRender: () => {
      return (
        <div>
          <SearchBox
            {...searchProps}
            showIcon={true}
            placeholder="Buscar..."
            underlined={false}
            // styles={{
            //   root: {
            //     backgroundColor: Theme.palette.white,
            //     color: Theme.palette.themePrimary,
            //     borderRadius: "0px",
            //     border: "1px solid #eaeaea",
            //     padding: "0px",
            //     marginRight: "15px",
            //     maxWidth: "800px",
            //     marginLeft: "300px",
            //     width: "800px",
            //     maxHeight: "40px",
            //     minWidth: "280px",
            //     flex: "0 1 auto",
            //     position: "relative",
            //     display: "flex",
            //     transform: "scaleX(1)",
            //     transition: "all 0.2s ease",
            //     fontSize: "14px",
            //     height: "40px",
            //     lineHeight: "40px",
            //     selectors: {
            //       ":hover": {
            //         border: "1px solid #fff",
            //       },
            //     },
            //   },
            // }}

            onChanged={(newValue: string) => {
              console.log(newValue);
            }}
          />
        </div>
      );
    },
  },

  // {
  //   key: "Logo",
  //   onRender: (props: number | undefined) => <Image {...imageProps} />,
  // }
];

const _itemsNoAuth: ICommandBarItemProps[] = [
  // {
  //     key: 'newItem',
  //     text: 'New',
  //     cacheKey: 'myCacheKey', // changing this key will invalidate this item's cache
  //     iconProps: { iconName: 'Add' },
  //     subMenuProps: {
  //       items: [
  //         {
  //           key: 'emailMessage',
  //           text: 'Email message',
  //           iconProps: { iconName: 'Mail' },
  //           ['data-automation-id']: 'newEmailButton', // optional
  //         },
  //         {
  //           key: 'calendarEvent',
  //           text: 'Calendar event',
  //           iconProps: { iconName: 'Calendar' },
  //         },
  //       ],
  //     },
  //   },
  //   {
  //     key: 'upload',
  //     text: 'Upload',
  //     iconProps: { iconName: 'Upload' },
  //     subMenuProps: {
  //       items: [
  //         {
  //           key: 'uploadfile',
  //           text: 'File',
  //           preferMenuTargetAsEventTarget: true,
  //           onClick: (ev?: React.MouseEvent<HTMLElement, MouseEvent> | React.KeyboardEvent<HTMLElement> | undefined) => {
  //             ev?.persist();
  //             Promise.resolve().then(() => {
  //               const inputElement = document.createElement('input');
  //               inputElement.style.visibility = 'hidden';
  //               inputElement.setAttribute('type', 'file');
  //               document.body.appendChild(inputElement);
  //               const target = ev?.target as HTMLElement | undefined;
  //               if (target) {
  //                 setVirtualParent(inputElement, target);
  //               }
  //               inputElement.click();
  //               if (target) {
  //                 setVirtualParent(inputElement, null);
  //               }
  //               setTimeout(() => {
  //                 inputElement.remove();
  //               }, 10000);
  //             });
  //           },
  //         },
  //         {
  //           key: 'uploadfolder',
  //           text: 'Folder',
  //           preferMenuTargetAsEventTarget: true,
  //           onClick: (ev?: React.MouseEvent<HTMLElement, MouseEvent> | React.KeyboardEvent<HTMLElement> | undefined) => {
  //             ev?.persist();
  //             Promise.resolve().then(() => {
  //               const inputElement = document.createElement('input');
  //               inputElement.style.visibility = 'hidden';
  //               inputElement.setAttribute('type', 'file');
  //               (inputElement as { webkitdirectory?: boolean }).webkitdirectory = true;
  //               document.body.appendChild(inputElement);
  //               const target = ev?.target as HTMLElement | undefined;
  //               if (target) {
  //                 setVirtualParent(inputElement, target);
  //               }
  //               inputElement.click();
  //               if (target) {
  //                 setVirtualParent(inputElement, null);
  //               }
  //               setTimeout(() => {
  //                 inputElement.remove();
  //               }, 10000);
  //             });
  //           },
  //         },
  //       ],
  //     },
  //   },
  //   {
  //     key: 'share',
  //     text: 'Share',
  //     iconProps: { iconName: 'Share' },
  //     onClick: () => console.log('Share'),
  //   },
  //   {
  //     key: 'download',
  //     text: 'Download',
  //     iconProps: { iconName: 'Download' },
  //     onClick: () => console.log('Download'),
  //   },
];

const _farItemsAuth: ICommandBarItemProps[] = [
  {
    key: "Inicio",
    name: "Inicio",
    iconOnly: true,
      commandBarButtonAs: () => <NavLink to="/"
      style={{
        textDecoration: "none",
        color: "inherit",
        width: "100%",
        height: "100%",
        display: "flex",
        alignItems: "center",
        justifyContent: "center",
      }}
    >
      <IconButton
        iconProps={{
          iconName: "Home",
          styles: commandBarIconButtonIconStyles,
        }}
        styles={commandBarIconButtonStyles}
      />
    </NavLink>,
  },
  {
    key: "downloads",
    name: "Descargas",
    iconProps: {
      iconName: "Settings",
      styles: commandBarIconButtonIconStyles,
    },
    buttonStyles: commandBarIconButtonStyles,
    iconOnly: true,
      commandBarButtonAs: () => <NavLink to="/"
      style={{
        textDecoration: "none",
        color: "inherit",
        width: "100%",
        height: "100%",
        display: "flex",
        alignItems: "center",
        justifyContent: "center",
      }}
    >
      <IconButton
        iconProps={{
          iconName: "Download",
          styles: commandBarIconButtonIconStyles,
        }}
        styles={commandBarIconButtonStyles}
      />
    </NavLink>,
  },
  {
    key: "Configuracion",
    name: "Configuracion",
    iconOnly: true,
    iconProps: {
      iconName: "Settings",
      styles: commandBarIconButtonIconStyles,
    },
    buttonStyles: commandBarIconButtonStyles,
  },
  {
    key: "UserProfile",
    name: "UserProfile",
    title: "UserProfile",
    iconOnly: true,
    onRender: () => {
      return (
        <Stack horizontal horizontalAlign="end" tokens={{ childrenGap: 20 }}>
          <PersonProfile />
        </Stack>
      );
    },
  },
];

// const overflowItemsAuth: ICommandBarItemProps[] = [
//   {
//     key: "Logout",
//     name: "Logout",
//     iconOnly: true,
//     iconProps: {
//       iconName: "SignOut",
//       styles: commandBarIconButtonIconStyles,
//     },
//     buttonStyles: commandBarIconButtonStyles,
//     onClick: () => {
//       window.location.href = "/logout";
//     },
//   },
// ];

const searchProps: ISearchBoxProps = {
  onSearch: (value: string) => {
    console.log(value);
  },
  onClear: (ev: any) => {
    console.log(ev);
  },
  placeholder: "Buscar...",
  styles: {
    root: {
      backgroundColor: Theme.palette.white,
      color: Theme.palette.themePrimary,
      borderRadius: "0px",
      border: "1px solid #eaeaea",
      padding: "0px",
      // marginRight: "140px",
      marginLeft: "200px",
      marginTop: "4px",
      width: "auto",
      maxWidth: "1200px",
      minWidth: "600px",
      height: "auto",
      minHeight: "32px",
      maxHeight: "32px",
      flex: "0 1 auto",
      position: "relative",
      display: "flex",
      transform: "scaleX(1)",
      transition: "all 0.2s ease",
      fontSize: "14px",

      lineHeight: "40px",
      selectors: {
        ":hover": {
          border: "1px solid #fff",
        },
      },
    },
  },
};

const overflowProps: IButtonProps = { 
  ariaLabel: "More commands"
};

export const personaStyles: Partial<IPersonaStyles> = {
  root: {
    textAlign: "center",
    alignContent: "center",
    alignItems: "center",
    justifyContent: "center",
  },
  primaryText: {
    fontSize: 18,
    color: Theme.palette.themePrimary,
    fontWeight: "600",
  },
  secondaryText: {
    fontSize: 12,
    color: Theme.palette.themePrimary,
    fontWeight: "600",
  },
  tertiaryText: {
    fontSize: 12,
    color: Theme.palette.themePrimary,
    fontWeight: "600",
  },
  optionalText: {
    fontSize: 12,
    color: Theme.palette.themePrimary,
    fontWeight: "600",
  },
};

// const searchStyles: ISearchBoxStyles = {
//   root: {
//     backgroundColor: Theme.palette.white,
//     color: Theme.palette.themePrimary,
//     borderRadius: "0px",
//     border: "1px solid #eaeaea",
//     padding: "0px",
//     marginRight: "15px",
//     maxWidth: "800px",
//     marginLeft: "300px",
//     width: "800px",
//     maxHeight: "40px",
//     minWidth: "280px",
//     flex: "0 1 auto",
//     position: "relative",
//     display: "flex",
//     transform: "scaleX(1)",
//     transition: "all 0.2s ease",
//     fontSize: "14px",
//     height: "40px",
//     lineHeight: "40px",
//     selectors: {
//       ":hover": {
//         border: "1px solid #fff",
//       },
//     },
//   },
// };

export default function NavBar() {
  const isAuthenticated = useIsAuthenticated();
  return (
    <Stack
      styles={outerCommandBarStyles}
      horizontalAlign="space-between"
      verticalAlign="center"
      tokens={{
        childrenGap: 0,
      }}
    >
      <CommandBar
        styles={outerCommandBarStyles}
        // items={isAuthenticated ? _itemsAuth : _itemsNoAuth}
        // farItems={isAuthenticated ? _farItemsAuth : undefined}
        items={_itemsNoAuth}
        farItems={_farItemsAuth}
        overflowButtonProps={overflowProps}
        // overflowItems={isAuthenticated ? overflowItemsAuth : undefined}
        primaryGroupAriaLabel="Email actions"
        farItemsGroupAriaLabel="More actions"
        ariaLabel="Use left and right arrow keys to navigate between commands"
        // overflowItems={overflowItems}
      />
    </Stack>
  );
}




