import { Panel, IconButton, PanelType, Image, INavStyles, INavLinkGroup, Nav, IButtonStyles, IIconStyles, Link } from '@fluentui/react';
import { useBoolean } from '@fluentui/react-hooks';

import { Images, Theme } from "../styles/Theme";

const commandBarIconButtonStyles: IButtonStyles = {
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
    transition: "all 0.2s ease-in-out",
    ":hover": {
      transform: "scale(0.9, 0.9)",
      borderColor: Theme.palette.themePrimary,
    },
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

const commandBarIconButtonIconStyles: IIconStyles = {
  root: {
    color: Theme.palette.white,
    fontSize: 18,
  },
};

export default function SideBar(){
    const [isOpen, { setTrue: openPanel, setFalse: dismissPanel }] = useBoolean(false);
    const navStyles: Partial<INavStyles> = { root: { width: 280 } };

    const navLinkGroups: INavLinkGroup[] = [
        { name: 'Seguridad',
          expandAriaLabel: 'Expand Catalogos components section',
          collapseAriaLabel: 'Collapse Catalogos components section',
          links: [
            // {
            //   key: 'usuarios',
            //   name: 'Usuarios',
            //   linkAs: Link,
            //   url: '/users',
            //   onRenderIcon: () => 
            //   <Icon iconName="User" 
            //   styles={commandBarIconButtonIconStyles}
            //   onClick={() => navigateTo("/dashboard")} 
            //   />,
            //   onRenderText: () => <span>Usuarios</span>,
            //   onRenderDescription: () => <span>Administración de usuarios</span>,
            //   // url: '/users',
            //   // onClick(INavLink) {
            //   //   alert(navigateTo);
            //   // },
            //   icon: 'User',
            //   iconProps: { iconName: 'User' },
            //   className: 'ms-Icon ms-Icon--User',
            //   isExpanded: true,
            //   onLinkClick: openPanel,
            //   // icon: <Icon iconName="User" styles={commandBarIconButtonIconStyles} />,
            //   iconExpanded: <Icon iconName="User" styles={commandBarIconButtonIconStyles} />,
            //   iconCollapsed: <Icon iconName="User" styles={commandBarIconButtonIconStyles} />,
            //   isSelected: false,
            //   isDisabled: false,
            //   isChecked: false,
            //   isVisible: true,
            //   isCollapsed: false,
            //   isGroup: false,
            //   isLink: true,
            //   isButton: false,
            //   isSplit: false,
            //   isDropdown: false,
            //   isIcon: true,
            //   isLabel: false,
            //   isPrimary: false,
            //   isUniqueSelection: false,
            //   isActive: false,
            //   isHidden: false,
            //   isFocused: false,
            //   isCheckbox: false,
            //   isRadio: false,
            //   isLinkText: false,
            //   isLinkDescription: false,
            //   isLinkTooltip: false,
            //   isLinkTitle: false,
            //   isLinkKeytip: false,
            //   isLinkIcon: false,
            //   isLinkUrl: false,
            //   isLinkOnClick: false,
            //   isLinkOnMouseEnter: false,
            //   isLinkOnMouseLeave: false,
            //   isLinkOnKeyDown: false,
            //   isLinkOnKeyUp: false,
            //   isLinkOnKeyPress: false,
            //   isLinkOnFocus: false,
            //   isLinkOnBlur: false,
            //   isLinkOnClickBase: false,
            //   isLinkOnMouseEnterBase: false,
            //   isLinkOnMouseLeaveBase: false,
            //   isLinkOnKeyDownBase: false,
            //   isLinkOnKeyUpBase: false,
            //   isLinkOnKeyPressBase: false,
            //   isLinkOnFocusBase: false,
            //   // onClick:() => navigateTo("/users")      
            // },
            {
              key: 'usuarios',
              name: 'Usuarios',
              linkAs: Link,
              url: '/users',
              iconProps: {
                iconName: "People",
                styles: {
                  root: {
                    fontSize: 20,
                    color: Theme.palette.themePrimary
                  }
                }
              }
            },
            {
              key: 'roles',
              name: 'Roles',
              url: '/roles',
              iconProps: {
                iconName: "ManagerSelfService",
                styles: {
                  root: {
                    fontSize: 20,
                    color: Theme.palette.themePrimary
                  }
                }
              }
            },
            {
              key: 'permisos',
              name: 'Permisos',
              url: '/permissions',
              iconProps: {
                iconName: "AuthenticatorApp",
                styles: {
                  root: {
                    fontSize: 20,
                    color: Theme.palette.themePrimary
                  }
                }
              }
            },
          ],
          collapseByDefault: true,
        },
        { name: 'Clientes',
          expandAriaLabel: 'Expand Reports components section',
          collapseAriaLabel: 'Collapse Reports components section',
          links: [
            {
              key: 'residenciales',
              name: 'Residenciales',
              url: '/residential',
              iconProps: {
                iconName: "Street",
                styles: {
                  root: {
                    fontSize: 20,
                    color: Theme.palette.themePrimary
                  }
                }
              }
            },
            {
              key: 'empresariales',
              name: 'Empresariales',
              url: '/business',
              iconProps: {
                iconName: "CityNext2",
                styles: {
                  root: {
                    fontSize: 20,
                    color: Theme.palette.themePrimary
                  }
                }
              }
            },
            {
              key: 'vip',
              name: 'VIP',
              url: '/vip',
              iconProps: {
                iconName: "IDBadge",
                styles: {
                  root: {
                    fontSize: 20,
                    color: Theme.palette.themePrimary
                  }
                }
              }
            },
            {
              key: 'empleados',
              name: 'Empleados',
              url: '/employees',
              iconProps: {
                iconName: "ContactCard",
                styles: {
                  root: {
                    fontSize: 20,
                    color: Theme.palette.themePrimary
                  }
                }
              }
            },
            {
              key: 'torre',
              name: 'Torre',
              url: '/tower',
              iconProps: {
                iconName: "NetworkTower",
                styles: {
                  root: {
                    fontSize: 20,
                    color: Theme.palette.themePrimary
                  }
                }
              }
            },
          ],
          collapseByDefault: true,
        },
        { name: 'Cobranza',
          expandAriaLabel: 'Expand Empaque section',
          collapseAriaLabel: 'Collapse Empaque section',
          links: [
            {
              key: 'EtiqEmpaqueNav1',
              name: 'Lista Precios',
              url: '/pricelist',
              iconProps: {
                iconName: "AllCurrency",
                styles: {
                  root: {
                    fontSize: 20,
                    color: Theme.palette.themePrimary
                  }
                }
              }
            },
          ],
          collapseByDefault: true,
        },
        { name: 'Reportes',
          expandAriaLabel: 'Expand reports section',
          collapseAriaLabel: 'Collapse reports section',
          links: [
            {
              key: 'CuartoFrioNav1',
              name: 'Corte de caja',
              url: '/cutofmoney',
              iconProps: {
                iconName: "Money",
                styles: {
                  root: {
                    fontSize: 20,
                    color: Theme.palette.themePrimary
                  }
                }
              }
            },
          ],
          collapseByDefault: true,
        },
        { name: 'Configuraciónes',
          expandAriaLabel: 'Expand configuración section',
          collapseAriaLabel: 'Collapse configuración section',
          links: [
            {
              key: 'ConfiguracionesNav1',
              name: 'Lista Zonas',
              url: '/zonelist',
              iconProps: {
                iconName: "POI",
                styles: {
                  root: {
                    fontSize: 20,
                    color: Theme.palette.themePrimary
                  }
                }
              }
            },
          ],
          collapseByDefault: true,
        },
      ];
      return (
        <div>
          <IconButton
            styles={commandBarIconButtonStyles}
            iconProps={{
              iconName: "GlobalNavButton",
              styles: commandBarIconButtonIconStyles
            }}
            onClick={openPanel}
    
          />
          <Panel
            isBlocking={true}
            isOpen={isOpen}
            onDismiss={dismissPanel}
            type={PanelType.smallFixedNear}
            onRenderBody={() => {
              return (
                <div>
                  <Image src={Images.comcomlogo} alt="Logo" width={215} height={130} 
                  styles={{
                    root: {
                      imageRendering: "-webkit-optimize-contrast",
                      display: "flex",
                      alignItems: "center",
                      justifyContent: "center",
                      margin: "0 auto",
                    }
                  }} />
                      <Nav styles={navStyles} ariaLabel="Navigation" groups={navLinkGroups} />
                </div>
              );
            }}
            // onRenderBody={() => {
            //   return (
              
            //     );
            // }}
            styles={{
              root: {
                backgroundColor: Theme.palette.themePrimary,
                color: Theme.palette.white,
                width: '280px',
                height: '100%',
                position: 'fixed',
                // top: '0',
                // left: isOnRightSide ? '0' : 'auto',
                // right: isOnRightSide ? 'auto' : '0',
                zIndex: '1',
                overflow: 'hidden',
                transition: 'all 0.3s ease-in-out',
                boxShadow: '0px 0px 10px 0px rgba(0,0,0,0.75)',
                borderRadius: '0px 0px 0px 0px',
                transform: isOpen ? 'translateX(0)' : 'translateX(-100%)',
                boxSizing: 'border-box',
                // padding: '0px',
                // margin: '0px',
                // display: 'flex',
                // flexDirection: 'column',
                // alignItems: 'center',
                // alignContent: 'center',
              },
              headerText: {
                fontSize: '12px',
                color: Theme.palette.white,
                fontWeight: '600',
                margin: '0px',
                padding: '0px',
                display: 'flex',
                alignItems: 'center',
                alignContent: 'center',
                height: '100%'
              },
              contentInner: {
                flexDirection: 'column',
                height: '100%'
              },
              commands: {
                display: 'contents',
                // flexDirection: 'column',
                // alignItems: 'center',
                // alignContent: 'center',
                // height: '100%',
                // marginLeft: 'auto',
              },
              scrollableContent: {
                height: '100%',
                overflowY: 'auto',
                overflowX: 'hidden',
              },
              content: {
                height: '100%',
                width: '100%',
              },
              header: {
                height: '100%',
                width: '100%',
              },
              footer: {
                height: '100%'
              },
            }}>
          </Panel>
        </div>
      );
    };
    
// function navigateTo(url: string) {
//   window.location.href = url;
// }