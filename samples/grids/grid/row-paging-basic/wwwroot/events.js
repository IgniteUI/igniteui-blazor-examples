
igRegisterScript("WebGridProgressCellTemplate", (ctx) => {
    var html = window.igTemplating.html;
    return html`<div>
    <igc-linear-progress value="${ctx.cell.value}"></igc-linear-progress>
 </div>`;
}, false);


igRegisterScript("WebGridImageCellTemplate", (ctx) => {
    var html = window.igTemplating.html;
    return html`<div>
    <img src="${ctx.cell.value}"/>
 </div>`;
}, false);


