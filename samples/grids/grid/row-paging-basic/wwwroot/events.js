import { registerScript, html } from './_content/IgniteUI.Blazor/api.js';

registerScript("WebGridProgressCellTemplate", (ctx) => {
    return html`<div style="width: 4rem">
    <igc-linear-progress value="${ctx.cell.value}"></igc-linear-progress>
 </div>`;
});

registerScript("WebGridImageCellTemplate", (ctx) => {
    return html`<div>
    <img src="${ctx.cell.value}"
    style="border: 1px solid black;
    object-fit: fill;
    height: 2rem;
    width: 3rem;"/>
 </div>`;
});

