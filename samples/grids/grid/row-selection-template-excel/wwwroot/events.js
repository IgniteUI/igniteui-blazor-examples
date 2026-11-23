import { registerScript, html } from './_content/IgniteUI.Blazor/api.js';

registerScript("WebGridRowSelectorExcelTemplate", (ctx) => {
    return html`<span style='display: block;width:30px;'> ${ctx.implicit.index}</span>`;
});

registerScript("WebGridHeaderRowSelectorExcelTemplate", (ctx) => {
    if (ctx.implicit.selectedCount > 0 && ctx.implicit.selectedCount === ctx.implicit.totalCount) {
        return html`<span style='display: block;width:30px;'><i style='color: rgb(239, 184, 209);'>◢</i></span>`;
    } else {
        return html`<span style='display: block;width:30px;'><i>◢</i></span>`;
    }
});

