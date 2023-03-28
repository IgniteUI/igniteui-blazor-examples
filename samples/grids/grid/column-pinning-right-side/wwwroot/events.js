
igRegisterScript("WebGridImageCellTemplate", (ctx) => {
    var html = window.igTemplating.html;
    return html`<div>
    <img src="${ctx.cell.value}"
    style="border: 1px solid black;
    object-fit: fill;
    height: 2rem;
    width: 3rem;"/>
 </div>`;
}, false);

igRegisterScript("WebGridAvatarCellTemplate", (ctx) => {
    var html = window.igTemplating.html;
    return html`<div>
    <igc-avatar shape="circle" src="${ctx.cell.value}">
    </igc-avatar>
</div>`;
}, false);

