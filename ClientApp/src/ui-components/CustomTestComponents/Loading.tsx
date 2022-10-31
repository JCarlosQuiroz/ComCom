import { Spinner, IStackTokens, Stack, Label, IStackProps, SpinnerSize, ISpinnerProps } from "@fluentui/react";
import { Theme } from "../../styles/Theme";





export const Loading = () => {
    const stackTokens: IStackTokens = {
        childrenGap: 20,
        maxWidth: 1000,
    };

    const tokens = {
        sectionStack: {
            childrenGap: 10,
        },
        spinnerStack: {
            childrenGap: 20,
        },
    };
    const rowProps: IStackProps = { horizontal: true, verticalAlign: 'center' };

    const spinnerProps: ISpinnerProps = {
        size: SpinnerSize.large,
        label: 'Cargando...',
        ariaLive: 'assertive',
        ariaLabel: 'Cargando...',
        labelPosition: 'right',
        theme: Theme,
        style: {
            margin: '0px',
            padding: '0px',
            border: 'none',
            backgroundColor: 'transparent',
            backgroundRepeat: 'no-repeat',
            backgroundPosition: 'center',
            backgroundSize: 'cover',
            opacity: '100%',
            filter: 'none',
            WebkitFilter: 'none',
            WebkitBackdropFilter: 'none',
            WebkitMask: 'none',
            WebkitMaskImage: 'none',
            WebkitMaskPosition: '0% 0%',
            WebkitMaskRepeat: 'no-repeat',
            WebkitMaskSize: 'auto',
            WebkitMaskOrigin: 'border-box',
            WebkitMaskBoxImage: 'none',
            WebkitMaskBoxImageSource: 'none',
            WebkitMaskBoxImageSlice: '0 fill',
            WebkitMaskBoxImageWidth: '0',
        },
    };

    // const labelProps: ILabelProps = {
    //     styles: {
    //         root: {
    //             fontSize: '20px',
    //             fontWeight: 'bold',
    //             color: '#000000',
    //             margin: '0px',
    //             padding: '0px',
    //             border: 'none',
    //             backgroundColor: 'transparent',
    //             backgroundRepeat: 'no-repeat',
    //             backgroundPosition: 'center',
    //             backgroundSize: 'cover',
    //             opacity: '100%',
    //             filter: 'none',
    //             WebkitFilter: 'none',
    //             WebkitBackdropFilter: 'none',
    //             WebkitMask: 'none',
    //             WebkitMaskImage: 'none',
    //             WebkitMaskPosition: '0% 0%',
    //             WebkitMaskRepeat: 'no-repeat',
    //             WebkitMaskSize: 'auto',
    //             WebkitMaskOrigin: 'border-box',
    //             WebkitMaskBoxImage: 'none',
    //             WebkitMaskBoxImageSource: 'none',
    //             WebkitMaskBoxImageSlice: '0 fill',
    //             WebkitMaskBoxImageWidth: '0',
    //             WebkitMaskBoxImageRepeat: 'stretch',
    //             WebkitMaskClip: 'border-box',
    //             WebkitMaskComposite: 'add',
    //         },
    //     },
    // };

    // const spinnerStyle: ISpinnerStyles = {
    //     root: {
    //         margin: '0px',
    //         padding: '0px',
    //         border: 'none',
    //         backgroundColor: 'transparent',
    //         backgroundRepeat: 'no-repeat',
    //         backgroundPosition: 'center',
    //         backgroundSize: 'cover',
    //         opacity: '100%',
    //         filter: 'none',
    //         WebkitFilter: 'none',
    //         WebkitBackdropFilter: 'none',
    //         WebkitMask: 'none',
    //         WebkitMaskImage: 'none',
    //         WebkitMaskPosition: '0% 0%',
    //         WebkitMaskRepeat: 'no-repeat',
    //         WebkitMaskSize: 'auto',
    //         WebkitMaskOrigin: 'border-box',
    //         WebkitMaskBoxImage: 'none',
    //         WebkitMaskBoxImageSource: 'none',
    //         WebkitMaskBoxImageSlice: '0 fill',
    //         WebkitMaskBoxImageWidth: '0',
    //         WebkitMaskBoxImageRepeat: 'stretch',
    //         WebkitMaskClip: 'border-box',
    //         WebkitMaskComposite: 'add',
    //     },
    //     circle: {
    //         margin: '0px',
    //         padding: '0px',
    //         border: 'none',
    //         backgroundColor: 'transparent',
    //         backgroundRepeat: 'no-repeat',
    //         backgroundPosition: 'center',
    //         backgroundSize: 'cover',
    //         opacity: '100%',
    //         filter: 'none',
    //         WebkitFilter: 'none',
    //         WebkitBackdropFilter: 'none',
    //         WebkitMask: 'none',
    //         WebkitMaskImage: 'none',
    //         WebkitMaskPosition: '0% 0%',
    //         WebkitMaskRepeat: 'no-repeat',
    //         WebkitMaskSize: 'auto',
    //         WebkitMaskOrigin: 'border-box',
    //         WebkitMaskBoxImage: 'none',
    //         WebkitMaskBoxImageSource: 'none',
    //         WebkitMaskBoxImageSlice: '0 fill',
    //         WebkitMaskBoxImageWidth: '0',
    //         WebkitMaskBoxImageRepeat: 'stretch',
    //         WebkitMaskClip: 'border-box',
    //         WebkitMaskComposite: 'add',
    //     },
    //     label: {
    //         margin: '0px',
    //         padding: '0px',
    //         border: 'none',
    //         backgroundColor: 'transparent',
    //         backgroundRepeat: 'no-repeat',
    //         backgroundPosition: 'center',
    //         backgroundSize: 'cover',
    //         opacity: '100%',
    //         filter: 'none',
    //         WebkitFilter: 'none',
    //         WebkitBackdropFilter: 'none',
    //         WebkitMask: 'none',
    //         WebkitMaskImage: 'none',
    //         WebkitMaskPosition: '0% 0%',
    //         WebkitMaskRepeat: 'no-repeat',
    //         WebkitMaskSize: 'auto',
    //         WebkitMaskOrigin: 'border-box',
    //         WebkitMaskBoxImage: 'none',
    //         WebkitMaskBoxImageSource: 'none',
    //         WebkitMaskBoxImageSlice: '0 fill',
    //         WebkitMaskBoxImageWidth: '0',
    //         WebkitMaskBoxImageRepeat: 'stretch',
    //         WebkitMaskClip: 'border-box',
    //         WebkitMaskComposite: 'add',
    //     },
    //     screenReaderText: {
    //         margin: '0px',
    //         padding: '0px',
    //         border: 'none',
    //         backgroundColor: 'transparent',
    //         backgroundRepeat: 'no-repeat',
    //         backgroundPosition: 'center',
    //         backgroundSize: 'cover',
    //         opacity: '100%',
    //         filter: 'none',
    //         WebkitFilter: 'none',
    //         WebkitBackdropFilter: 'none',
    //         WebkitMask: 'none',
    //         WebkitMaskImage: 'none',
    //         WebkitMaskPosition: '0% 0%',
    //         WebkitMaskRepeat: 'no-repeat',
    //         WebkitMaskSize: 'auto',
    //         WebkitMaskOrigin: 'border-box',
    //         WebkitMaskBoxImage: 'none',
    //         WebkitMaskBoxImageSource: 'none',
    //         WebkitMaskBoxImageSlice: '0 fill',
    //         WebkitMaskBoxImageWidth: '0',
    //         WebkitMaskBoxImageRepeat: 'stretch',
    //         WebkitMaskClip: 'border-box',
    //         WebkitMaskComposite: 'add',
    //     }
    // };

    return (
        <Stack tokens={stackTokens} horizontalAlign="space-evenly" verticalAlign="center" horizontal>
            <div>
                <Label>Cargando...</Label>
                <Spinner
                    styles={spinnerProps}
                    size={SpinnerSize.large}
                    label="Cargando..."
                    labelPosition="right"
                    ariaLive="assertive"
                />

            </div>
            <div>
                <Label>Cargando...</Label>
                <Spinner label="Autenticacion en progreso" ariaLive="assertive" labelPosition="right" />
            </div>

            <div>
                <Label>Cargando...</Label>
                <Spinner label="wait wait ya no lo soy hahaha" ariaLive="assertive" labelPosition="top" />
            </div>

            <div>
                <Label>Cargando...</Label>
                <Spinner label="bueno si soy xD cargando....." ariaLive="assertive" labelPosition="bottom" />
            </div>

            <div>
                <Label>Cargando...</Label>
                <Spinner label="Cargando..." ariaLive="assertive" labelPosition="left" />
            </div>
            <Stack tokens={tokens.sectionStack}>
                <Stack {...rowProps} tokens={tokens.spinnerStack}>
                    <Label>Extra small spinner</Label>
                    <Spinner size={SpinnerSize.xSmall} />
                </Stack>

                <Stack {...rowProps} tokens={tokens.spinnerStack}>
                    <Label>Small spinner</Label>
                    <Spinner size={SpinnerSize.small} />
                </Stack>

                <Stack {...rowProps} tokens={tokens.spinnerStack}>
                    <Label>Medium spinner</Label>
                    <Spinner size={SpinnerSize.medium} />
                </Stack>

                <Stack {...rowProps} tokens={tokens.spinnerStack}>
                    <Label>Large spinner</Label>
                    <Spinner size={SpinnerSize.large} />
                </Stack>
            </Stack>
        </Stack>

    );
}


export default Loading;