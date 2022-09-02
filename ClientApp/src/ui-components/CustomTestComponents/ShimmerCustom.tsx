import React from "react";
import { Shimmer, IShimmerStyleProps, IShimmerStyles, ShimmerElementsGroup, ShimmerElementType, mergeStyleSets, ThemeProvider, IListProps, IColumn, buildColumns, Toggle, ShimmeredDetailsList, SelectionMode, IShimmerElement, Persona, PersonaPresence, PersonaSize, Stack } from "@fluentui/react";

import { useBoolean, useConst, useSetInterval } from "@fluentui/react-hooks";
import { Theme } from "../../styles/Theme";


const shimmerElements = [
  { type: ShimmerElementType.circle, height: 24 },
  { type: ShimmerElementType.gap, width: '2%' },
  { type: ShimmerElementType.line, height: 16, width: '20%' },
  { type: ShimmerElementType.gap, width: '5%' },
  { type: ShimmerElementType.line, height: 16, width: '20%' },
  { type: ShimmerElementType.gap, width: '10%' },
  { type: ShimmerElementType.line, height: 16, width: '15%' },
  { type: ShimmerElementType.gap, width: '10%' },
  { type: ShimmerElementType.line, height: 16 },
];


const LOREM_IPSUM = (
  'lorem ipsum dolor sit amet consectetur adipiscing elit sed do eiusmod tempor incididunt ut ' +
  'labore et dolore magna aliqua ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut ' +
  'aliquip ex ea commodo consequat duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore ' +
  'eu fugiat nulla pariatur excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt '
).split(' ');
let loremIndex = 0;
function _lorem(wordCount: number): string {
  const startIndex = loremIndex + wordCount > LOREM_IPSUM.length ? 0 : loremIndex;
  loremIndex = startIndex + wordCount;
  return LOREM_IPSUM.slice(startIndex, loremIndex).join(' ');
}

const wrapperClass = mergeStyleSets({
  wrapper: {
    selectors: {
      '& > .ms-Shimmer-container': {
        margin: '10px 0',
      },
    },
  },
  themedBackgroundWrapper: {
    padding: 20,
    margin: '10px 0',
    height: 100,
    boxSizing: 'border-box',
    display: 'flex',
    alignItems: 'center',
    justifyContent: 'stretch',
    // using the palette color to match the gaps and borders of the shimmer.
    background: Theme.palette.white,
    selectors: {
      '& > .ms-Shimmer-container': {
        flexGrow: 1,
      },
    },
  },
  themedBackgroundWrapper2: {
    width: 400,
    height: 100,
    margin: '10px 0',
    display: 'flex',
    alignItems: 'center',
    justifyContent: 'center',
    // using the palette color to match the gaps and borders of the shimmer.
    background: Theme.palette.white,
    outline: `1px solid ${Theme.palette.neutralPrimary}`,
    outlineOffset: '-10px',
  },
  indent: {
    paddingLeft: 18,
  },
});

// const wrapperStyles = { display: 'flex' };

// Passing a color to match the background color of the containing div.
const getCustomElements = (backgroundColor?: string) => {
  return (
    <Stack style={{ display: 'flex' }}>
      <ShimmerElementsGroup
        backgroundColor={backgroundColor}
        shimmerElements={[
          { type: ShimmerElementType.circle, height: 40 },
          { type: ShimmerElementType.gap, width: 16, height: 40 },
        ]}
      />
      <ShimmerElementsGroup
        backgroundColor={backgroundColor}
        flexWrap
        width="100%"
        shimmerElements={[
          { type: ShimmerElementType.line, width: '100%', height: 10, verticalAlign: 'bottom' },
          { type: ShimmerElementType.line, width: '90%', height: 8 },
          { type: ShimmerElementType.gap, width: '10%', height: 20 },
        ]}
      />
    </Stack>
  );
};

const getShimmerStyles = (props: IShimmerStyleProps): IShimmerStyles => {
  return {
    shimmerWrapper: [
      {
        backgroundColor: '#deecf9',
      },
    ],
    shimmerGradient: [
      {
        backgroundColor: '#deecf9',
        backgroundImage:
          'linear-gradient(to right, rgba(255, 255, 255, 0) 0%, #c7e0f4 50%, rgba(255, 255, 255, 0) 100%)',
      },
    ],
  };
};


interface IDocument {
  key: string;
  name: string;
  value: string;
  iconName: string;
  fileType: string;
  modifiedBy: string;
  dateModified: string;
  dateModifiedValue: number;
  fileSize: string;
  fileSizeRaw: number;

}

interface IShimmerAppState {
  lastIntervalId: number;
  visibleCount: number;
  shimmerElements: IShimmerElement[];
  isDataLoaded: boolean;
  isShimmering: boolean;
  isThemeSwitched: boolean;
  isCustomElementsSwitched: boolean;
  isCustomBackgroundSwitched: boolean;
  isToggled: boolean;
  isSelectionToggled: boolean;
  selectionMode: SelectionMode;
  columns: IColumn[];
  items: IDocument[];
  selection: string[];
  isHeaderVisible: boolean;
  isRowVisible: boolean;
  isGapVisible: boolean;
  isLineVisible: boolean;
  isCircleVisible: boolean;
  isColumnVisible: boolean;
  isListVisible: boolean;
  isDetailsListVisible: boolean;
  isShimmeredDetailsListVisible: boolean;
  isToggleVisible: boolean;
  isToggleSelectionVisible: boolean;
  isToggleSelectionModeVisible: boolean;
}

// const ITEMS_COUNT: number = 200;

const INTERVAL_DELAY: number = 1200;

const toggleStyle: React.CSSProperties = {
  marginBottom: '20px',
};
const shimmeredDetailsListProps: IListProps = {
  renderedWindowsAhead: 0,
  renderedWindowsBehind: 0,
};

const fileIcons: { name: string }[] = [
  { name: 'accdb' },
  { name: 'audio' },
  { name: 'code' },
  { name: 'csv' },
  { name: 'docx' },
  { name: 'dotx' },
  { name: 'mpt' },
  { name: 'model' },
  { name: 'one' },
  { name: 'onetoc' },
  { name: 'pdf' },
  { name: 'photo' },
  { name: 'pptx' },
  { name: 'presentation' },
  { name: 'potx' },
  { name: 'pub' },
  { name: 'rtf' },
  { name: 'spreadsheet' },
  { name: 'txt' },
  { name: 'vector' },
  { name: 'vsdx' },
  { name: 'xlsx' },
  { name: 'xltx' },
  { name: 'xsn' },
];

const randomFileIcon = (): { docType: string; url: string } => {
  const docType: string = fileIcons[Math.floor(Math.random() * fileIcons.length) + 0].name;
  return {
    docType,
    url: `https://static2.sharepointonline.com/files/fabric/assets/item-types/16/${docType}.svg`,
  };
};


// const onRenderItemColumn = (item: IExampleItem, index: number, column: IColumn): JSX.Element | string | number => {
//   if (column.key === 'thumbnail') {
//     return <img src={item.thumbnail} alt="thumbnail"/>;
//   }
//   return item[column.key as keyof IExampleItem];
// };


const _onRenderItemColumn = (item: IDocument , _index: any, column: IColumn): JSX.Element | string | number => {
  if (column.key === 'fileIcons') {
    return <img src={item.fileType} alt="thumbnail"/>;
  }
  return item[column.key as keyof IDocument];
}

const exampleItems: IDocument[] = _generateDocuments().map((item: IDocument) => {
  const randomFileType = randomFileIcon();
  return { ...item, thumbnail: randomFileType.url };
});

export const ShimmerCustom: React.FunctionComponent = () => {
  const { current: state } = React.useRef<IShimmerAppState>({
    lastIntervalId: 0,
    visibleCount: 0,
    shimmerElements: [],
    isDataLoaded: false,
    isShimmering: false,
    isThemeSwitched: false,
    isCustomElementsSwitched: false,
    isCustomBackgroundSwitched: false,
    isToggled: false,
    isSelectionToggled: false,
    selectionMode: SelectionMode.none,
    columns: [],
    items: [],
    selection: [],
    isHeaderVisible: true,
    isRowVisible: false,
    isGapVisible: false,
    isLineVisible: false,
    isCircleVisible: false,
    isColumnVisible: false,
    isListVisible: false,
    isDetailsListVisible: false,
    isShimmeredDetailsListVisible: false,
    isToggleVisible: false,
    isToggleSelectionVisible: false,
    isToggleSelectionModeVisible: false,

  });

  const [items, setItems] = React.useState<(IDocument | null)[] | undefined>(undefined);

  const shimmerColumns: IColumn[] = useConst(() => {
    const currentItems = _generateDocuments();
    
    const columns: IColumn[] = buildColumns(currentItems);
    for (const column of columns) {
      if (column.key === 'thumbnail') {
        column.name = 'FileType';
        column.minWidth = 16;
        column.maxWidth = 16;
        column.isIconOnly = true;
        column.iconName = 'Page';
        break;
      }
    }
    return columns;
  });

  const { setInterval, clearInterval } = useSetInterval();


  const onLoadData = React.useCallback(
    (ev: React.MouseEvent<HTMLElement>, checked: boolean | undefined): void => {
      const loadMoreItems = (): void => {
        state.visibleCount = Math.min(exampleItems.length, state.visibleCount + 2);

        setItems(exampleItems.map((current: any, index: any) => (index < state.visibleCount ? current : null)) as IDocument[]);
      };

      state.visibleCount = 0;
      if (checked) {
        loadMoreItems();
        state.lastIntervalId = setInterval(loadMoreItems, INTERVAL_DELAY);
      } else {
        setItems(undefined);
        clearInterval(state.lastIntervalId);
      }
    },
    [clearInterval, setInterval, state],
  );

  const [examplePersona, setExamplePersona] = React.useState({});
  const [contentOne, setContentOne] = React.useState('');
  const [isDataLoadedOne, { toggle: toggleIsDataLoadedOne }] = useBoolean(false);
  const [isDataLoadedTwo, { toggle: toggleIsDataLoadedTwo }] = useBoolean(false);

  const getContentOne = (ev: React.MouseEvent<HTMLElement>, checked: boolean | undefined): void => {
    toggleIsDataLoadedOne();
    setContentOne(!isDataLoadedOne ? 'Congratulations!!! You have successfully loaded the content. ' : '');
  };

  const getContentTwo = (ev: React.MouseEvent<HTMLElement>, checked: boolean | undefined): void => {
    toggleIsDataLoadedTwo();
    setExamplePersona(
      !isDataLoadedTwo
        ? {
            imageUrl:
              'https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/persona-female.png',
            imageInitials: 'AL',
            primaryText: 'Annie Lindqvist',
            secondaryText: 'Software Engineer',
          }
        : {},
    );
  };


  return (
    <div>
    <div className={wrapperClass.wrapper}>
      <Toggle
        checked={isDataLoadedOne}
        // eslint-disable-next-line react/jsx-no-bind
        onChange={getContentOne}
        onText="Toggle to show shimmer"
        offText="Toggle to load content"
      />
      <Shimmer isDataLoaded={isDataLoadedOne} ariaLabel="Loading content">
        <Stack
          style={{
            overflow: 'hidden',
            textOverflow: 'ellipsis',
            whiteSpace: 'nowrap',
            lineHeight: '1',
            minHeight: '16px',
          }}
        >
          {contentOne}
          {contentOne}
          {contentOne}
        </Stack>
      </Shimmer>
      <Toggle
        checked={isDataLoadedTwo}
        // eslint-disable-next-line react/jsx-no-bind
        onChange={getContentTwo}
        onText="Toggle to show shimmer"
        offText="Toggle to load content"
      />
      <Shimmer customElementsGroup={getCustomElements()} width="300" isDataLoaded={isDataLoadedTwo}>
        <Persona {...examplePersona} size={PersonaSize.size40} presence={PersonaPresence.away} />
      </Shimmer>
    </div>
      
      <div>
        Style overrides of shimmering wave and space around in cases where Shimmer is placed on backgrounds different
        than the main background of the app. There are several scenarios that can be considered bellow:
      </div>
      <div>
        <b>1.</b> The recommended way by using the <b>shimmerColors</b> prop which in turn has 2 sub-scenarios:
      </div>
      <div className={wrapperClass.indent}>
        <b>a. </b>When using
        <b>shimmerElements</b> prop to build the placeholder you can pass all 3 possible colors to
        <b>shimmerColors</b> prop.
      </div>
      <div className={wrapperClass.themedBackgroundWrapper}>
        <Shimmer
          shimmerColors={{
            shimmer: Theme.palette.themeTertiary,
            shimmerWave: Theme.palette.themeSecondary,
            background: Theme.palette.white,
          }}
          shimmerElements={shimmerElements}
        />
      </div>
      <div className={wrapperClass.indent}>
        <b>b. </b>When using <b>customElementsGroup</b> prop to build the placeholder:
      </div>
      <div className={wrapperClass.themedBackgroundWrapper2}>
        <Shimmer
          customElementsGroup={getCustomElements(Theme.palette.white)}
          width="300"
          shimmerColors={{
            shimmer: Theme.palette.themeTertiary,
            shimmerWave: Theme.palette.themeSecondary,
          }}
        />
      </div>
      <div>
        <b>2. </b>Another way of doing it by using <b>Customizer</b> component wrapper.
      </div>
      <ThemeProvider theme={Theme}>
        <div className={wrapperClass.themedBackgroundWrapper2}>
          <Shimmer customElementsGroup={getCustomElements()} width="300" />
        </div>
      </ThemeProvider>
      <div>
        <b>3. </b>Style overrides of shimmering wave using <b>styles</b> prop.
      </div>
      <div className={wrapperClass.wrapper}>
        <Shimmer width="75%" styles={getShimmerStyles} />
        <Shimmer width="75%" styles={getShimmerStyles} />
        <Shimmer width="75%" styles={getShimmerStyles} />
        <Shimmer width="75%" styles={getShimmerStyles} />
        <Shimmer width="75%" styles={getShimmerStyles} />
      </div>

      <div>
        <Toggle
          style={toggleStyle}
          label="Toggle to load content"
          onChange={onLoadData}
          onText="Content"
          offText="Shimmer"
        />
        <div>
          <ShimmeredDetailsList
            setKey="items"
            items={items || []}
            columns={shimmerColumns}
            selectionMode={SelectionMode.none}
            isHeaderVisible={state.isHeaderVisible}
            onRenderItemColumn={_onRenderItemColumn as any}
            enableShimmer={!items}
            ariaLabelForShimmer="Content is being fetched"
            ariaLabelForGrid="Item details"
            listProps={shimmeredDetailsListProps}
          />
        </div>
      </div>



    </div>
  );
};
export default ShimmerCustom;


function _generateDocuments() {
  const items: IDocument[] = [];
  for (let i = 0; i < 500; i++) {
    const randomDate = _randomDate(new Date(2012, 0, 1), new Date());
    const randomFileSize = _randomFileSize();
    const randomFileType = _randomFileIcon();
    let fileName = _lorem(2);
    fileName = fileName.charAt(0).toUpperCase() + fileName.slice(1).concat(`.${randomFileType.docType}`);
    let userName = _lorem(2);
    userName = userName
      .split(' ')
      .map((name: string) => name.charAt(0).toUpperCase() + name.slice(1))
      .join(' ');
    items.push({
      key: i.toString(),
      name: fileName,
      value: fileName,
      iconName: randomFileType.url,
      fileType: randomFileType.docType,
      modifiedBy: userName,
      dateModified: randomDate.dateFormatted,
      dateModifiedValue: randomDate.value,
      fileSize: randomFileSize.value,
      fileSizeRaw: randomFileSize.rawSize,
    });
  }
  return items;
}


function _randomDate(start: Date, end: Date): { value: number; dateFormatted: string } {
  const date: Date = new Date(start.getTime() + Math.random() * (end.getTime() - start.getTime()));
  return {
    value: date.valueOf(),
    dateFormatted: date.toLocaleDateString(),
  };
}

function _randomFileIcon(): { docType: string; url: string } {
  const docType: string = fileIcons[Math.floor(Math.random() * fileIcons.length)].name;
  return {
    docType,
    url: `https://static2.sharepointonline.com/files/fabric/assets/item-types/16/${docType}.svg`,
  };
}

function _randomFileSize(): { value: string; rawSize: number } {
  const fileSize: number = Math.floor(Math.random() * 100) + 30;
  return {
    value: `${fileSize} KB`,
    rawSize: fileSize,
  };
}



// function buildCust(items: IExampleItem[]): IColumn[] {
//   const columns: IColumn[] = [];
//   const iconColumn: IColumn = {
//     key: 'thumbnail',
//     name: 'FileType',
//     fieldName: 'thumbnail',
//     minWidth: 16,
//     maxWidth: 16,
//     isIconOnly: true,
//     iconName: 'Page',
//     isResizable: false,
//     data: 'string',
//     onRender: (item: IExampleItem) => {
//       return <img src={item.thumbnail} alt={item.name} />;
//     }
//   };
//   columns.push(iconColumn);
//   for (const item of items) {
//     const column: IColumn = {
//       key: item.key,
//       name: item.name,
//       fieldName: item.key,
//       minWidth: 100,
//       maxWidth: 200,
//       isResizable: true,
//       data: 'string',
//       onRender: (item: IExampleItem) => {
//         return item.value;
//       }
//     };
//     columns.push(column);
//   }
//   return columns;
// }


