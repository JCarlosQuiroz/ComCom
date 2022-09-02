import notify from "./notifier";
import axios from "axios";

export const setAuthToLocalStorage = (auth: {
  access: any;
  refresh: any;
  permissions: any;
  first_name: any;
  last_name: any;
  username: any;
  email: any;
  is_superuser: any;
  is_staff: any;
}) => {
  try {
    const token_access = auth.access;
    const token_refresh = auth.refresh;
    const token_permissions = auth.permissions;
    const user = {
      first_name: auth.first_name,
      last_name: auth.last_name,
      username: auth.username,
      email: auth.email,
      is_superuser: auth.is_superuser,
      is_staff: auth.is_staff,
    };
    localStorage.setItem("token_access", token_access);
    localStorage.setItem("token_refresh", token_refresh);
    localStorage.setItem("token_permissions", token_permissions);
    localStorage.setItem("user", JSON.stringify(user));

    axios.defaults.headers.common.Accept = "application/json";
    axios.defaults.headers.common = {
      Authorization: "Bearer " + localStorage.getItem("token_access"),
    };
  } catch (error) {
    notify({ message: "Error setting user to local storage" });
  }
};
export function getAuthToLocalStorage() {
  try {
    axios.defaults.headers.common.Accept = "application/json";
    axios.defaults.headers.common = {
      Authorization: "Bearer " + localStorage.getItem("token_access"),
    };
  } catch (e) {
    //   notify("Error al cargar las credenciales del el Local Storage.");
    notify({
      message: "Error al cargar las credenciales del el Local Storage.",
    });
  }
}
export function cleanAuthToLocalStorage() {
  try {
    localStorage.removeItem("token_access");
    localStorage.removeItem("token_refresh");
    localStorage.removeItem("token_permissions");
    localStorage.removeItem("user");

    axios.defaults.headers.common.Accept = "application/json";
    axios.defaults.headers.common = {
      Authorization: "Bearer " + localStorage.getItem("token_access"),
    };
  } catch (e) {}
}
export function isAuthenticated() {
  return localStorage.getItem("token_access") !== null ? true : false;
}
export function findPermissionInLocalStore(permission: string) {
  let permissionLocalStorage = localStorage.getItem("token_permissions");
  let result = false;

  if (permissionLocalStorage != null) {
    let permissions = JSON.parse(permissionLocalStorage);
    if (permissions.indexOf(permission) > -1) {
      result = true;
    }

    permissions.forEach((value: string) => {
      if (value === permission) {
        result = true;
      }
    });
  }
  return result;
}
