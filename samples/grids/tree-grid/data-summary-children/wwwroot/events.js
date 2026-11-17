import { registerScript } from './_content/IgniteUI.Blazor/api.js';

registerScript("WebTreeGridChangeSummaryCalculationMode", (sender, evtArgs) => {
    var treeGrid = document.getElementById("treeGrid");
	treeGrid.summaryCalculationMode = evtArgs.newValue;
});

registerScript("WebTreeGridChangeSummaryPosition", (sender, evtArgs) => {
    var treeGrid = document.getElementById("treeGrid");
	treeGrid.summaryPosition = evtArgs.newValue;
});

