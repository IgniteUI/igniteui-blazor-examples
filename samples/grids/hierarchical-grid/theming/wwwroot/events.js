import { registerScript, html } from './_content/IgniteUI.Blazor/api.js';

registerScript("HierarchicalGridThemingPhotoCellTemplate", (ctx) => {
    return html`<div class="cell__inner_2">
    <img src="${ctx.cell.value}" class="photo" />
</div>`;
});

// Show the debut year as is, without a thousands separator.
registerScript("HierarchicalGridThemingDebutFormatter", (value) => {
    return value;
});
