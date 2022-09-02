import { IDocumentCardStyles, DocumentCard, DocumentCardDetails, DocumentCardImage, DocumentCardTitle, ImageFit, Stack } from '@fluentui/react';
import Contabilidad from '../../assets/img/icons/Contabilidad.png';
import Administracion from '../../assets/img/icons/Administración.png';

import RecursosHumanos from '../../assets/img/icons/RecursosHumanos.png';
import CuentasporCobrar from '../../assets/img/icons/CuentasPorCobrar.png';
import Ecommerce from '../../assets/img/icons/Ecommerce.png';
import Finanzas from '../../assets/img/icons/Finanzas.png';
import HelpDesk from '../../assets/img/icons/HelpDesk.png';
import Logistica from '../../assets/img/icons/Logistica.png';
import Marketing from '../../assets/img/icons/Marketing.png';
import Ventas from '../../assets/img/icons/Ventas.png';


function CardsSection(_props: any) {
  // Component styles
  const cardStyles: IDocumentCardStyles = {
    root: {
      textAlign: 'center',
    }
  };
  return (
    <Stack horizontalAlign='space-evenly' tokens={{ padding: '0px 0px 0px 204px', childrenGap: '5%', maxHeight: '100%', maxWidth: '100%' }}>

      <Stack horizontalAlign='center' verticalAlign='center' tokens={{ childrenGap: 10 }}>

        <h2>Menu Principal</h2>

      </Stack>

      <Stack horizontal wrap tokens={{ padding: '0px 0px 0px 30px', childrenGap: 10 }}>

        <DocumentCard
          styles={cardStyles}
          onClickHref="/contabilidad">
          <DocumentCardImage height={110} imageFit={ImageFit.centerContain} imageSrc={Contabilidad} />
          <DocumentCardDetails />
          <DocumentCardTitle title="Contabilidad" shouldTruncate />

        </DocumentCard>

        <DocumentCard
          styles={cardStyles}
          onClickHref="/clientes">
          <DocumentCardImage height={110} imageFit={ImageFit.centerContain} imageSrc={Administracion} />
          <DocumentCardDetails />
          <DocumentCardTitle title="Administracion" shouldTruncate />

        </DocumentCard>

        <DocumentCard
          styles={cardStyles}
          onClickHref="/clientList/addclient">
          <DocumentCardImage height={110} imageFit={ImageFit.centerContain} imageSrc={RecursosHumanos} />
          <DocumentCardDetails />
          <DocumentCardTitle title="Recursos Humanos" shouldTruncate />

        </DocumentCard>

        <DocumentCard
          styles={cardStyles}
          onClickHref="/clientList/editclient">
          <DocumentCardImage height={110} imageFit={ImageFit.centerContain} imageSrc={Ventas} />
          <DocumentCardDetails />
          <DocumentCardTitle title="Ventas" shouldTruncate />

        </DocumentCard>

        <DocumentCard
          styles={cardStyles}
          onClickHref="/clientList/showclient">
          <DocumentCardImage height={110} imageFit={ImageFit.centerContain} imageSrc={Marketing} />
          <DocumentCardDetails />
          <DocumentCardTitle title="Marketing" shouldTruncate />

        </DocumentCard>

        <DocumentCard
          styles={cardStyles}
          onClickHref="/test6">
          <DocumentCardImage height={110} imageFit={ImageFit.centerContain} imageSrc={Ecommerce} />
          <DocumentCardDetails />
          <DocumentCardTitle title="Ecommerce" shouldTruncate />

        </DocumentCard>

        <DocumentCard
          styles={cardStyles}
          onClickHref="/test7">
          <DocumentCardImage height={110} imageFit={ImageFit.centerContain} imageSrc={CuentasporCobrar} />
          <DocumentCardDetails />
          <DocumentCardTitle title="Credito y Cobranza" shouldTruncate />

        </DocumentCard>

        <DocumentCard
          styles={cardStyles}
          onClickHref="/test8">
          <DocumentCardImage height={110} imageFit={ImageFit.centerContain} imageSrc={HelpDesk} />
          <DocumentCardDetails />
          <DocumentCardTitle title="Help Desk" shouldTruncate />

        </DocumentCard>

        <DocumentCard
          styles={cardStyles}
          onClickHref="/zerodriveUI">
          <DocumentCardImage height={110} imageFit={ImageFit.centerContain} imageSrc={Finanzas} />
          <DocumentCardDetails />
          <DocumentCardTitle title="Finzanzas" shouldTruncate />

        </DocumentCard>

        <DocumentCard
          styles={cardStyles}
          onClickHref="/activeshare">
          <DocumentCardImage height={110} imageFit={ImageFit.centerContain} imageSrc={Logistica} />
          <DocumentCardDetails />
          <DocumentCardTitle title="Logistica" shouldTruncate />

        </DocumentCard>

        <DocumentCard
          styles={cardStyles}
          onClickHref="/almacen">
          <DocumentCardImage height={110} imageFit={ImageFit.centerContain} iconProps={{ iconName: 'Packages', styles: { root: { color: '#6a4d87', fontSize: '70px', width: '70px', height: '70px' } } }} />
          <DocumentCardDetails />
          <DocumentCardTitle title="Almacen" shouldTruncate />

        </DocumentCard>

        <DocumentCard
          styles={cardStyles}
          onClickHref="/activegroup">
          <DocumentCardImage
            height={110}
            imageFit={ImageFit.centerContain}
            iconProps={{ iconName: 'BankSolid', styles: { root: { color: '#6a4d87', fontSize: '70px', width: '70px', height: '70px' } } }}
          />
          <DocumentCardDetails />
          <DocumentCardTitle title="Bancos" shouldTruncate />

        </DocumentCard>

        <DocumentCard
          styles={cardStyles}
          onClickHref="/deactivegroup">
          <DocumentCardImage
            height={110}
            imageFit={ImageFit.centerContain}
            iconProps={{ iconName: 'ShopServer', styles: { root: { color: '#6a4d87', fontSize: '70px', width: '70px', height: '70px' } } }}
          />
          <DocumentCardDetails />
          <DocumentCardTitle title="Compras" shouldTruncate />

        </DocumentCard>

        <DocumentCard
          styles={cardStyles}
          onClickHref="/rapshow">
          <DocumentCardImage
            height={110}
            imageFit={ImageFit.centerContain}
            iconProps={{ iconName: 'Money', styles: { root: { color: '#6a4d87', fontSize: '70px', width: '70px', height: '70px' } } }}
          />
          <DocumentCardDetails />
          <DocumentCardTitle title="Costos" shouldTruncate />

        </DocumentCard>

        <DocumentCard
          styles={cardStyles}
          onClickHref="/empaque">
          <DocumentCardImage
            height={110}
            imageFit={ImageFit.centerContain}
            iconProps={{ iconName: 'Product', styles: { root: { color: '#6a4d87', fontSize: '70px', width: '70px', height: '70px' } } }}
          />
          <DocumentCardDetails />
          <DocumentCardTitle title="Empaque" shouldTruncate />

        </DocumentCard>

        <DocumentCard
          styles={cardStyles}
          onClickHref="/factspend">
          <DocumentCardImage
            height={110}
            imageFit={ImageFit.centerContain}
            iconProps={{ iconName: 'Feedback', styles: { root: { color: '#6a4d87', fontSize: '70px', width: '70px', height: '70px' } } }}
          />
          <DocumentCardDetails />
          <DocumentCardTitle title="Recepcion" shouldTruncate />

        </DocumentCard>

        <DocumentCard
          styles={cardStyles}
          onClickHref="/carpetas">
          <DocumentCardImage
            height={110}
            imageFit={ImageFit.centerContain}
            iconProps={{ iconName: 'AuthenticatorApp', styles: { root: { color: '#6a4d87', fontSize: '70px', width: '70px', height: '70px' } } }}
          />
          <DocumentCardDetails />
          <DocumentCardTitle title="Monitoreo y Seguridad" shouldTruncate />

        </DocumentCard>

        <DocumentCard
          styles={cardStyles}
          onClickHref="/almacen">
          <DocumentCardImage
            height={110}
            imageFit={ImageFit.centerContain}
            iconProps={{ iconName: 'ManagerSelfService', styles: { root: { color: '#6a4d87', fontSize: '70px', width: '70px', height: '70px' } } }}
          />
          <DocumentCardDetails />
          <DocumentCardTitle title="Servicios" shouldTruncate />

        </DocumentCard>

        <DocumentCard
          styles={cardStyles}
          onClickHref="/almacen">
          <DocumentCardImage
            height={110}
            imageFit={ImageFit.centerContain}
            iconProps={{ iconName: 'GroupObject', styles: { root: { color: '#6a4d87', fontSize: '70px', width: '70px', height: '70px' } } }}
          />
          <DocumentCardDetails />
          <DocumentCardTitle title="General" shouldTruncate />

        </DocumentCard>

        <DocumentCard
          styles={cardStyles}
          onClickHref="/almacen">
          <DocumentCardImage
            height={110}
            imageFit={ImageFit.centerContain}
            iconProps={{ iconName: 'Money', styles: { root: { color: '#6a4d87', fontSize: '70px', width: '70px', height: '70px' } } }}
          />
          <DocumentCardDetails />
          <DocumentCardTitle title="Gastos" shouldTruncate />

        </DocumentCard>

        <DocumentCard styles={cardStyles} onClickHref="/etiquetadora">
          <DocumentCardImage height={110} imageFit={ImageFit.centerContain}
            iconProps={{ iconName: 'GenericScan', styles: { root: { color: '#6a4d87', fontSize: '70px', width: '70px', height: '70px' } } }}
          />
          <DocumentCardDetails />
          <DocumentCardTitle title="Etiquetadora" shouldTruncate />


        </DocumentCard>

        <DocumentCard styles={cardStyles} onClickHref='/Catalogos'>
          <DocumentCardImage height={110} imageFit={ImageFit.centerContain}
            iconProps={{ iconName: 'GenericScan', styles: { root: { color: '#6a4d87', fontSize: '70px', width: '70px', height: '70px' } } }}
          />
          <DocumentCardDetails />
          <DocumentCardTitle title="Catalogos" shouldTruncate />



        </DocumentCard>

        <DocumentCard styles={cardStyles} onClickHref='/Reportes'>
          <DocumentCardImage height={110} imageFit={ImageFit.centerContain}
            iconProps={{ iconName: 'GenericScan', styles: { root: { color: '#6a4d87', fontSize: '70px', width: '70px', height: '70px' } } }}
          />
          <DocumentCardDetails />
          <DocumentCardTitle title="Reportes" shouldTruncate />



        </DocumentCard>


      </Stack>

    </Stack>
  );
}

/*const getFolderButtons = (): JSX.Element[] => {
              <Stack horizontal wrap tokens={{ childrenGap: 8 }}>
                {getFolderButtons()}
              </Stack>

    const dateTextStyles: ITextStyles = {
      root: {
        color: "#767676"
      }
    };
  
    let buttonArray: JSX.Element[] = [];
    for (let i = 1; i <= 50; i++) {
      const day = Math.ceil(Math.random() * 28);
      const month = Math.ceil(Math.random() * 12);
      const year = Math.ceil(Math.random() * 5) + 2013;
  
      const button: JSX.Element = (
        <div>
          <PrimaryButton
          
            text="Folder"
            iconProps={{ iconName: "Folder" }}
          >
            <Text>Folder {i}</Text>
            <Text variant="small" styles={dateTextStyles}>
              {month}/{day}/{year}
            </Text>
          </PrimaryButton>
        </div>
      );
      buttonArray.push(button);
    }
    return buttonArray;
  };*/
export default CardsSection;