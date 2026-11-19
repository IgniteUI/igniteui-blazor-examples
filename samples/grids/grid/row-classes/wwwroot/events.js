import { registerScript } from './_content/IgniteUI.Blazor/api.js';

registerScript("WebGridRowClassesHandler", () => {
    return {
        activeRow: (row) => row.index % 2 === 0
    };
}, true);

