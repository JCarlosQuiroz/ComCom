import { createTheme, ISeparatorStyles } from "@fluentui/react"
import grecosLogo from '../assets/img/logos/grecoLogo.png';
import sunsetLogo from '../assets/img/logos/sunsetCustom.png';
import valhpacLogo00 from '../assets/img/logos/Logotipo Valhpac Horizontal.png';
import valhpacLogo01 from '../assets/img/logos/Logotipo Valhpac Horizontal01.png';
import product00 from '../assets/img/logos/cucumber03.png';
import product01 from '../assets/img/logos/peppers.png';
import product02 from '../assets/img/logos/tomato.png';
import product03 from '../assets/img/logos/tomatoes.png';
import product04 from '../assets/img/logos/berenjena.png';
import cucumber01 from '../assets/img/logos/cucumber04.jpg';
import tomate01 from '../assets/img/logos/tomate2.jpg';
import avatar01 from '../assets/img/avatars/avatar-1.png';
import avatar02 from '../assets/img/avatars/avatar-2.png';
import avatar03 from '../assets/img/avatars/avatar-3.png';
import avatar04 from '../assets/img/avatars/avatar-4.png';
import avatar05 from '../assets/img/avatars/avatar-5.png';
import avatar06 from '../assets/img/avatars/avatar-6.png';
import imgNotFound from '../assets/img/logos/imageNotFound.png';
import frello from '../assets/img/logos/frelloLogo.png';
import pureFlavor from '../assets/img/logos/pureflavorLogo.svg';
import profileUser from '../assets/img/icons/HelpDesk.png';
import sunnyfreshLogo from '../assets/img/logos/sunnyfresh.png';
import elmoroLogo from '../assets/img/logos/elmoro.png';
import vikingosLogo from '../assets/img/logos/vikingos.jpg';
import triplehLogo from '../assets/img/logos/tripleh .png';
import empaque from '../assets/img/logos/empaque.png';
import pinTomato from '../assets/img/logos/pin.svg';
import madeinmx from '../assets/img/logos/iconmx.jpg';
import administracion from '../assets/img/icons/Administración.png';
import cuentasxcobrar from '../assets/img/icons/CuentasPorCobrar.png';
import ecommerce from '../assets/img/icons/Ecommerce.png';
import finanzas from '../assets/img/icons/Finanzas.png';
import helpdesk from '../assets/img/icons/HelpDesk.png';
import logistica from '../assets/img/icons/Logistica.png';
import marketing from '../assets/img/icons/Marketing.png';
import metodosdepago from '../assets/img/icons/MetodosdePago.png';
import recursoshumanos from '../assets/img/icons/RecursosHumanos.png';
import ventas from '../assets/img/icons/Ventas.png';
import contabilidad from '../assets/img/icons/Contabilidad.png';
import money from '../assets/img/icons/gettotal.png';
import tractor from '../assets/img/icons/tractor.png';
import pc from '../assets/img/icons/pc.png';
import pc1 from '../assets/img/icons/pc2.png';
import empaque1 from '../assets/img/icons/empaque.png';
import logoSide from '../assets/img/icons/solutions.png';
import azureActiveDirectory from '../assets/img/icons/azureActiveDirectory.png';
import azureActiveDirectoryB2C from '../assets/img/icons/azureActiveDirectoryB2C.png';
import pslogo from '../assets/img/logos/prevensano.png';
import serdilogo from '../assets/img/logos/Logotipo Serdi Vertical.png';
import gmlogo from '../assets/img/logos/Grupo Modelo Logo.png';
import solutionslogo from '../assets/img/icons/solutions.png';
import comcomlogo from '../assets/img/icons/logo.svg';
import comcomlogo1 from '../assets/img/icons/2- Logo Business Com.svg';
import comcomlogo2 from '../assets/img/icons/3- Logo Home Com.svg';
import comcomlogo3 from '../assets/img/icons/7- Logo Home Com.svg';
import comcomlogo4 from '../assets/img/icons/8-iconos paquete master.svg';
import comcomlogo5 from '../assets/img/icons/8-iconos paquete streaming.svg';
import comcomlogo6 from '../assets/img/icons/9-control.svg';
import comcomlogo7 from '../assets/img/icons/10-  dispositivo movil.svg';
import comcomlogo8 from '../assets/img/icons/business.svg';
import comcomlogo9 from '../assets/img/icons/logo_blanco.svg';
import comcomlogo10 from '../assets/img/icons/excel_20x1.svg';
import navbarLogo from '../assets/img/icons/logo.svg';
import outlookLogo from '../assets/img/icons/outlook_20x1.svg';
import excelLogo from '../assets/img/icons/excel_20x1.svg';
import powerBiLogo from '../assets/img/icons/powerbi_20x1.svg';
import powerPointLogo from '../assets/img/icons/powerpoint_20x1.svg';
import wordLogo from '../assets/img/icons/word_20x1.svg';
import sharePointLogo from '../assets/img/icons/sharepoint_20x1.svg';
import teamsLogo from '../assets/img/icons/teams_20x1.svg';
import onedriveLogo from '../assets/img/icons/onedrive_20x1.svg';
import onenoteLogo from '../assets/img/icons/onenote_20x1.svg';
import todoLogo from '../assets/img/icons/todo_20x1.svg';
import reportsLogo from '../assets/img/icons/reports_20x1.svg';
export const Theme = createTheme({
    palette: {
        themePrimary: '#f15a32',
        themeLighterAlt: '#fef8f6',
        themeLighter: '#fde4dd',
        themeLight: '#fbcdc0',
        themeTertiary: '#f79c82',
        themeSecondary: '#f46f4a',
        themeDarkAlt: '#da532e',
        themeDark: '#b84627',
        themeDarker: '#88341c',
        neutralLighterAlt: '#faf9f8',
        neutralLighter: '#f3f2f1',
        neutralLight: '#edebe9',
        neutralQuaternaryAlt: '#e1dfdd',
        neutralQuaternary: '#d0d0d0',
        neutralTertiaryAlt: '#c8c6c4',
        neutralTertiary: '#dadadc',
        neutralSecondary: '#b6b5b9',
        neutralSecondaryAlt: '#b6b5b9',
        neutralPrimaryAlt: '#959498',
        neutralPrimary: '#87868a',
        neutralDark: '#666669',
        black: '#4b4b4d',
        white: '#ffffff',
      }});

     export const ISepStyles: ISeparatorStyles = {
        root: {
          backgroundColor: Theme.palette.themePrimary,
          height: 2,
          width: '100%',
          marginTop: 20,
          marginBottom: 40,
        },
        content: {
          fontSize: '35px',
          fontWeight: '400',
          fontStyle: 'normal',
          color: Theme.palette.neutralPrimary,
          bottom: 30,
        },
      }

export const Images = {
  todoLogo,
  onenoteLogo,
  onedriveLogo,
  powerBiLogo,
  teamsLogo,
  excelLogo,
  outlookLogo,
  wordLogo,
  powerPointLogo,
  sharePointLogo,
  reportsLogo,
  navbarLogo,
    solutionslogo,
    azureActiveDirectory,
    azureActiveDirectoryB2C,
    logoSide,
    grecosLogo,
    madeinmx,
    pinTomato,
    empaque,
    sunsetLogo,
    sunnyfreshLogo,
    elmoroLogo,
    vikingosLogo,
    triplehLogo,
    valhpacLogo00,
    valhpacLogo01,
    product00,
    product01,
    product02,
    product03,
    product04,
    cucumber01,
    tomate01,
    avatar01,
    avatar02,
    avatar03,
    avatar04,
    avatar05,
    avatar06,
    imgNotFound,
    frello,
    pureFlavor,
    profileUser,
    contabilidad,
    administracion,
    cuentasxcobrar,
    ecommerce,
    finanzas,
    helpdesk,
    logistica,
    marketing,
    metodosdepago,
    recursoshumanos,
    ventas,
    tractor,
    pc,
    pc1,
    money,
    empaque1,
    pslogo,
    serdilogo,
    gmlogo,
    comcomlogo,
    comcomlogo1,
    comcomlogo2,
    comcomlogo3,
    comcomlogo4,
    comcomlogo5,
    comcomlogo6,
    comcomlogo7,
    comcomlogo8,
    comcomlogo9,
    comcomlogo10,
};