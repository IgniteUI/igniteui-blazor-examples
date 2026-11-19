import { registerScript } from './_content/IgniteUI.Blazor/api.js';

registerScript("WebGridSetGridSize", (sender, evtArgs) => {
    var newVal = evtArgs.newValue.toLowerCase();
    var grid = document.getElementById("grid");
    grid.style.setProperty('--ig-size', `var(--ig-size-${newVal})`);
});

