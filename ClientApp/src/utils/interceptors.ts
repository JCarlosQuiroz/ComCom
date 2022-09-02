import axios from 'axios';
import { cleanAuthToLocalStorage } from './user-local-storage-state-hooks';

export const InterceptorsResponse = () => {
    axios.interceptors.response.use(
      function (successRes) {
        return successRes;
      },
      function (error) {
        if (error.response.status === '401') {
          cleanAuthToLocalStorage();
          throw Error("Session expirada inicie session de nuevo");
        } if (error.response.status === '550') {
          throw Error("Ha ocurrido un error y se ha notificado via email a soporte");
        } else {
          return Promise.reject(error);
        }
      }
    );
  };