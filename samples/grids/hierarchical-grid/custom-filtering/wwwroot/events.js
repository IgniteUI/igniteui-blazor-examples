
igRegisterScript("WebGridBooleanCellTemplate", (ctx) => {
    var html = window.igTemplating.html;
    if (ctx.cell.value) {
        return html`<img src="https://static.infragistics.com/xplatform/images/grid/active.png" title="Continued" alt="Continued" />`
    } else {
        return html`<img src="https://static.infragistics.com/xplatform/images/grid/expired.png" title="Discontinued" alt="Discontinued" />`;
    }
}, false);

