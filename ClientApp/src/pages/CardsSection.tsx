import * as React from 'react';
import { 
    DocumentCard,
    DocumentCardActivity,
    DocumentCardTitle,
    DocumentCardDetails,
    DocumentCardImage,
    IDocumentCardStyles,
    IDocumentCardActivityPerson,
    IIconProps,
    ImageFit
} from '@fluentui/react';



const people: IDocumentCardActivityPerson[] = [
    { name: 'Ailed Gutierrez', profileImageSrc: '', initials: 'AG' },
    { name: 'Reyna Astorga', profileImageSrc: '', initials: 'RA' },
    { name: 'Israel Castro', profileImageSrc: '', initials: 'IC' },
    { name: 'Carlos Quiroz', profileImageSrc: '', initials: 'CQ' },
  ];

  const paymentIconProps: IIconProps = {
    iconName: 'PaymentCard',
    styles: { root: { color: '#0B275C', fontSize: '120px', width: '120px', height: '120px' } },
  };
  const accountingIconProps: IIconProps = {
    iconName: 'Money',
    styles: { root: { color: '#0B275C', fontSize: '120px', width: '120px', height: '120px' } },
  };
  const managementIconProps: IIconProps = {
    iconName: 'AccountManagement',
    styles: { root: { color: '#0B275C', fontSize: '120px', width: '120px', height: '120px' } },
  };
  const recruitmentIconProps: IIconProps = {
    iconName: 'RecruitmentManagement',
    styles: { root: { color: '#0B275C', fontSize: '120px', width: '120px', height: '120px' } },
  };
  const accountsreceivableIconProps: IIconProps = {
    iconName: 'AllCurrency',
    styles: { root: { color: '#0B275C', fontSize: '120px', width: '120px', height: '120px' } },
  };
  const ecommerceIconProps: IIconProps = {
    iconName: 'StoreLogoMed20',
    styles: { root: { color: '#0B275C', fontSize: '120px', width: '120px', height: '120px' } },
  };
  const marketingIconProps: IIconProps = {
    iconName: 'VisualsStore',
    styles: { root: { color: '#0B275C', fontSize: '120px', width: '120px', height: '120px' } },
  };
  const salesIconProps: IIconProps = {
    iconName: 'Commitments',
    styles: { root: { color: '#0B275C', fontSize: '120px', width: '120px', height: '120px' } },
  };

  export const CardsSection: React.FunctionComponent = () => {
    const cardStyles: IDocumentCardStyles = {
      root: { display: 'inline-block', marginBottom: 20,marginRight:10, width: 160, left: 25, top: 25 },
    };
  
    return (
      <div>
          <DocumentCard
          aria-label={
            'Tarjeta de documento con icono. Cómo hacer un buen diseño. ' +
            'Ultima modificación por Carlos Quiroz el 2 Enero, 2022.'
          }
          styles={cardStyles}
          onClickHref="/"
        >
          <DocumentCardImage height={150} imageFit={ImageFit.cover} iconProps={paymentIconProps} />
          <DocumentCardDetails>
            <DocumentCardTitle title="Sistema de pagos" shouldTruncate />
          </DocumentCardDetails>
          <DocumentCardActivity activity="Modificado Enero 2, 2022" people={[people[3]]} />
        </DocumentCard>

        <DocumentCard
          aria-label={
            'Tarjeta de documento con imagen. Cómo hacer un buen diseño. ' +
            'Última modificación por Ailed Gutierrez y otras 2 personas el 02 de enero de 2022.'
          }
          styles={cardStyles}
          onClickHref="/"
        >
          <DocumentCardImage height={150} imageFit={ImageFit.cover} iconProps={accountingIconProps} />
          <DocumentCardDetails>
            <DocumentCardTitle title="Contabilidad" shouldTruncate />
          </DocumentCardDetails>
          <DocumentCardActivity activity="Modificado Enero 2, 2022" people={people.slice(1)} />
        </DocumentCard>

        <DocumentCard
          aria-label={
            'Tarjeta de documento con icono. Cómo hacer un buen diseño. ' +
            'Ultima modificación por Carlos Quiroz el 2 Enero, 2022.'
          }
          styles={cardStyles}
          onClickHref="/"
        >
          <DocumentCardImage height={150} imageFit={ImageFit.cover} iconProps={managementIconProps} />
          <DocumentCardDetails>
            <DocumentCardTitle title="Administracion" shouldTruncate />
          </DocumentCardDetails>
          <DocumentCardActivity activity="Modificado Enero 2, 2022" people={[people[2]]} />
        </DocumentCard>

        <DocumentCard
          aria-label={
            'Tarjeta de documento con icono. Cómo hacer un buen diseño. ' +
            'Ultima modificación por Carlos Quiroz el 2 Enero, 2022.'
          }
          styles={cardStyles}
          onClickHref="/"
        >
          <DocumentCardImage height={150} imageFit={ImageFit.cover} iconProps={recruitmentIconProps} />
          <DocumentCardDetails>
            <DocumentCardTitle title="Recursos Humanos" shouldTruncate />
          </DocumentCardDetails>
          <DocumentCardActivity activity="Modificado Enero 2, 2022" people={[people[3]]} />
        </DocumentCard>

        <DocumentCard
          aria-label={
            'Tarjeta de documento con icono. Cómo hacer un buen diseño. ' +
            'Ultima modificación por Carlos Quiroz el 2 Enero, 2022.'
          }
          styles={cardStyles}
          onClickHref="/"
        >
          <DocumentCardImage height={150} imageFit={ImageFit.cover} iconProps={salesIconProps} />
          <DocumentCardDetails>
            <DocumentCardTitle title="Ventas" shouldTruncate />
          </DocumentCardDetails>
          <DocumentCardActivity activity="Modificado Enero 2, 2022" people={[people[3]]} />
        </DocumentCard>

        <DocumentCard
          aria-label={
            'Tarjeta de documento con imagen. Cómo hacer un buen diseño. ' +
            'Última modificación por Ailed Gutierrez y otras 2 personas el 02 de enero de 2022.'
          }
          styles={cardStyles}
          onClickHref="/"
        >
          <DocumentCardImage height={150} imageFit={ImageFit.cover} iconProps={marketingIconProps} />
          <DocumentCardDetails>
            <DocumentCardTitle title="Marketing" shouldTruncate />
          </DocumentCardDetails>
          <DocumentCardActivity activity="Modificado Enero 2, 2022" people={people.slice(0, 3)} />
        </DocumentCard>

        <DocumentCard
          aria-label={
            'Tarjeta de documento con icono. Cómo hacer un buen diseño. ' +
            'Ultima modificación por Carlos Quiroz el 2 Enero, 2022.'
          }
          styles={cardStyles}
          onClickHref="/"
        >
          <DocumentCardImage height={150} imageFit={ImageFit.cover} iconProps={ecommerceIconProps} />
          <DocumentCardDetails>
            <DocumentCardTitle title="Ecommerce" shouldTruncate />
          </DocumentCardDetails>
          <DocumentCardActivity activity="Modificado Enero 2, 2022" people={[people[3]]} />
        </DocumentCard>

        <DocumentCard
          aria-label={
            'Tarjeta de documento con icono. Cómo hacer un buen diseño. ' +
            'Ultima modificación por Carlos Quiroz el 2 Enero, 2022.'
          }
          styles={cardStyles}
          onClickHref="/"
        >
          <DocumentCardImage height={150} imageFit={ImageFit.cover} iconProps={accountsreceivableIconProps} />
          <DocumentCardDetails>
            <DocumentCardTitle title="Credito y Cobranza" shouldTruncate />
          </DocumentCardDetails>
          <DocumentCardActivity activity="Modificado Enero 2, 2022" people={[people[3]]} />
        </DocumentCard>
      </div>
    );
  };
  export default CardsSection;