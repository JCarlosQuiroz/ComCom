import * as React from 'react';
import { CommandBarButton, IOverflowSetItemProps, OverflowSet,DirectionalHint, TooltipHost, Stack } from '@fluentui/react';

const noOp = () => undefined;


const onRenderOverflowButtonStyles = {
    root: { padding: '10px' },
    menuIcon: { fontSize: '30px' },
  };
const onRenderItemStyles = {
  root: { padding: '10px' },
    item: {
        color: '#00a54f',
        backgroundColor: '#674186',
        border: '1px solid #ddd',
        borderRadius: '4px',
        padding: '10px',
        marginBottom: '10px',
        width: '250px',
        height: '250px',
        display: 'flex',
        justifyContent: 'center',
        alignItems: 'center',
        flexDirection: 'column',
        textAlign: 'center',
        cursor: 'pointer',
        userSelect: 'none',
        '&:hover': {
            backgroundColor: '#674186',
        },
    },
    content: {
        fontSize: '35px',
        fontWeight: "400",
        fontStyle: "normal",
        color: "#00a54f",
        bottom: 30,
    },
    icon: {
        fontSize: '30px',
        color: '#674186',
    },
};


const onRenderItem = (item: IOverflowSetItemProps): JSX.Element => {
  return (
    <TooltipHost content={item.title} directionalHint={DirectionalHint.rightCenter}>
      <CommandBarButton
        role="menuitem"
        aria-label={item.name}
        styles={onRenderItemStyles}
        iconProps={{ iconName: item.icon }}
        onClick={item.onClick}
      />
    </TooltipHost>
  );
};

const onRenderOverflowButton = (overflowItems: any[] | undefined): JSX.Element => {
  return (
    <TooltipHost content="More items" directionalHint={DirectionalHint.rightCenter}>
      <CommandBarButton
        role="menuitem"
        aria-label="More items"
        styles={onRenderOverflowButtonStyles}
        menuIconProps={{ iconName: 'AppIconDefaultList' }}
        menuProps={{ items: overflowItems! }}
      />
    </TooltipHost>
  );
};

export const SideMenu: React.FunctionComponent = () => (
    <Stack horizontalAlign="start" verticalAlign="baseline" tokens={{ maxHeight: 5,maxWidth:205 }}>
  <OverflowSet
    aria-label="Vertical sidebar"
    role="menubar"
    vertical
    items={[
      {
        key: 'Inicio',
        icon: 'Home',
        name: 'Inicio',
        title: 'Inicio',
        ariaLabel: 'Inicio',
        onClick: noOp,
      },
      {
        key: 'Add',
        icon: 'AddTo',
        name: 'Agregar',
        title: 'Agregar',
        onClick: noOp,
      },
      {
        key: 'Mis Datos',
        icon: 'FolderList',
        name: 'Mis Datos',
        title: 'Mis Datos',
        onClick: noOp,
      },
        {
            key: 'Outlook',
            icon: 'OutlookLogo',
            name: 'Outlook',
            title: 'Outlook',
            onClick: noOp,
        },
        {
            key: 'OneNote',
            icon: 'OneNoteLogo',
            name: 'OneNote',
            title: 'OneNote',
            onClick: noOp,
        },
        {
            key: 'Teams',
            icon: 'TeamsLogo',
            name: 'Teams',
            title: 'Teams',
            onClick: noOp,
        },
        {
            key: 'Word',
            icon: 'WordLogo',
            name: 'Word',
            title: 'Word',
            onClick: noOp,
        },
        {
            key: 'Excel',
            icon: 'ExcelLogo',
            name: 'Excel',
            title: 'Excel',
            onClick: noOp,
        },
        {
            key: 'PowerPoint',
            icon: 'PowerPointLogo',
            name: 'PowerPoint',
            title: 'PowerPoint',
            onClick: noOp,
        },
        {
            key: 'SharePoint',
            icon: 'SharepointLogo',
            name: 'SharePoint',
            title: 'SharePoint',
            onClick: noOp,
        },
        {
            key: 'PowerBI Reports',
            icon: 'PowerBILogo',
            name: 'PowerBI Reports',
            title: 'PowerBI Reports',
            onClick: noOp,
        },
    ]}
    overflowItems={[
      {
        key: 'Tool1',
        name: 'Tool1',
        onClick: noOp,
      },
      {
        key: 'Tool2',
        name: 'Tool2',
        onClick: noOp,
      },
    ]}
    onRenderOverflowButton={onRenderOverflowButton}
    onRenderItem={onRenderItem}
  />
</Stack>
);
export default SideMenu;