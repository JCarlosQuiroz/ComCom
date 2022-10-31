import { About } from "../pages/About";


import { Profile } from "../pages/Profile";
import { ProfileData } from "../pages/ProfileData";
import CatAlmacenes from "../ui-components/CatalogosComponents/CatAlmacenes";
import CatProved from "../ui-components/CatalogosComponents/CatProved";
import ShowClients from "../ui-components/ClientListComponents/ShowClients";
import CuartoFrioMain from "../ui-components/CuartoFrioComponents/CuartoFrioMain";
import Counter from "../ui-components/CustomTestComponents/Counter";
import Custom01 from "../ui-components/CustomTestComponents/Custom01";
// import FetchData from "../ui-components/CustomTestComponents/FetchData";
import MyFiles from "../ui-components/CustomTestComponents/MyFiles";
import UserRequire from "../ui-components/CustomTestComponents/UserRequire";
import { EmpaqueMain } from "../ui-components/EmpaqueComponents/EmpaqueMain";
import PageContainer from "../utils/PagesContainer";
import RedirectHome from "../utils/RedirectHome";
import Contabilidad from "../ui-components/ContabilidadComponents/Contabilidad";
import CardsSection from "../ui-components/CustomTestComponents/CardsSection";
import Clients from "../ui-components/CustomTestComponents/Clients";
import { ActiveGroupsView } from "../ui-components/CustomTestComponents/Groups";
import { ProgressIndicator } from "@fluentui/react";
import { UserAvatar } from "../ui-components/CustomTestComponents/UserAvatar";
import WelcomeName from "../ui-components/CustomTestComponents/WelcomeName";
import ZeroDriveUI from "../ui-components/CustomTestComponents/ZeroDriveUI";
import { ShowFactsPendsComponent } from "../ui-components/FactsPendsComponents/ShowFactsPendsComponents";
import { OxxoPaysComponent } from "../ui-components/OxxoPaysComponent/OxxoPaysComponent";
import { SystemPaysView } from "../ui-components/RapPaysComponents/SystemPays";


import Dashboard from "../pages/Dashboard";
import Users from "../pages/Users";
import { Home } from "../pages/Home";
// import MainMenu from "../ui-components/MainMenu";
import NavMenuCustom from "../ui-components/CustomTestComponents/NavMenuCustom";
import { MainMenu } from "../ui-components/MainMenu";
import { FetchData } from "../ui-components/CustomTestComponents/FetchData";
import Count from "../ui-components/CustomTestComponents/Count";
import Forecast from "../ui-components/CustomTestComponents/Forecast";
import { ChatInterface } from "../modules/office/infrastructure/components/Teams/Teams";

const routes = [
    { path: "/users", component: Users},
    { path : "/about", component : About },
    { path : "/dashboard", component : Dashboard },
    { path : "/fetchdata", component : FetchData },
    { path : "/pagecontainer", component : PageContainer },
    { path : "/empaque", component : EmpaqueMain },
    { path : "/counter", component: Counter },
    { path : "/onedrive", component: MyFiles },
    { path : "/catproved", component: CatProved },
    { path : "/catalmacenes", component: CatAlmacenes },
    { path : "/cuartofrio", component: CuartoFrioMain },
    { path : "/solicitudes", component:  UserRequire},
    { path : "/sharepoint", component: Custom01 },
    { path : "/profile", component: Profile },
    { path : "/profiledata", component: ProfileData },
    { path : "/catclientes", component: ShowClients },
    { path : "/contabilidad", component: Contabilidad },
    { path : "/cardsection", component:  CardsSection},
    { path : "/clients", component:  Clients},
    { path : "/groups", component: ActiveGroupsView },
    { path : "/progres", component: ProgressIndicator },
    { path : "/avatar", component: UserAvatar },
    { path : "/welcome", component: WelcomeName },
    { path : "/zero", component:  ZeroDriveUI},
    { path : "/facturas", component: ShowFactsPendsComponent},
    { path : "/pays", component:  SystemPaysView},
    { path : "/oxxo", component: OxxoPaysComponent },
    { path : "/mainmenu", component: MainMenu },
    { path : "/navmenucustom", component: NavMenuCustom },
    { path : "/forecast", component: Forecast },
    { path : "/custom", component: Count }, 
    { path : "/teams", component: ChatInterface },
    // { path : "/", component:  },
    // { path : "/", component:  },
    // { path : "/", component:  },
    // { path : "/", component:  },
    // { path : "/", component:  },
    // { path : "/", component:  },




    { path: "/", component: Home, exact: true },
    { path: "*", component: RedirectHome},
];


export default routes;