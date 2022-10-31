import { IBreadcrumbItem, Icon, IDividerAsProps, ILabelStyles, TooltipHost } from "@fluentui/react";
import { useHistory } from "react-router-dom";


export const labelStyles: Partial<ILabelStyles> = {
    root: { margin: '10px 0', selectors: { '&:not(:first-child)': { marginTop: 24 } } },
  };
 export const itemsWithHref: IBreadcrumbItem[] = [
    // Normally each breadcrumb would have a unique href, but to make the navigation less disruptive
    // in the example, it uses the breadcrumb page as the href for all the items
    { text: 'Utilidades y Servicios', key: 'UandS', href: '/MenuSolution' },
    { text: 'Catalogo Almacenes', key: 'f1', href: '/CatAlmacenes', isCurrentItem: true },
    { text: 'Catalogo Proveedores', key: 'f2', href: '/CatProved',isCurrentItem: true },
    { text: 'Folder 3', key: 'f3', href: '/Counter' },
    { text: 'Folder 5', key: 'f5', href: '#/controls/web/breadcrumb', isCurrentItem: true },
  ];
  export const itemsWithHeading: IBreadcrumbItem[] = [
    { text: 'Utilidades y Servicios', key: 'Utilidades', onClick: (ev?: React.MouseEvent<HTMLElement>, item?: IBreadcrumbItem) => Navigate()('/MenuSolution') },
    { text: 'Contador', key: 'Counter', isCurrentItem: true },
    
  ];

  function Navigate() {
    const history = useHistory();
    const navigateTo = (path: string) => history.push(path);
    return navigateTo;
  }

  export function _onBreadcrumbItemClicked(ev: React.MouseEvent<HTMLElement>, item: IBreadcrumbItem): void {
    console.log(`Breadcrumb item with key "${item.key}" has been clicked.`);
  }

 export function _getCustomDivider(dividerProps: IDividerAsProps): JSX.Element {
    const tooltipText = dividerProps.item ? dividerProps.item.text : '';
    return (
      <TooltipHost content={`Show ${tooltipText} contents`} calloutProps={{ gapSpace: 0 }}>
        <Icon iconName="ChevronRight" {...dividerProps} />
      </TooltipHost>
    );
  }
  
 export function _getCustomOverflowIcon(): JSX.Element {
    return <Icon iconName={'ChevronDown'} />;
  }
   export const itemsWithoutHref: IBreadcrumbItem[] = [
    { text: 'Files', key: 'Files' },
    { text: 'Folder 1', key: 'f1' },
    { text: 'Folder 2', key: 'f2' },
    { text: 'Folder 3', key: 'f3' },
    { text: 'Folder 4 (non-clickable)', key: 'f4' },
    { text: 'Folder 5', key: 'f5', isCurrentItem: true },
    ];
  export  const itemsWithIcon: IBreadcrumbItem[] = [
    { text: 'Files', key: 'Files', href: '#/controls/web/breadcrumb', },
    { text: 'Folder 1', key: 'f1', href: '#/controls/web/breadcrumb',  },
    { text: 'Folder 2', key: 'f2', href: '#/controls/web/breadcrumb',  },
    { text: 'Folder 3', key: 'f3', href: '#/controls/web/breadcrumb',  },
    { text: 'Folder 4 (non-clickable)', key: 'f4',  },
    { text: 'Folder 5', key: 'f5', href: '#/controls/web/breadcrumb', isCurrentItem: true },
    ];
 export   const itemsWithIconAndHref: IBreadcrumbItem[] = [
    { text: 'Files', key: 'Files', href: '#/controls/web/breadcrumb',  },
    { text: 'Folder 1', key: 'f1', href: '#/controls/web/breadcrumb',  },
    { text: 'Folder 2', key: 'f2', href: '#/controls/web/breadcrumb',  },
    { text: 'Folder 3', key: 'f3', href: '#/controls/web/breadcrumb',  },
    { text: 'Folder 4 (non-clickable)', key: 'f4',  },
    { text: 'Folder 5', key: 'f5', href: '#/controls/web/breadcrumb' , isCurrentItem: true },
    ];
export    const itemsWithIconAndHrefAndOnClick: IBreadcrumbItem[] = [
    { text: 'Files', key: 'Files', href: '#/controls/web/breadcrumb' , onClick: () => { alert('Files'); } },
    { text: 'Folder 1', key: 'f1', href: '#/controls/web/breadcrumb' , onClick: () => { alert('Folder 1'); } },
    { text: 'Folder 2', key: 'f2', href: '#/controls/web/breadcrumb' , onClick: () => { alert('Folder 2'); } },
    { text: 'Folder 3', key: 'f3', href: '#/controls/web/breadcrumb' , onClick: () => { alert('Folder 3'); } },
    { text: 'Folder 4 (non-clickable)', key: 'f4',  },
    { text: 'Folder 5', key: 'f5', href: '#/controls/web/breadcrumb' , isCurrentItem: true },
    ];
 export   const itemsWithIconAndHrefAndOnClickAndTitle: IBreadcrumbItem[] = [
    { text: 'Files', key: 'Files', href: '#/controls/web/breadcrumb' , onClick: () => { alert('Files'); }, title: 'Files' },
    { text: 'Folder 1', key: 'f1', href: '#/controls/web/breadcrumb' , onClick: () => { alert('Folder 1'); }, title: 'Folder 1' },
    { text: 'Folder 2', key: 'f2', href: '#/controls/web/breadcrumb' , onClick: () => { alert('Folder 2'); }, title: 'Folder 2' },
    { text: 'Folder 3', key: 'f3', href: '#/controls/web/breadcrumb' , onClick: () => { alert('Folder 3'); }, title: 'Folder 3' },
    { text: 'Folder 4 (non-clickable)', key: 'f4',  title: 'Folder 4' },
    { text: 'Folder 5', key: 'f5', href: '#/controls/web/breadcrumb' , isCurrentItem: true },
    ];
  export  const itemsWithIconAndHrefAndOnClickAndTitleAndAriaLabel: IBreadcrumbItem[] = [
    { text: 'Files', key: 'Files', href: '#/controls/web/breadcrumb',  onClick: () => { alert('Files'); }, title: 'Files',  },
    { text: 'Folder 1', key: 'f1', href: '#/controls/web/breadcrumb',  onClick: () => { alert('Folder 1'); }, title: 'Folder 1',  },
    { text: 'Folder 2', key: 'f2', href: '#/controls/web/breadcrumb',  onClick: () => { alert('Folder 2'); }, title: 'Folder 2',  },
    { text: 'Folder 3', key: 'f3', href: '#/controls/web/breadcrumb',  onClick: () => { alert('Folder 3'); }, title: 'Folder 3', },
    { text: 'Folder 4 (non-clickable)', key: 'f4' , title: 'Folder 4'  },
    { text: 'Folder 5', key: 'f5', href: '#/controls/web/breadcrumb',  isCurrentItem: true },
    ];
