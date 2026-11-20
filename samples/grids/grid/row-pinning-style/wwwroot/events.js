import { registerScript } from './_content/IgniteUI.Blazor/api.js';

registerScript("WebGridPinRowOnRendered", (event) => {
        var grid = document.getElementById("grid");
        grid.pinRow("ALFKI");
        grid.pinRow("AROUT");
});

