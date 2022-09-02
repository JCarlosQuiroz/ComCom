import * as React from 'react';
import {
    DetailsHeader,
    DetailsList,
    IColumn,
    IDetailsHeaderProps,
    IDetailsList,
    IGroup,
    IRenderFunction,
    IToggleStyles,
    mergeStyles,
    Toggle,
} from '@fluentui/react';
import { DefaultButton, IButtonStyles } from '@fluentui/react/lib/Button';

const margin = '0 20px 20px 0';
const controlWrapperClass = mergeStyles({
    display: 'flex',
    flexWrap: 'wrap',
});
const toggleStyles: Partial<IToggleStyles> = {
    root: { margin: margin },
    label: { marginLeft: 10 },
};
const addItemButtonStyles: Partial<IButtonStyles> = { root: { margin: margin } };

// const IDetailListProps = {
//     items: [
//         {
//             key: '1',
//             name: 'John Smith',
//             age: 42,
//             location: 'Phoenix, AZ',
//         },
//         {
//             key: '2',
//             name: 'Randal White',
//             age: 30,
//             location: 'San Francisco, CA',
//         },
//         {
//             key: '3',
//             name: 'Stephanie Johnson',
//             age: 45,
//             location: 'New York, NY',
//         },
//         {
//             key: '4',
//             name: 'Steve Brown',
//             age: 57,
//             location: 'New York, NY',
//         },
//         {
//             key: '5',
//             name: 'John Smith',
//             age: 42,
//             location: 'Phoenix, AZ',
//         },
//         {
//             key: '6',
//             name: 'Randal White',
//             age: 30,
//             location: 'San Francisco, CA',
//         },
//     ],
// };
export interface IDetailsListGroupedExampleItem {
    key: string;
    name: string;
    color: string;
    item:  number | string | undefined;	
    index: number | string | undefined;	
}
export interface ExampleState{
    iconProps: { iconName: string };
    description: string;
    location: string;
    date: string;
    time: string;
    status: string;
    actions: string[];
    isExpanded: boolean | undefined;
    isSelected: boolean | undefined;
    isChecked: boolean | undefined;
    isGroupHeader: boolean | undefined;
    isRowHeader: boolean | undefined;
    isItem: boolean | undefined;
}

export interface IDetailsListGroupedExampleState {
    items: IDetailsListGroupedExampleItem[];
    groups: IGroup[];
    showItemIndexInView: boolean;
    isCompactMode: boolean;
}
const _blueGroupIndex = 2;

export class CuartoFrioPepinoGrouped extends React.Component<{}, IDetailsListGroupedExampleState> {
    private _root = React.createRef<IDetailsList>();
    private _columns: IColumn[];

    constructor(props: {}) {
        super(props);

        this.state = {
            items: [
                { key: 'a', name: 'a', color: 'red', item: 1, index: 1 },
                { key: 'b', name: 'b', color: 'red', item: 2, index: 2 },
                { key: 'c', name: 'c', color: 'blue', item: 3, index: 3 },
                { key: 'd', name: 'd', color: 'blue', item: 4, index: 4 },
                { key: 'e', name: 'e', color: 'blue', item: 5, index: 5 },
            ],
            // This is based on the definition of items
            groups: [
                { key: 'groupred0', name: 'Color: "red"', startIndex: 0, count: 2, level: 0 },
                { key: 'groupgreen2', name: 'Color: "green"', startIndex: 2, count: 0, level: 0 },
                { key: 'groupblue2', name: 'Color: "blue"', startIndex: 2, count: 3, level: 0 },
            ],
            showItemIndexInView: false,
            isCompactMode: false,
        };

        this._columns = [
            { key: 'name', name: 'Name', fieldName: 'name', minWidth: 100, maxWidth: 200, isResizable: true },
            { key: 'color', name: 'Color', fieldName: 'color', minWidth: 100, maxWidth: 200 },
        ];
    }

    public componentWillUnmount() {
        if (this.state.showItemIndexInView) {
            const itemIndexInView = this._root.current!.getStartItemIndexInView();
            alert('first item index that was in view: ' + itemIndexInView);
        }
    }

    public render() {
        const { items, groups, isCompactMode } = this.state;

        return (
            <div>
                <div className={controlWrapperClass}>
                    <DefaultButton onClick={this._addItem} text="Add an item" styles={addItemButtonStyles} />
                    <Toggle
                        label="Compact mode"
                        inlineLabel
                        checked={isCompactMode}
                        // onChange={this._onChangeCompactMode}
                        styles={toggleStyles}
                    />
                    <Toggle
                        label="Show index of first item in view when unmounting"
                        inlineLabel
                        checked={this.state.showItemIndexInView}
                        // onChange={this._onShowItemIndexInViewChanged}
                        styles={toggleStyles}
                    />
                </div>
                <DetailsList
                    componentRef={this._root}
                    items={items}
                    groups={groups}
                    columns={this._columns}
                    ariaLabelForSelectAllCheckbox="Toggle selection for all items"
                    ariaLabelForSelectionColumn="Toggle selection"
                    checkButtonAriaLabel="select row"
                    checkButtonGroupAriaLabel="select section"
                    onRenderDetailsHeader={this._onRenderDetailsHeader.arguments}
                    groupProps={{
                        showEmptyGroups: true,
                    }}
                    // onRenderItemColumn={this._onRenderItemColumn[]}
                    compact={isCompactMode}
                />
            </div>
        );
    }

    private _addItem = (): void => {
        const items = this.state.items;
        const groups = [...this.state.groups];
        groups[_blueGroupIndex].count++;

        this.setState(
            {
                items: items.concat([
                    {
                        key: 'item-' + items.length,
                        name: 'New item ' + items.length,
                        color: 'blue',
                        item: items.length,
                        index: items.length,
                    },
                ]),
                groups,
            },
            () => {
                if (this._root.current) {
                    this._root.current.focusIndex(items.length, true);
                }
            },
        );
    };

    private _onRenderDetailsHeader(props: IDetailsHeaderProps, _defaultRender?: IRenderFunction<IDetailsHeaderProps>) {
        return <DetailsHeader {...props} ariaLabelForToggleAllGroupsButton={'Expand collapse groups'} />;
    }

    private _onRenderColumn(item: IDetailsListGroupedExampleItem, index: number, column: IColumn) {
        const value =
            item && column && column.fieldName ? item[column.fieldName as keyof IDetailsListGroupedExampleItem] || '' : '';

        return <div data-is-focusable={true}>{value}</div>;
    }

    private _onShowItemIndexInViewChanged = (event: React.MouseEvent<HTMLInputElement>, checked: boolean): void => {
        this.setState({ showItemIndexInView: true });
    };

    private _onChangeCompactMode = (ev: React.MouseEvent<HTMLElement>, checked: boolean): void => {
        this.setState({ isCompactMode: true });
    };
}


export default CuartoFrioPepinoGrouped;