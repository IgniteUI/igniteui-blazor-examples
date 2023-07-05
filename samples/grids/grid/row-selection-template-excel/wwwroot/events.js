
igRegisterScript("WebGridRowSelectorExcelTemplate", (ctx) => {
    var html = window.igTemplating.html;
    return html`<span style='display: block;width:30px;'> ${ctx.implicit.index}</span>`;
}, false);

igRegisterScript("WebGridHeaderRowSelectorExcelTemplate", (ctx) => {
    var html = window.igTemplating.html;
    if (ctx.implicit.selectedCount > 0 && ctx.implicit.selectedCount === ctx.implicit.totalCount) {
        return html`<span style='display: block;width:30px;'><i style='color: rgb(239, 184, 209);'>◢</i></span>`;
    } else {
        return html`<span style='display: block;width:30px;'><i>◢</i></span>`;
    }
}, false);

