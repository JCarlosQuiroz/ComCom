import { Redirect } from "react-router";

export default function RedirectHome(){
    return <Redirect to={{pathname: '/'}} />
}