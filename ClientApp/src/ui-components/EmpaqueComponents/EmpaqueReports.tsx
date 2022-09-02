import * as React from 'react';
import { mergeStyleSets, FontWeights, ContextualMenu, Modal, IDragOptions, IIconProps, Stack, IStackProps, PrimaryButton, IconButton, IButtonStyles, IStackStyles, IStackItemStyles, IStackTokens, IModalStyles, DefaultButton } from '@fluentui/react';
import { useId, useBoolean } from '@fluentui/react-hooks';
import { Theme } from '../../styles/Theme';
import CuartoFrioTomates from '../CuartoFrioComponents/CuartoFrioTomates';





// const overflowButtonProps: IButtonProps = {
//   ariaLabel: 'More commands',
//   text: 'More',
//   menuProps: {
//     items: [
//       {
//         key: 'save',
//         text: 'Save',
//         iconProps: { iconName: 'Save' },
//         onClick: () => console.log('Clicked Save'),
//       },
//       {
//         key: 'print',
//         text: 'Print',
//         iconProps: { iconName: 'Print' },
//         onClick: () => console.log('Clicked Print'),
//       },
//     ],
//   },
// };

const cancelIcon: IIconProps = { iconName: 'Cancel' };

const theme = Theme;
const contentStyles = mergeStyleSets({
  container: {
    display: 'flex',
    flexFlow: 'column nowrap',
    alignItems: 'stretch',
  },
  header: [
    theme.fonts.large,
    {
      flex: '1 1 auto',
      borderTop: `4px solid ${theme.palette.themePrimary}`,
      color: theme.palette.neutralPrimary,
      display: 'flex',
      alignItems: 'center',
      fontWeight: FontWeights.semibold,
      padding: '12px 12px 14px 24px',
    },
  ],
  body: {
    flex: '4 4 auto',
    padding: '0 24px 24px 24px',
    overflowY: 'hidden',
    selectors: {
      p: { margin: '14px 0' },
      'p:first-child': { marginTop: 0 },
      'p:last-child': { marginBottom: 0 },
    },
  },
});
const stackProps: Partial<IStackProps> = {
  horizontal: true,
  verticalAlign: 'space-between',
  tokens: { childrenGap: 40 },
  styles: { root: { marginBottom: 20 } },
};
const iconButtonStyles: Partial<IButtonStyles> = {
  root: {
    color: theme.palette.neutralPrimary,
    marginLeft: 'auto',
    marginTop: '4px',
    marginRight: '2px',
  },
  rootHovered: {
    color: theme.palette.neutralDark,
  },
};


export const EmpaqueReports: React.FunctionComponent = () => {
  const [isModalOpen, { setTrue: showModal, setFalse: hideModal }] = useBoolean(false);
  const [isDraggable] = useBoolean(false);
  const [keepInBounds] = useBoolean(false);
  const dragOptions = React.useMemo(
    (): IDragOptions => ({
      moveMenuItemText: 'Move',
      closeMenuItemText: 'Close',
      menu: ContextualMenu,
      keepInBounds,
    }),
    [keepInBounds],
  );

  const ModalStyleSetts: IModalStyles = {
    root: undefined,
    main: undefined,
    scrollableContent: undefined,
    layer: undefined,
    keyboardMoveIconContainer: undefined,
    keyboardMoveIcon: undefined
  };

  const titleId = useId('modal-1');
  const itemAlignmentsStackTokens: IStackTokens = {
    childrenGap: 5,
    padding: 10,
  };

  const stackItemStyles: IStackItemStyles = {
    root: {
      background: Theme.palette.white,
      color: Theme.palette.white,
      padding: 5,
    },
  };

  const stackStyles: IStackStyles = {
    root: {
      background: Theme.palette.white,
    },
  };
  return (

    <Stack styles={stackStyles} tokens={itemAlignmentsStackTokens}>

      <Stack.Item align="center" styles={stackItemStyles}>

        <div>


          <div>
            <Stack {...stackProps}>

            </Stack>

            <PrimaryButton onClick={showModal} text="Reporte Cuarto Frio Nave 1" />
            <Modal
              titleAriaId={titleId}
              isOpen={isModalOpen}
              onDismiss={hideModal}
              isBlocking={false}
              containerClassName={contentStyles.container}
              dragOptions={isDraggable ? dragOptions : undefined}
              styles={ModalStyleSetts}
            >
              <div className={contentStyles.header}>
                <IconButton
                  styles={iconButtonStyles}
                  iconProps={cancelIcon}
                  ariaLabel="Close popup modal"
                  onClick={hideModal}
                />
              </div>
              <div className={contentStyles.body}>
                <CuartoFrioTomates />
              </div>
            </Modal>
          </div>
          <DefaultButton onClick={showModal} text="Reporte Cuarto Frio Nave 2" />
        </div>



      </Stack.Item>

    </Stack>
  );
};



export default EmpaqueReports;