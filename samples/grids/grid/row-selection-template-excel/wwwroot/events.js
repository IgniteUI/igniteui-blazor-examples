
igRegisterScript("WebGridRowSelectorExcelTemplate", (ctx) => {
    var html = window.igTemplating.html;
    var implicit = ctx["$implicit"];
    return html`<span style='display: block;width:30px;'> ${implicit.index}</span>`;
}, false);

igRegisterScript("WebGridHeaderRowSelectorExcelTemplate", (ctx) => {
    var html = window.igTemplating.html;
    var implicit = ctx["$implicit"];
    if (implicit.selectedCount > 0 && implicit.selectedCount === implicit.totalCount) {
        return html`<span style='display: block;width:30px;'><i style='color: rgb(239, 184, 209);'>◢</i></span>`;
    } else {
        return html`<span style='display: block;width:30px;'><i>◢</i></span>`;
    }
}, false);

