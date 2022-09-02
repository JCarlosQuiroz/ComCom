import React from 'react';
import { createTheme, DocumentCard, DocumentCardDetails, DocumentCardImage, DocumentCardTitle, IDocumentCardStyles, ImageFit, IStackTokens, ITheme, Separator, Stack, StackItem } from '@fluentui/react';
import { Images } from '../../styles/Theme';








const Theme: ITheme = createTheme({
    fonts: {
        medium: {
            fontFamily: 'Segoe UI,Roboto,Oxygen,Ubuntu,Cantarell,Fira Sans',
            fontSize: '30px',
            display: 'inline-block', marginBottom: 60, top: 40
        },
    },
});

const stackTokens: IStackTokens = { childrenGap: 12 };

export const SystemPaysView: React.FunctionComponent = () => {
    const cardStyles: IDocumentCardStyles = {
        root: { display: 'inline-block', marginBottom: 20, marginRight: 20, width: 260, left: 450, top: 50 },
    };

    return (
        <Stack tokens={stackTokens}>
            <Separator theme={Theme}>Listado de Referencia Oxxo</Separator>
            <StackItem>
                <DocumentCard styles={cardStyles} onClickHref="/system-pays/hsbc-rap">
                    <DocumentCardImage height={150} imageFit={ImageFit.centerContain} imageSrc={Images.metodosdepago} />
                <DocumentCardDetails/>
                    <DocumentCardTitle title="RAP HSBC" shouldTruncate />



            </DocumentCard>
                <DocumentCard styles={cardStyles} onClickHref="/system-pays/oxxo-pays/oxxo">
                    <DocumentCardImage height={150} imageFit={ImageFit.centerContain} imageSrc={Images.metodosdepago} />
                <DocumentCardDetails/>
                    <DocumentCardTitle title="Pagos Referenciados OXXO" shouldTruncate />



            </DocumentCard>
            </StackItem>
        </Stack>
    )
}