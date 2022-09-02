import { IColumn, ICommandBarItemProps } from "@fluentui/react";

export class IUsers {
  constructor(
    public username: string,
    public first_name: string,
    public last_name: string,
    public email: string,
    public date_joined: Date,
    public last_login: Date,
    public is_active: boolean,
    public user_permissions: string
  ) {}
}

export const userColumns: IColumn[] = [
  {
    key: "username",
    name: "Usuario",
    fieldName: "username",
    minWidth: 100,
    maxWidth: 100,
    isResizable: true,
    data: "string",
    isSorted: true,
    isSortedDescending: true,
    sortAscendingAriaLabel: "Sorted A to Z",
    sortDescendingAriaLabel: "Sorted Z to A",
    onRender: (item: IUsers) => {
      return item.username;
    },
  },
  {
    key: "first_name",
    name: "Nombre",
    fieldName: "first_name",
    minWidth: 100,
    maxWidth: 200,
    isResizable: true,
    data: "string",
    isSorted: true,
    isSortedDescending: true,
    sortAscendingAriaLabel: "Sorted A to Z",
    sortDescendingAriaLabel: "Sorted Z to A",
    onRender: (item: IUsers) => {
      return item.first_name.concat(" ").concat(item.last_name);
    },
  },
  {
    key: "last_name",
    name: "Apellidos",
    fieldName: "last_name",
    minWidth: 100,
    maxWidth: 200,
    isResizable: true,
    data: "string",
    isSorted: true,
    isSortedDescending: true,
    sortAscendingAriaLabel: "Sorted A to Z",
    sortDescendingAriaLabel: "Sorted Z to A",
  },
  {
    key: "email",
    name: "Correo Electronico",
    fieldName: "email",
    minWidth: 100,
    maxWidth: 200,
    isResizable: true,
    data: "string",
    isSorted: true,
    isSortedDescending: true,
    sortAscendingAriaLabel: "Sorted A to Z",
    sortDescendingAriaLabel: "Sorted Z to A",
  },
  {
    key: "date_joined",
    name: "Alta",
    fieldName: "date_joined",
    minWidth: 100,
    maxWidth: 200,
    isResizable: true,
    data: "string",
    isSorted: true,
    isSortedDescending: true,
    sortAscendingAriaLabel: "Sorted A to Z",
    sortDescendingAriaLabel: "Sorted Z to A",
  },
  {
    key: "last_login",
    name: "Fecha de Registro",
    fieldName: "last_login",
    minWidth: 100,
    maxWidth: 200,
    isResizable: true,
    data: "string",
    isSorted: true,
    isSortedDescending: true,
    sortAscendingAriaLabel: "Sorted A to Z",
    sortDescendingAriaLabel: "Sorted Z to A",
  },
  {
    key: "is_active",
    name: "Estado",
    fieldName: "is_active",
    minWidth: 100,
    maxWidth: 200,
    isResizable: true,
    data: "string",
    isSorted: true,
    isSortedDescending: true,
    sortAscendingAriaLabel: "Sorted A to Z",
    sortDescendingAriaLabel: "Sorted Z to A",
  },
  {
    key: "user_permissions",
    name: "Roles",
    fieldName: "user_permissions",
    minWidth: 100,
    maxWidth: 200,
    isResizable: true,
    data: "string",
    isSorted: true,
    isSortedDescending: true,
    sortAscendingAriaLabel: "Sorted A to Z",
    sortDescendingAriaLabel: "Sorted Z to A",
  },
  {
    key: "commands",
    name: "Acciones",
    fieldName: "commands",
    minWidth: 100,
    maxWidth: 200,
    isResizable: true,
    data: "string",
  },
];



export const _navItems: ICommandBarItemProps[] = [
  {
    key: "NewProved",
    text: "Nuevo Usuario",
    cacheKey: "NewProved", // changing this key will invalidate this item's cache
    iconProps: { iconName: "Add" },
  },
  {
    key: "EditProved",
    text: "Editar Usuario",
    cacheKey: "EditProved", // changing this key will invalidate this item's cache
    iconProps: { iconName: "Edit" },
  },
  {
    key: "DeleteProved",
    text: "Eliminar Usuario",
    cacheKey: "DeleteProved", // changing this key will invalidate this item's cache
    iconProps: { iconName: "Delete" },
  },
];

// Language: typescript
