import { Separator, Stack } from '@fluentui/react';
import * as React from 'react';

function ReportViewComponent(): JSX.Element {
  return (
    <Stack horizontalAlign='space-evenly' tokens={{padding:'10px 0px 0px 205px',childrenGap:'2%', maxHeight:'100%',maxWidth:'100%' }}>
    <Separator><h2>Reportes</h2></Separator>
    <Stack horizontalAlign='center' horizontal wrap tokens={{ padding: '0px 0px 0px 30px', childrenGap: 10 }}>
    </Stack>
    </Stack>
  );
}
export default ReportViewComponent;

// TODO - Fixear esta parte del codigo