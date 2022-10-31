import * as React from 'react';
import { Nav } from '@fluentui/react';

const links = [
    {
        links: [
            {
                name: 'Inicio',
                url: '/',
                key: 'home',
                iconProps:{
                    iconName: 'Home',
                    styles:{
                        root:{
                            fontSize: '20',
                            color: '#0B275C',
                        }
                    }
                }
            },
            {
                name: 'Administracion',
                url: '/',
                key: 'administracion',
                iconProps:{
                    iconName: 'Admin',
                    styles:{
                        root:{
                            fontSize: '20',
                            color: '#0B275C',
                        }
                    }
                }
            },            {
                name: 'Contabilidad',
                url: '/',
                key: 'contabilidad',
                iconProps:{
                    iconName: 'Chart',
                    styles:{
                        root:{
                            fontSize: '20',
                            color: '#0B275C',
                        }
                    }
                }
            },
            {
                name: 'Recursos Humanos',
                url: '/',
                key: 'recursosHumanos',
                iconProps:{
                    iconName: 'Teamwork',
                    styles:{
                        root:{
                            fontSize: '20',
                            color: '#0B275C',
                        }
                    }
                }
            },
            {
                name: 'Ventas',
                url: '/',
                key: 'ventas',
                iconProps:{
                    iconName: 'ShoppingCart',
                    styles:{
                        root:{
                            fontSize: '20',
                            color: '#0B275C',
                        }
                    }
                }
            }
        ]
    }
]
const navigationStyles = {
    root: {
        height: '100vh',
        boxSizing: 'border-box',
        border: '1px solid #EEEEEE',
        overFlowY: 'auto',
        paddingTop: '0vh',
    }
}
const SideNav = () => {

    return (
        <Nav groups={links}
        selectedKey='home'
        styles={navigationStyles}
        />
        
    )
}


export default SideNav;