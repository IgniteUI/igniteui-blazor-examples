import { registerScript } from './_content/IgniteUI.Blazor/api.js';

registerScript("WebHierarchicalGridPinRowOnRendered", (event) => {
	var hierarchicalGrid = document.getElementById("grid");
	hierarchicalGrid.pinRow(hierarchicalGrid.data[0].Photo);
	hierarchicalGrid.pinRow(hierarchicalGrid.data[1].Photo);
});

