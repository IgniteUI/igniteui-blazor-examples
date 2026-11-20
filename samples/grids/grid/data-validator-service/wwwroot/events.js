import { registerScript, html } from './_content/IgniteUI.Blazor/api.js';

registerScript("WebGridAvatarCellTemplate", (ctx) => {
    return html`<div>
    <igc-avatar shape="circle" src="${ctx.cell.value}">
    </igc-avatar>
</div>`;
});

