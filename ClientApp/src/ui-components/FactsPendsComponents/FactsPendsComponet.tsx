import React from 'react';
import { PrimaryButton } from '@fluentui/react'; 


export class FactsPendsComponent extends React.Component {


    render = () => {
    
        return (
            
         <div>
                <br/>
         <PrimaryButton onClick={onclick}>Listado de Facturas Pendientes</PrimaryButton>
        </div>
        );
        function onclick() {
            alert('this is works');
        }
    }
}
