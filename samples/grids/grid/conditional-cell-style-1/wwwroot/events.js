import { registerScript, html } from './_content/IgniteUI.Blazor/api.js';

registerScript("WebGridImageCellTemplate", (ctx) => {
    return html`<div>
    <img src="${ctx.cell.value}"
    style="border: 1px solid black;
    object-fit: fill;
    height: 2rem;
    width: 3rem;"/>
 </div>`;
});

registerScript("WebGridBeatsPerMinuteCellClassesHandler", () => {
    return {
        upFont: (rowData, columnKey) => rowData[columnKey] > 95,
        downFont: (rowData, columnKey) => rowData[columnKey] <= 95
    };
}, true);

registerScript("WebGridTopSpeedCellClassesHandler", () => {
    return {
        topSpeed: (rowData, columnKey) => rowData[columnKey] < 5
    };
}, true);

