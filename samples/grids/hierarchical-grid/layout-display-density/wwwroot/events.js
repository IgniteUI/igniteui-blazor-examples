import { registerScript } from './_content/IgniteUI.Blazor/api.js';

registerScript("WebHierarchicalGridSetGridSize", (sender, evtArgs) => {
    var newVal = evtArgs.newValue.toLowerCase();
    var grid = document.getElementById("hierarchicalGrid");
    grid.style.setProperty('--ig-size', `var(--ig-size-${newVal})`);
});

