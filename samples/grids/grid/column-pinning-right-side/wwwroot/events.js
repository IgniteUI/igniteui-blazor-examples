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

registerScript("WebGridAvatarCellTemplate", (ctx) => {
    return html`<div>
    <igc-avatar shape="circle" src="${ctx.cell.value}">
    </igc-avatar>
</div>`;
});

