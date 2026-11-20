import { registerScript } from './_content/IgniteUI.Blazor/api.js';

registerScript("WebGridSetRowPinning", (sender, evtArgs) => {
    var item = sender;
    var newVal = item.primitiveValue;
    var grid = document.getElementById("treeGrid") || document.getElementById("grid");
    grid.pinning.rows = newVal === "Top" ? 0 : 1;
});

