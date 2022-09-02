import {
    Stack,
    ITextStyles,
    DocumentCard,
    DocumentCardDetails,
    DocumentCardTitle,
    ImageFit,
    DocumentCardImage,
    IDocumentCardStyles,
    Separator} from '@fluentui/react';

export default function Clients(_props: any) {
    // Component styles

    // CommandBar related props



    const cardStyles: IDocumentCardStyles = {
        root: {
            textAlign: 'center',
            display: 'inline-block', marginRight: 20, marginBottom: 20
        }
    };

    const textStyles: ITextStyles = {
       root:{fontSize: '35px'}
    }
    return (
        <Stack horizontalAlign='space-evenly' tokens={{ padding: '10px 0px 0px 205px', childrenGap: '2%', maxHeight: '100%', maxWidth: '100%' }}>

            <Stack horizontalAlign='center' verticalAlign='center' tokens={{ childrenGap: 20 }}>
                <Separator styles={textStyles}>Catalogos</Separator>
            </Stack>
            
            <Stack horizontalAlign='center' horizontal wrap tokens={{ padding: '0px 0px 0px 30px', childrenGap: 10 }}>
            <DocumentCard styles={cardStyles} onClickHref="/clientList/showclient">
                    <DocumentCardImage height={150} imageFit={ImageFit.cover} iconProps={{ iconName: "EntitlementPolicy",styles:{root:{fontSize: '120px', width: '120px', height: '120px'}} }} />
                    <DocumentCardDetails/>
                        <DocumentCardTitle title="Clientes Regulares" shouldTruncate />
                </DocumentCard>
                <DocumentCard styles={cardStyles} onClickHref="/">
                    <DocumentCardImage height={150} imageFit={ImageFit.cover} iconProps={{ iconName: "EntitlementPolicy",styles:{root:{fontSize: '120px', width: '120px', height: '120px'}} }} />
                    <DocumentCardDetails/>
                        <DocumentCardTitle title="Clientes Especiales" shouldTruncate />
                </DocumentCard>
            </Stack>
        </Stack>
    );
}
