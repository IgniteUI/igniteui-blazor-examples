
igRegisterScript("WebGridAvatarCellTemplate", (ctx) => {
    var html = window.igTemplating.html;
    return html`<div>
    <igc-avatar shape="circle" src="${ctx.cell.value}">
    </igc-avatar>
</div>`;
}, false);

