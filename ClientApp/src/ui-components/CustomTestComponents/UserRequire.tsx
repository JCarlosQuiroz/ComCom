import {
  ISeparatorStyles,
  Separator,
  Stack,
  Text,
  TextField,
} from '@fluentui/react'
import { useBoolean } from '@fluentui/react-hooks'
import { Theme } from '../../styles/Theme'


const ISepStyles: ISeparatorStyles = {
  root: {
    backgroundColor: Theme.palette.themePrimary,
    height: 2,
    width: '100%',
    marginTop: 40,
    marginBottom: 40,
  },
  content: {
    fontSize: '1.3rem',
    fontWeight: '400',
    fontStyle: 'normal',
    color: '#00a54f',
    bottom: 30,
  },
}
const stackTokens = { childrenGap: 80 }
// const stackStyles: Partial<IStackStyles> = { root: { width: 'auto' } }
// const columnProps: Partial<IStackProps> = {
//   tokens: { childrenGap: 30 },
//   styles: { root: { width: 335 } },
// }
export default function UserRequire() {
  const [multiline] = useBoolean(true)
//   const onChange = (
//     ev: React.FormEvent<HTMLInputElement | HTMLTextAreaElement>,
//     newText: string,
//   ): void => {
//     const newMultiline = newText.length > 50
//     if (newMultiline !== multiline) {
//       toggleMultiline()
//     }
//   }
  return (
    <Stack
      horizontalAlign="start"
      tokens={{
        padding: '10px 0px 0px 0px',
        maxHeight: '100%',
        maxWidth: '100%',
        childrenGap: 10,
      }}
    >
      <Separator theme={Theme} styles={ISepStyles}>
        Solicitud de requerimentos y adiciones extras al Software.
      </Separator>
      <Text
        variant={'large'}
        styles={{
          root: {
            fontWeight: 500,
            fontSize: '1.5rem',
            color: '#00a54f',
            
          },
        }}
      >
       Mandanos un mensaje.
      </Text>
      <Text>
      Utilice el siguiente formulario para ponerse en contacto con nosotros para que podamos analisar su caso. Nos esforzamos por responder a todas las solicitudes dentro de un día hábil. Disculpe nuestra demora si no respondemos tan rápido como nos gustaría.      </Text>
      <Stack.Item align='center' >
      <Stack horizontal  tokens={stackTokens} >
      {/* <Stack {...columnProps}>
        <TextField label="Standard" />
        <TextField label="Disabled" disabled defaultValue="I am disabled" />
        <TextField label="Read-only" readOnly defaultValue="I am read-only" />
        <TextField label="Required " required />
        <TextField ariaLabel="Required without visible label" required />
        <TextField label="With error message" errorMessage="Error message" />
      </Stack>
      <Stack {...columnProps}>
        <MaskedTextField label="With input mask" mask="m\ask: (999) 999 - 9999" title="A 10 digit number" />
        <TextField label="With an icon" iconProps={iconProps} />
        <TextField label="With placeholder" placeholder="Please enter text here" />
        <TextField label="Disabled with placeholder" disabled placeholder="I am disabled" />
        <TextField
          label="Password with reveal button"
          type="password"
          canRevealPassword
          revealPasswordAriaLabel="Show password"
        />
        <TextField label="Standard" multiline rows={3} />
        <TextField label="Disabled" multiline rows={3} disabled defaultValue={dummyText} />
        <TextField label="Non-resizable" multiline resizable={false} />
      </Stack> */}
    <Stack >
    <TextField 
        label="1. OBJETIVO (Finalidad de la modificación) (Al hablar de pantallas poner la ruta completa de cómo acceder a dicha pantalla)" 
        multiline={multiline} 
        autoAdjustHeight
        />
                <TextField 
        label="4.	DETALLE VISUAL (Capturas de pantalla)" 
        multiline={multiline}
        autoAdjustHeight
        />
                <TextField 
        label="7.    SOLICITUD DE INSERCIÓN (Si la petición es de nuevo registro, detallar)" 
        multiline={multiline}
        autoAdjustHeight
        />
                <TextField 
        label="3. DETALLES, CONSULTAS, SUPUESTOS, LIMITACIONES Y EXCEPCIONES" 
        multiline={multiline}
        autoAdjustHeight
        />
        </Stack>
      <Stack >
        <TextField 
        label="2. REQUERIMIENTO DEL CLIENTE (Anotar textualmente los requerimientos al igual los datos de la persona solicitante nombre y puesto)" 
        multiline={multiline}
        autoAdjustHeight
        />
                <TextField 
        label="5.	APLICA A GENÉRICO (El cambio se aplicará para todos los usuarios o solo para el usuario de la petición) " 
        multiline={multiline}
        autoAdjustHeight
        />
                <TextField 
        label="8.	SOLICITUD DE MODIFICACIÓN (Si la petición es de modificación, detallar)"
        multiline={multiline} 
        autoAdjustHeight
        />
                        <TextField 
        label="6.	SOLICITUD DE LISTADO (Si la petición es de nuevo listado, detallar)" 
        multiline={multiline}
        autoAdjustHeight
        />
        Datos del filtro: 
        Columnas a listar: 
        Formato de ejemplo de listado: 
        <TextField 
        label="9.    OBSERVACIONES (Anotar las observaciones pertinentes)"
        multiline={multiline}
        autoAdjustHeight
        />
      </Stack>


    </Stack>
      </Stack.Item>
    </Stack>
  )
}
