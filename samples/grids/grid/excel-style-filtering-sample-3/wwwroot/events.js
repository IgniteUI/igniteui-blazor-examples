
igRegisterScript("WebGridFilterAltIconTemplate", (ctx) => {
    var html = window.igTemplating.html;
        return html`<img height="15px" width="15px" src="http://dl.infragistics.com/x/img/grid/propeller-logo.sv" title="Continued" alt="Continued" />`
}, false);

igRegisterScript("WebGridBooleanCellTemplate", (ctx) => {
    var html = window.igTemplating.html;
    if (ctx.cell.value) {
        return html`<img src="https://dl.infragistics.com/x/img/grid/active.png" title="Continued" alt="Continued" />`
    } else {
        return html`<img src="https://dl.infragistics.com/x/img/grid/expired.png" title="Discontinued" alt="Discontinued" />`;
    }
}, false);

