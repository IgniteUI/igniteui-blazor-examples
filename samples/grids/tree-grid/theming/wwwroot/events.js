
igRegisterScript("TreeGridThemingNameCellTemplate", (ctx) => {
    var html = window.igTemplating.html;
    return html`<div class="cell__inner">
    <igc-avatar src="${ctx.cell.row.data.Avatar}" shape="circle"></igc-avatar>
    <span class="name">${ctx.cell.value}</span>
</div>`;
}, false);
