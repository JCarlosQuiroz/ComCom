import * as React from 'react'
import { useId, useBoolean } from '@fluentui/react-hooks'
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
  ImageFit,
  Image,
  IImageProps,
  IconButton,
  IButtonStyles,
  DocumentCard,
  DocumentCardImage,
  DocumentCardDetails,
  DocumentCardTitle,
  IDocumentCardStyles,
  ImageIcon,
} from '@fluentui/react'

import CuartoFrioBerenjenaTest from './CuartoFrioBerenjenaTest'
import CuartoFrioChileBell from './CuartoFrioChileBell'
import CuartoFrioPepino from './CuartoFrioPepino'
import CuartoFrioTomates from './CuartoFrioTomates'
import { Theme,Images } from '../../styles/Theme'

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
})

// const buttonStyles: Partial<IButtonStyles> = {
//   root: {
//     backgroundColor: Theme.palette.themePrimary,
//     color: Theme.palette.white,
//     selectors: {
//       ':hover': {
//         backgroundColor: Theme.palette.themeDark,
//       },
//     },
//   },
// }

const iconButtonStyles: Partial<IButtonStyles> = {
  root: {
    color: Theme.palette.white,
    marginLeft: 'auto',
    marginTop: '4px',
    marginRight: '2px',
    borderRadius: '50%',
    position: 'static',
    width: '50px',
    height: '50px',
    backgroundColor: Theme.palette.neutralPrimary,
    ':hover': {
      backgroundColor: Theme.palette.themePrimary,
      color: Theme.palette.white,
    },
  },
  rootHovered: {
    color: Theme.palette.neutralDark,
  },
  rootPressed: {
    color: Theme.palette.themePrimary,
  },
  rootChecked: {
    color: Theme.palette.neutralDark,
  },
  rootCheckedHovered: {
    color: Theme.palette.neutralDark,
  },
}

const ISepStyles: ISeparatorStyles = {
  root: {
    backgroundColor: Theme.palette.themePrimary,
    height: 1,
    width: '100%',
    // marginTop: 35,
    top: 'auto',
    marginBottom: 1,
  },
  content: {
    bottom: 10,
  },
}
const imageProduct00: Partial<IImageProps> = {
  imageFit: 3,
  src: Images.cucumber01,
  alt: 'ImgPepino',
  style: {
    width: '100px',
    height: 'auto',
    // alignContent: 'center',
    // justifyContent: 'center',
    display: 'row',
    alignItems: 'center',
    position: 'relative',
    // marginLeft: '100px',
    // marginTop: '100px',
    // marginBottom: '100px',
    // marginRight: '100px',
    // border: '1px solid green',
    borderRadius: '50%',
    // boxShadow: '0px 0px 10px purple',
    // backgroundColor: '#fff',
    // backgroundRepeat: 'no-repeat',
    backgroundPosition: 'center',
    backgroundSize: 'cover',
    cursor: 'pointer',
    transition: 'all 0.65s',
  },
}
const imageProduct01: Partial<IImageProps> = {
  imageFit: ImageFit.contain,
  src: Images.product01,
  alt: 'bellpaper',
  style: {
    width: '85px',
    height: 'auto',
    // alignContent: 'center',
    // justifyContent: 'center',
    display: 'row',
    alignItems: 'center',
    position: 'relative',
    // marginLeft: '100px',
    // marginTop: '100px',
    // marginBottom: '100px',
    // marginRight: '100px',
    // border: '1px solid green',
    borderRadius: '50%',

    // backgroundColor: '#fff',
    // backgroundRepeat: 'no-repeat',
    backgroundPosition: 'center',
    backgroundSize: 'cover',
    cursor: 'pointer',
    transition: 'all 0.65s',
  },
}
const imageProduct02: Partial<IImageProps> = {
  imageFit: ImageFit.contain,
  src: Images.tomate01,
  alt: 'ImgTomates',
  style: {
    width: '100px',
    height: 'auto',
    // alignContent: 'center',
    // justifyContent: 'center',
    display: 'row',
    alignItems: 'center',
    position: 'relative',
    // marginLeft: '100px',
    // marginTop: '100px',
    // marginBottom: '100px',
    // marginRight: '100px',
    // border: '1px solid green',
    // borderRadius: '50%',
    // backgroundColor: '#fff',
    // backgroundRepeat: 'no-repeat',
    backgroundPosition: 'center',
    backgroundSize: 'cover',

    transition: 'all 0.65s',
  },
}
const imageProduct03: Partial<IImageProps> = {
  imageFit: ImageFit.contain,
  src: Images.product04,
  alt: 'ImgBerenjena',
  style: {
    width: '100px',
    height: 'auto',
    // alignContent: 'center',
    // justifyContent: 'center',
    display: 'row',
    alignItems: 'center',
    position: 'relative',
    // marginLeft: '100px',
    // marginTop: '100px',
    // marginBottom: '100px',
    // marginRight: '100px',
    // border: '1px solid green',
    // borderRadius: '50%',

    // backgroundColor: '#fff',
    // backgroundRepeat: 'no-repeat',
    backgroundPosition: 'center',
    backgroundSize: 'cover',
    transition: 'all 0.65s',
  },
}
// function noFunciona() {
//   console.log('no funciona')
// }
function _customRender00() {
  return <Image {...imageProduct00} />
}
function _customRender01() {
  return <Image {...imageProduct01} />
}

function _customRender02() {
  return <Image {...imageProduct02} />
}
function _customRender03() {
  return <Image {...imageProduct03} />
}

const pivotStyles = {
  root: {
    display: 'flex',
    // alignItems: 'center',
    // alighContent: 'center',
    // justifyContent: 'center',
    // marginTop: '78px',
    // marginBottom: '80px',
    // marginLeft: '100px',
    // marginRight: '100px',
    // backgroundRepeat: 'no-repeat',
    // backgroundPosition: 'center',
    // backgroundSize: 'cover',
    backgroundColor: '##ffffff00',
    cursor: 'pointer',
    transition: 'all 0.5s',
    marginBottom: '30px',
    marginTop: '100px',
    justifyContent: 'center',
  },
}
const cardStyles1: IDocumentCardStyles = {
  root: {
    display: 'inline-block',
    width: '100%',
    height: '100%',
    background: Theme.palette.whiteTranslucent40,
    borderBottomColor: Theme.palette.neutralPrimary,
    borderBottomStyle: 'solid',
    borderBottomWidth: '15px',
    boxShadow: '0px 0px 10px white',
    backgroundRepeat: 'no-repeat',
    backgroundPosition: 'center',
    backgroundSize: 'cover',
    cursor: 'pointer',
    transition: 'all 0.65s',
    textAlign: 'center',
    '&:hover': {
      background: Theme.palette.themePrimary,
    },
  },
}
const cardStyles2: IDocumentCardStyles = {
  root: {
    display: 'inline-block',
    width: '100%',
    height: '100%',
    background: Theme.palette.whiteTranslucent40,
    borderBottomColor: Theme.palette.neutralPrimary,
    borderBottomStyle: 'solid',
    borderBottomWidth: '15px',
    boxShadow: '0px 0px 10px white',
    backgroundRepeat: 'no-repeat',
    backgroundPosition: 'center',
    backgroundSize: 'cover',
    cursor: 'pointer',
    transition: 'all 0.65s',
    textAlign: 'center',
    '&:hover': {
      background: Theme.palette.themePrimary,
    },
  },
}



export default function CuartoFrioModal() {
  const [isModalOpen, { setTrue: showModal, setFalse: hideModal }] = useBoolean(
    false,
  )
  const [isDraggable] = useBoolean(false)
  const [keepInBounds] = useBoolean(false)
  const dragOptions = React.useMemo(
    (): IDragOptions => ({
      moveMenuItemText: 'Move',
      closeMenuItemText: 'Close',
      menu: ContextualMenu,
      keepInBounds,
    }),
    [keepInBounds],
  )
  const titleId = useId('title')
  const subTitleId = useId('subTitle')
  const cancelIcon: IIconProps = { iconName: 'Cancel' }
  // const customIcon: IImageProps = {
  //   imageFit: ImageFit.cover,
  //   src: Images.pinTomato,
  //   alt: 'ImgTomates',
  // }
  const openIcon: IIconProps = { iconName: 'BulletedList2' }
  return (
    <Stack horizontal grow verticalAlign="center" horizontalAlign="center">

      <Stack.Item align="center" verticalFill={true} grow={true}>
        
        <DocumentCard styles={cardStyles1}>
          <DocumentCardImage
            height={200}
            width={250}
            imageFit={ImageFit.contain}
            imageSrc={Images.empaque}
            styles={{
              root: {
                boxShadow: '10px 10x 10px ##ffffff00',
                backgroundColor: '#ffffff00',
                backgroundPosition: 'center',
                backgroundSize: 'cover',
                cursor: 'pointer',
                transition: 'all 0.65s',
                '&:hover': {
                  fill: 'purple',
                  transform: 'rotateY(360deg)',
                  transition: 'all 1.5s',
                },
              },
            }}
          />
          <Image
            src={Images.madeinmx}
            imageFit={1}
            alt="sunnyfresh"
            styles={{
              root: {
                width: '40px',
                display: 'flex',
                position: 'fixed',
                marginTop: '-200px',
                marginRight: '100px',
                marginLeft: '210px',
                flexDirection: 'column',
                justifyContent: 'center',
                alignItems: 'center',
              },
            }}
          />
          <DocumentCardDetails>
            <Stack
              horizontal
              grow
              verticalAlign="center"
              horizontalAlign="center"
              tokens={{ childrenGap: 1 }}
            >
              <Stack.Item grow={true} verticalFill={true} align={'center'}>
                <ImageIcon
                  onClick={showModal}
                  imageProps={{
                    imageFit: ImageFit.contain,
                    src: Images.pinTomato,
                    alt: 'ImgTomates',
                    style: {
                      marginLeft: 'auto',
                      marginTop: '4px',
                      marginRight: '2px',
                      borderRadius: '50%',
                      position: 'static',
                      width: '50px',
                      height: '50px',
                      backgroundColor: Theme.palette.neutralPrimary,
                      backgroundRepeat: 'no-repeat',
                      backgroundPosition: 'center',
                      backgroundSize: 'cover',
                      cursor: 'pointer',
                      transition: 'all 0.5s',
                    },
                  }}
                  title="EMPAQUE NAVE 1, CULIACAN, SINALOA"
                  aria-label="Nave 1"
                />
              </Stack.Item>
              <Stack.Item grow={true} verticalFill={true} align={'center'}>
                <IconButton
                  onClick={showModal}
                  iconProps={openIcon}
                  title="EMPAQUE NAVE 2, CULIACAN, SINALOA"
                  ariaLabel="Nave 2"
                  styles={iconButtonStyles}
                />
              </Stack.Item>
            </Stack>
            <DocumentCardTitle
              title="Moroleon"
              shouldTruncate
              styles={{
                root: {
                  fontSize: '25px',
                  fontWeight: 500,
                  color: Theme.palette.themePrimary,
                  textAlign: 'center',
                  backgroundColor: '#ffffff00',
                  backgroundRepeat: 'no-repeat',
                  backgroundPosition: 'center',
                  backgroundSize: 'cover',
                  cursor: 'pointer',
                  transition: 'all 0.5s',
                  '&:hover': {
                    fill: 'white',
                    transform: 'rotateY(360deg)',
                    transition: 'all 1.5s',
                    color: Theme.palette.white,
                  },
                },
              }}
            />
            {/* <DocumentCardTitle title="Sunset" shouldTruncate /> */}
            {/* <DetailsList
        items={this._allItems}
        columns={this._columns}
        setKey="set"
        layoutMode={DetailsListLayoutMode.justified}
        selectionPreservedOnEmptyClick={true}
        ariaLabelForSelectionColumn="Toggle selection"
        ariaLabelForSelectAllCheckbox="Toggle selection for all items"
        checkButtonAriaLabel="select row"
        onRenderDetailsFooter={this._onRenderDetailsFooter}
      /> */}
          </DocumentCardDetails>
        </DocumentCard>

      </Stack.Item>

      <Stack.Item align="center" verticalFill={true} grow={true}>
        <DocumentCard styles={cardStyles2}>
          <DocumentCardImage
            height={200}
            width={250}
            imageFit={ImageFit.contain}
            imageSrc={Images.empaque}
            styles={{
              root: {
                boxShadow: '10px 10x 10px ##ffffff00',
                backgroundColor: '#ffffff00',
                backgroundPosition: 'center',
                backgroundSize: 'cover',
                cursor: 'pointer',
                '&:hover': {
                  fill: 'purple',
                  transform: 'rotateY(360deg)',
                  transition: 'all 1.5s',
                },
              },
            }}
          />
          <Image
            src={Images.madeinmx}
            imageFit={1}
            alt="sunnyfresh"
            styles={{
              root: {
                width: '40px',
                display: 'flex',
                position: 'fixed',
                marginTop: '-200px',
                marginRight: '100px',
                marginLeft: '210px',
                flexDirection: 'column',
                justifyContent: 'center',
                alignItems: 'center',
              },
            }}
          />
          <DocumentCardDetails>
            <Stack
              horizontal
              grow
              verticalAlign="center"
              horizontalAlign="center"
              tokens={{ childrenGap: 1 }}
            >
              <Stack.Item grow={true} verticalFill={true} align={'center'}>
                <IconButton
                  onClick={showModal}
                  iconProps={openIcon}
                  title="EMPAQUE R2 01,TULA,TAMAULIPAS"
                  ariaLabel="Nave 1"
                  styles={iconButtonStyles}
                />
              </Stack.Item>
              <Stack.Item grow={true} verticalFill={true} align={'center'}>
                <IconButton
                  onClick={showModal}
                  iconProps={openIcon}
                  title="EMPAQUE R2 02,TULA,TAMAULIPAS"
                  ariaLabel="Nave 1"
                  styles={iconButtonStyles}
                />
              </Stack.Item>
            </Stack>
            <DocumentCardTitle
              title="Sigma"
              shouldTruncate
              styles={{
                root: {
                  fontSize: '25px',
                  fontWeight: 500,
                  color: Theme.palette.themePrimary,
                  textAlign: 'center',
                },
              }}
            />
            {/* <DocumentCardTitle title="Sunset" shouldTruncate /> */}
            {/* <DetailsList
        items={this._allItems}
        columns={this._columns}
        setKey="set"
        layoutMode={DetailsListLayoutMode.justified}
        selectionPreservedOnEmptyClick={true}
        ariaLabelForSelectionColumn="Toggle selection"
        ariaLabelForSelectAllCheckbox="Toggle selection for all items"
        checkButtonAriaLabel="select row"
        onRenderDetailsFooter={this._onRenderDetailsFooter}
      /> */}
          </DocumentCardDetails>
        </DocumentCard>
      </Stack.Item>

      <Stack.Item align="center" verticalFill={true} grow={true}>
        <Modal
          // titleAriaId={getCodEntProduccion({ CodEntProduccion:  })}
          titleAriaId={titleId}
          subtitleAriaId={subTitleId}
          isOpen={isModalOpen}
          onDismiss={hideModal}
          isBlocking={false}
          containerClassName={contentStyles.container}
          dragOptions={isDraggable ? dragOptions : undefined}
        >
          <div className={contentStyles.header}>
            <Separator theme={Theme} styles={ISepStyles}>
              <h3>Moroleon</h3>
              <h4>Empaque Nave 1, Culiacan, Sinaloa</h4>
            </Separator>
            <IconButton
              iconProps={cancelIcon}
              ariaLabel="Close popup modal"
              onClick={hideModal}
            />
          </div>

          <div className={contentStyles.body}>
            <Pivot aria-label="Empaque" styles={pivotStyles}>
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
                <CuartoFrioBerenjenaTest />
              </PivotItem>
            </Pivot>
          </div>
        </Modal>
      </Stack.Item>

    </Stack>
  )
}
