import { registerScript } from './_content/IgniteUI.Blazor/api.js';

registerScript("WebGridGrammyNominationsCellClassesHandler", () => {
    return {
        downFont: (rowData, columnKey) => rowData[columnKey] < 5,
        upFont: (rowData, columnKey) => rowData[columnKey] >= 6
    };
}, true);

