import * as React from "react";
import { Stack,IStackStyles,IStackItemStyles,SearchBox,DetailsList,DetailsListLayoutMode, IColumn,CommandBar,ICommandBarItemProps,IButtonProps } from "@fluentui/react";


  const spViewContainerStyle: IStackStyles = {
    root: {
      minHeight: "100vh",
      display: "flex",
      flexDirection: "column"
    }
  };
  
  const spViewTitleAreaStyle: IStackItemStyles = {
    root: {
      order: 0,
      minWidth: "100vh",
      flexGrow: 0,
      flexShrink: 0,
      padding: 0
    }
  
  };

  const spViewCommandBarStyle: IStackItemStyles = {
    root: {
      order: 0,
      minWidth: "100vh",
      flexGrow: 0,
      flexShrink: 0,
      padding: 0
    }
  
  };

  const spViewCommandBarSearchBoxStyle = {
    root: {
      width: "220px"
    }
  };

  export interface ISharePointListItem {
    id: number,
    siteName: string,
    siteType: string,
    tenant: string,
    url: string
  
  }

  export class Custom01 extends React.Component {

    private overflowProps: IButtonProps = { ariaLabel: 'More commands' };
  
    private _navItems: ICommandBarItemProps[] = [
    {
      key: 'NewSharePointSiteChoice',
      text: 'Agregar',
      cacheKey: 'spSiteChoice', // changing this key will invalidate this item's cache
      iconProps: { iconName: 'Add' },
      subMenuProps: {
        items: [
          {
            key: 'spSiteCreatePortal',
            text: 'Portal',
            iconProps: { iconName: 'GlobeIcon' }          
          },
          {
            key: 'spSiteSelectTeamsite',
            text: 'Area de Trabajo',
            iconProps: { iconName: 'GlobeIcon' },
            items: [
              {
                key: 'spSiteTeamSiteWithoutWorkGroup',
                text: 'Area de trabajo sin buzón de grupo',
                iconProps: { iconName: 'GlobeIcon'},
              },
              {
                key: 'spTeamSiteWithWorkGroup',
                  text: 'Area de trabajo sin buzón de grupo',
                iconProps: { iconName: 'GlobeIcon'},
              }
            ]
          },
        ],
      },
    },
    {
      key: 'upload',
      text: 'Cargar',
      iconProps: { iconName: 'Upload' },
      href: '/',
    },
    {
      key: 'share',
      text: 'Compartir',
      iconProps: { iconName: 'Share' },
      onClick: () => console.log('Share'),
    },
    {
      key: 'download',
      text: 'Descargar',
      iconProps: { iconName: 'Download' },
      onClick: () => console.log('Download'),
    },
  ];
  
  private _navFarItems: ICommandBarItemProps[] = [
    {
      key: 'spViewSearch',
      onRender: () => {
        return(<SearchBox className="searchBox" styles={spViewCommandBarSearchBoxStyle} />);
  
      }
    },
    {
      key: 'tile',
      text: 'Vista de cuadricula',
      // This needs an ariaLabel since it's icon-only
      ariaLabel: 'Grid view',
      iconOnly: true,
      iconProps: { iconName: 'Tiles' },
      onClick: () => console.log('Tiles'),
    },
    {
      key: 'info',
      text: 'Info',
      // This needs an ariaLabel since it's icon-only
      ariaLabel: 'Info',
      iconOnly: true,
      iconProps: { iconName: 'Info' },
      onClick: () => console.log('Info'),
    },
  ];
  
  
    private _columns: IColumn[];
    private _items: ISharePointListItem[];
  
  
    constructor(props: {}) {
      super(props);
  
      this._columns = [
        { key: 'colSiteName', name: 'fila1', fieldName: 'siteName', minWidth: 100, maxWidth: 200, isResizable: true },
        { key: 'colSiteType', name: 'fila2', fieldName: 'siteType', minWidth: 100, maxWidth: 200, isResizable: true },
        { key: 'colTenant', name: 'fila3', fieldName: 'tenant', minWidth: 100, maxWidth: 200, isResizable: true }
      ];
  
      this._items = [
        { id: 1, siteName: "Sitename 1", siteType: "Portal", tenant: "Tenant 1", url: "https://tenant1.sharepoint.com" },
        { id: 2, siteName: "Sitename 2", siteType: "Portal", tenant: "Tenant 2", url: "https://tenant2.sharepoint.com" },
        { id: 3, siteName: "Sitename 3", siteType: "Arbeitsbereich", tenant: "Teams", url: "https://teams.sharepoint.com" },
        { id: 4, siteName: "Sitename 4", siteType: "Portal", tenant: "Teams", url: "https://teams.sharepoint.com" },
        { id: 5, siteName: "Sitename 5", siteType: "Arbeitsbereich", tenant: "Tenant 3", url: "https://tenant3.sharepoint.com" },
        { id: 6, siteName: "Sitename 6", siteType: "Portal", tenant: "Tenant 1", url: "https://tenant1.sharepoint.com" },
  
  
      ];
  
    }
  
  
  
    render = () => {
  
      
  
      return(
        <Stack styles={spViewContainerStyle}>
          <Stack.Item styles={spViewTitleAreaStyle}><h2>Esto es una prueba</h2></Stack.Item>
          <Stack.Item styles={spViewCommandBarStyle}>
              <CommandBar
              items={this._navItems}
              overflowButtonProps={this.overflowProps}
              farItems={this._navFarItems}
              ariaLabel="Use left and right arrow keys to navigate between commands"/>    
          </Stack.Item>
          <Stack.Item>
            <DetailsList items={this._items} columns={this._columns} layoutMode={DetailsListLayoutMode.justified} />
          </Stack.Item>
        </Stack>
        );
  
    }
  
  
  }

  export default Custom01;

  export class DeactivatedSharePointView extends React.Component {

    render = () => {
  
  
      return(<div><h2>WebApplication</h2></div>);
  
    }
  
  
  }