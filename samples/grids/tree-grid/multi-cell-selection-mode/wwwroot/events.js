import { registerScript } from './_content/IgniteUI.Blazor/api.js';

function TreeGridRangeSelectionChanging(o, e) {
    var leftTreeGrid = document.querySelector("#leftTreeGrid");
    var rightGrid = document.querySelector("#rightGrid");
    rightGrid.data = leftTreeGrid.getSelectedData();
}

registerScript("TreeGridRangeSelectionChanging", TreeGridRangeSelectionChanging);