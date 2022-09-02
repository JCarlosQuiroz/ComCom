import { ProgressIndicator } from "@fluentui/react";

import React from "react";


const intervalDelay = 100;
const intervalIncrement = 0.01;


export const ProgressIndicatorNav: React.FunctionComponent = () => {
    const [percentComplete, setPercentComplete] = React.useState(0);

    React.useEffect(() => {
        const id = setInterval(() => {
            setPercentComplete((intervalIncrement + percentComplete) % 1);
        }, intervalDelay);
        return () => clearInterval(id);
    },);

    return (
        <div>
            <ProgressIndicator percentComplete={percentComplete}  />


            <ProgressIndicator label="Cargando" description="Porfavor espere ..." />



        </div>


    );
}

export default ProgressIndicatorNav;