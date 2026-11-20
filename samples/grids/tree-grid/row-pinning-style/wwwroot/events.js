import { registerScript } from './_content/IgniteUI.Blazor/api.js';

registerScript("WebTreeGridPinRowOnRendered", (event) => {
        var treeGrid = document.getElementById("treeGrid") || document.getElementById("grid");
        treeGrid.data = [...treeGrid.data];
        treeGrid.pinRow(1);
        treeGrid.pinRow(11);
});

