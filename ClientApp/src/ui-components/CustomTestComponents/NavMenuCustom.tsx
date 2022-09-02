import { CommandBar, IButtonStyles, ICommandBarItemProps, ICommandBarStyles, IIconStyles, ISearchBoxStyles, SearchBox, Stack } from '@fluentui/react';
import { Theme } from '../../styles/Theme';




//Styles
const commandBarStyles: ICommandBarStyles = {
    root: {
        backgroundColor: Theme.palette.themePrimary,
        height: 60,
        padding: 8
    }
};

const searchProps: ISearchBoxStyles = {
    root: {
      backgroundColor: "#fff",
      border: "1px solid #fff",
      borderRadius: 0,
      height: 30,
      width: "600px",
      padding: '0px 0px 0px 0px',
      margin: '12px 400px 0px 0px',
      selectors: {
        ':hover': {
          border: "1px solid #fff"
        }
      }
    },
  }

const commandBarIconButtonIconStyles: IIconStyles = {
    root: {
        color: Theme.palette.white,
        fontSize: 15,

    }
};

const commandBarIconButtonStyles: IButtonStyles = {
    root: {
        backgroundColor: Theme.palette.themePrimary,
        width: 50
    },
    rootHovered: {
        backgroundColor: Theme.palette.neutralPrimary,
        width: 50,
        color: Theme.palette.white,
        borderColor: Theme.palette.themeTertiary,
        borderWidth: 1,
        borderStyle: 'solid',
        borderRadius: 0,
        padding: 0,
        margin: 0,
        height: 50,
        minWidth: 50,
        maxWidth: 50,
        minHeight: 50,
        maxHeight: 50,
        fontSize: '1.5em',
        fontWeight: 'bold',
        textAlign: 'center',
        textTransform: 'uppercase',
        lineHeight: '50px',
        cursor: 'pointer',
        outline: 'none',
        boxShadow: 'none',
    },
    rootPressed: {
        backgroundColor: Theme.palette.themePrimary,
        width: 50,
        color: Theme.palette.white,
        borderColor: Theme.palette.neutralPrimary,
        animationIterationCount: '2',
        animationDuration: '0.3s',
        borderWidth: 1,
        borderStyle: 'solid',
        borderRadius: 0,
        padding: 0,
        margin: 0,
        height: 50,
        minWidth: 50,
        maxWidth: 50,
        minHeight: 50,
        maxHeight: 50,
        fontSize: '1.5em',
        fontWeight: 'bold',
        textAlign: 'center',
        textTransform: 'uppercase',
        lineHeight: '50px',
        cursor: 'pointer',
        outline: 'none',
        boxShadow: 'none',
    },
    rootChecked: {
        backgroundColor: Theme.palette.themePrimary,
        width: 50,
        color: Theme.palette.white,
        borderColor: Theme.palette.neutralPrimary,
        borderWidth: 1,
        borderStyle: 'solid',
        borderRadius: 0,
        padding: 0,
        margin: 0,
        height: 50,
        minWidth: 50,
        maxWidth: 50,
        minHeight: 50,
        maxHeight: 50,
        fontSize: '1.5em',
        fontWeight: 'bold',
        textAlign: 'center',
        textTransform: 'uppercase',
        lineHeight: '50px',
        cursor: 'pointer',
        outline: 'none',
        boxShadow: 'none',
    },
    rootExpanded: {
        backgroundColor: Theme.palette.themePrimary,
        width: 50,
        color: Theme.palette.white,
        borderColor: Theme.palette.neutralPrimary,
        borderWidth: 1,
        borderStyle: 'solid',
        borderRadius: 0,
        padding: 0,
        margin: 0,
        height: 50,
        minWidth: 50,
        maxWidth: 50,
        minHeight: 50,
        maxHeight: 50,
        fontSize: '1.5em',
        fontWeight: 'bold',
        textAlign: 'center',
        textTransform: 'uppercase',
        lineHeight: '50px',
        cursor: 'pointer',
        outline: 'none',
        boxShadow: 'none',
    },
    rootDisabled: {
        backgroundColor: Theme.palette.neutralTertiaryAlt,
        width: 50,
        color: Theme.palette.neutralTertiaryAlt,
        borderColor: Theme.palette.neutralTertiaryAlt,
        borderWidth: 1,
        borderStyle: 'solid',
        borderRadius: 0,
        padding: 0,
        margin: 0,
        height: 50,
        minWidth: 50,
        maxWidth: 50,
        minHeight: 50,
        maxHeight: 50,
        fontSize: '1.5em',
        fontWeight: 'bold',
        textAlign: 'center',
        textTransform: 'uppercase',
        lineHeight: '50px',
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
        color: Theme.palette.white,
    },
    iconPressed: {
        color: Theme.palette.white,
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
        color: Theme.palette.white,
        textAlign: 'center',
        textTransform: 'uppercase',
        lineHeight: '50px',
        cursor: 'pointer',
        outline: 'none',
        boxShadow: 'none',
    },
    iconExpanded: {
        fontSize: '1.5em',
        fontWeight: 'bold',
        textAlign: 'center',
        textTransform: 'uppercase',
        lineHeight: '50px',
        cursor: 'pointer',
        outline: 'none',
        boxShadow: 'none',
    },
    iconDisabled: {
        fontSize: '1.5em',
        fontWeight: 'bold',
        textAlign: 'center',
        textTransform: 'uppercase',
        lineHeight: '50px',
        cursor: 'pointer',
        outline: 'none',
        boxShadow: 'none',
    },
};



//Props
const outerCommandBarFarItems: ICommandBarItemProps[] = [

    {
        key: "Search",
        onRender: () => {
            return (
                <div>
                    <SearchBox
                        styles={searchProps}
                        placeholder="Buscar..."
                        underlined={true}
                    />
                </div>
            );
        }
    },
    {
        key: "Inicio",
        iconOnly: true,
        iconProps: {
            iconName: 'Home',
            styles: commandBarIconButtonIconStyles
        },
        buttonStyles: commandBarIconButtonStyles,
        href: '/Inicio',
    },
    {
        key: "Notifications",
        iconOnly: true,
        iconProps: {
            iconName: "Ringer",
            styles: commandBarIconButtonIconStyles
        },
        buttonStyles: commandBarIconButtonStyles
    },
    {
        key: "Settings",
        iconOnly: true,
        iconProps: {
            iconName: "Settings",
            styles: commandBarIconButtonIconStyles
        },
        buttonStyles: commandBarIconButtonStyles
    },
    {
        key: "Lenguage",
        iconOnly: true,
        iconProps: {
            iconName: "Globe",
            styles: commandBarIconButtonIconStyles
        },
        buttonStyles: commandBarIconButtonStyles
    },
    // {
    //     key: "Persona",
    //     onRender: () => {
    //       return (
    //         <div>
    //           <Persona
    //             {...userPersona}
    //             size={PersonaSize.size40}
    //             presence={PersonaPresence.online}
    //             styles={personaStyles}
    //             theme={Theme}
    //             hidePersonaDetails={true}
    //             onRenderPersonaCoin={(props) => {
    //               const [isCalloutVisible, { toggle: toggleIsCalloutVisible }] = useBoolean(false);
    //               const buttonId = useId('callout-button');
    //               const labelId = useId('callout-label');
    //               const descriptionId = useId('callout-description');
    //               const isAuthenticated = useIsAuthenticated();
    //               const { instance, accounts } = useMsal();
    //               const [graphData, setGraphData] = React.useState('');
    //             //   // console.log(ProfileContent);
    //               function RequestProfileData() {
    //                 // Silently acquires an access token which is then attached to a request for MS Graph data
    //                 instance.acquireTokenSilent({
    //                   ...loginRequest,
    //                   scopes: ["User.Read.All"],
    //                   account: accounts[0]
    //                 }).then((response) => {
    //                   callMsGraph(response.accessToken).then(response => setGraphData(response));
    //                 });
    //               }
    //               return (
    //                 <div>
    //                   <PersonaCoin
    //                     id={buttonId}
    //                     onClick={toggleIsCalloutVisible}
    //                     {...props}
    //                   />
    //                   {isCalloutVisible && (
    //                     <Callout
    //                       className={styles.callout}
    //                       ariaLabelledBy={labelId}
    //                       ariaDescribedBy={descriptionId}
    //                       role="dialog"
    //                       gapSpace={1}
    //                       target={`#${buttonId}`}
    //                       onDismiss={toggleIsCalloutVisible}
    //                       setInitialFocus={true}
    //                     >
    //                       <PersonaCoin
    //                         {...props}
    //                         text={accounts[0].name}
    //                         secondaryText={accounts[0].username}
    //                         size={PersonaSize.size72}
    //                         presence={PersonaPresence.online}
                            
    //                         />
    //                       <Link href="https://portal.office.com/account?#personalinfo" target="_blank" title='Ver cuenta' className={styles.link}>
    //                         Ver cuenta
    //                       </Link>
    //                       <Link href="https://nam.delve.office.com/" target="_blank" title='Mi perfil de Office' className={styles.link} >
    //                         Mi perfil de Office
    //                       </Link>
    //                       {isAuthenticated ? <SignOutButton /> : <SignInButton />}
    //                     </Callout>
    //                   )}
    //                 </div>
    //               );
    //             }}
    //           />
    //         </div>
    //       );
    //     }
    //   },
    ];

const INavItems: ICommandBarItemProps[] = [
    {
        key: "Menu",
        iconOnly: true,
        onRender: () => {
            return (
                <div>
                    {/* <SideMenu /> */}
                </div>
            );
        }
    },
    {
        key: "Valhpac",
        name: "Valores Horticolas del Pacifico®",
        buttonStyles: {
            root: {
                backgroundColor: Theme.palette.themePrimary,
                fontSize: 22,
                marginLeft: 10,
                padding: 0,
            },
            rootHovered: {
                backgroundColor: "transparent",
            },
            rootPressed: {
                backgroundColor: "transparent",
            },
            label: {
                color: "white",
                margin: 0
            }
        },
    },
];





export default function NavMenuCustom() {

    return (
        <Stack>
            <CommandBar
                styles={commandBarStyles}
                farItems={outerCommandBarFarItems}
                items={INavItems}
            />
        </Stack>
    );
}
