
igRegisterScript("WebGridProgressCellTemplate", (ctx) => {
    var html = window.igTemplating.html;
    return html`<div style="width: 4rem">
    <igc-linear-progress value="${ctx.cell.value}"></igc-linear-progress>
 </div>`;
}, false);

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

