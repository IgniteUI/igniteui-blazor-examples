import { registerScript } from './_content/IgniteUI.Blazor/api.js';

registerScript("WebGridSetRowPinning", (sender, evtArgs) => {
    var item = sender;
    var newVal = item.primitiveValue;
    var grid = document.getElementById("treeGrid") || document.getElementById("grid");
    grid.pinning.rows = newVal === "Top" ? 0 : 1;
});

registerScript("WebTreeGridPinRowOnRendered", (event) => {
        var treeGrid = document.getElementById("treeGrid") || document.getElementById("grid");
        treeGrid.data = [...treeGrid.data];
        treeGrid.pinRow(1);
        treeGrid.pinRow(11);
});

