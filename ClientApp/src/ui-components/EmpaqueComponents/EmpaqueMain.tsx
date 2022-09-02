import { Separator, Stack } from "@fluentui/react";

import * as React from "react";
import { ISepStyles, Theme } from "../../styles/Theme";
import CuartoFrioModal from "../CuartoFrioComponents/CuartoFrioModal";



export function EmpaqueMain() {
    
    return (
        <Stack horizontalAlign='center' tokens={{ padding: '10px 0px 0px 0px', childrenGap: '3%', maxHeight: '100%', maxWidth: '100%' }}>
            <Separator theme={Theme} styles={ISepStyles}>Empaque</Separator>
            <Stack horizontalAlign='center' horizontal wrap tokens={{ padding: '0px 0px 0px 0px', childrenGap: 20 }}>
                <CuartoFrioModal />
            </Stack>
        </Stack>
    );
};
