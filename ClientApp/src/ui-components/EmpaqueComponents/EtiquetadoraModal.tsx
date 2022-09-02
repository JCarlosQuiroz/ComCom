import * as React from 'react';
import { useId, useBoolean } from '@fluentui/react-hooks';
import {
  mergeStyleSets,
  FontWeights,
  ContextualMenu,
  Modal,
  IDragOptions,
  IIconProps,
  Stack,
  Separator,
  ISeparatorStyles,
  Pivot,
  PivotItem,
  DocumentCardImage,
  ImageFit,
} from '@fluentui/react';
import { DefaultButton, IconButton, IButtonStyles, PrimaryButton } from '@fluentui/react/lib/Button';
import { Images, Theme } from '../../styles/Theme';
import CuartoFrioBerenjenaTest from '../CuartoFrioComponents/CuartoFrioBerenjenaTest';
import CuartoFrioChileBell from '../CuartoFrioComponents/CuartoFrioChileBell';
import CuartoFrioPepino from '../CuartoFrioComponents/CuartoFrioPepino';
import CuartoFrioTomates from '../CuartoFrioComponents/CuartoFrioTomates';


export const EtiquetadoraModal: React.FunctionComponent = () => {
  const [isModalOpen, { setTrue: showModal, setFalse: hideModal }] = useBoolean(false);
  const [isDraggable] = useBoolean(false);
  const [keepInBounds] = useBoolean(false);
  // Normally the drag options would be in a constant, but here the toggle can modify keepInBounds
  const dragOptions = React.useMemo(
    (): IDragOptions => ({
      moveMenuItemText: 'Move',
      closeMenuItemText: 'Close',
      menu: ContextualMenu,
      keepInBounds,
    }),
    [keepInBounds],
  );

  const ISepStyles: ISeparatorStyles = {
    root: {
      backgroundColor: Theme.palette.themePrimary,
      height: 2,
      width: '100%',
      marginTop: 20,
      marginBottom: 40,
    },
    content: {
      fontSize: '30px',
      fontWeight: "400",
      fontStyle: "normal",
      color: "#00a54f",
      bottom: 30,
    }
  };

  const pivotStyles = {
    root: {
      display: 'flex',
      alignItems: 'center',
      alighContent: 'center',
      justifyContent: 'center',
    },
  };

  // Use useId() to ensure that the IDs are unique on the page.
  // (It's also okay to use plain strings and manually ensure uniqueness.)
  const titleId = useId('title');

  return (
<Stack>
    <Stack.Item>
      <PrimaryButton onClick={showModal} text="Cuarto Frio Nave 1" />
      <Modal
        titleAriaId={titleId}
        isOpen={isModalOpen}
        onDismiss={hideModal}
        isBlocking={false}
        containerClassName={contentStyles.container}
        dragOptions={isDraggable ? dragOptions : undefined}
      >

        <div className={contentStyles.header}>
          <Separator theme={Theme} styles={ISepStyles}>EMPAQUE NAVE 1, CULIACAN, SINALOA</Separator>
          <IconButton
            styles={iconButtonStyles}
            iconProps={cancelIcon}
            ariaLabel="Close popup modal"
            onClick={hideModal}
          />
        </div>

        <div className={contentStyles.body}>
          <Pivot aria-label="Count and Icon Pivot Example" styles={pivotStyles}>
            <PivotItem onRenderItemLink={_customRender00}>
              <CuartoFrioPepino />
            </PivotItem>
            <PivotItem onRenderItemLink={_customRender01}>
              <CuartoFrioChileBell />
            </PivotItem>
            <PivotItem onRenderItemLink={_customRender02}>
              <CuartoFrioTomates />
            </PivotItem>
            <PivotItem onRenderItemLink={_customRender03}>
            <CuartoFrioBerenjenaTest/>
            </PivotItem>
          </Pivot>

        </div>

      </Modal>
      </Stack.Item>
      <Stack.Item>
      <DefaultButton onClick={noFunciona} text="Cuarto Frio Nave 2" />
        
      </Stack.Item>

</Stack>
    
    
  );
};

function _customRender00() {
  return (
    <Stack.Item align="center" grow={1}>
      <DocumentCardImage height={40} width={55} imageFit={ImageFit.centerCover} imageSrc={Images.product00} />
    </Stack.Item>
  );
}
function _customRender01() {
  return (
    <Stack.Item align="center" grow={1}>
      <DocumentCardImage height={40} width={40} imageFit={ImageFit.centerCover} imageSrc={Images.product01} />
    </Stack.Item>
  );
}

function _customRender02() {
  return (
    <Stack.Item align="center" grow={1}>
      <DocumentCardImage height={40} width={40} imageFit={ImageFit.centerCover} imageSrc={Images.product02} />
    </Stack.Item>

  );
}
function _customRender03() {
  return (
    <Stack.Item align="center" grow={1}>
      <DocumentCardImage height={40} width={40} imageFit={ImageFit.centerCover} imageSrc={Images.product04} />
    </Stack.Item>
  );
}

function noFunciona() {
  alert('Esta funcion no esta disponible aun');
}

const cancelIcon: IIconProps = { iconName: 'Cancel' };


const contentStyles = mergeStyleSets({
  container: {
    display: 'flex',
    flexFlow: 'column nowrap',
    alignItems: 'stretch',
  },
  header: [
    Theme.fonts.xLarge,
    {
      flex: '4 4 auto',
      borderTop: `4px solid ${Theme.palette.themePrimary}`,
      color: Theme.palette.neutralPrimary,
      display: 'flex',
      alignItems: 'center',
      fontWeight: FontWeights.semibold,
      padding: '12px 12px 14px 24px',
    },
  ],
  body: {
    flex: '4 4 auto',
    padding: '0px 24px 70px 35px',
    overflowY: 'hidden',
    selectors: {
      p: { margin: '14px 0' },
      'p:first-child': { marginTop: 0 },
      'p:last-child': { marginBottom: 0 },
    },
  },
});

const iconButtonStyles: Partial<IButtonStyles> = {
  root: {
    color: Theme.palette.neutralPrimary,
    marginLeft: 'auto',
    marginTop: '4px',
    marginRight: '2px',
  },
  rootHovered: {
    color: Theme.palette.neutralDark,
  },
};


export default EtiquetadoraModal;