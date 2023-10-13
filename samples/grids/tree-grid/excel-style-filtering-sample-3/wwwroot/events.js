
igRegisterScript("WebGridFilterAltIconTemplate", (ctx) => {
    var html = window.igTemplating.html;
        return html`<img height="15px" width="15px" src="http://static.infragistics.com/xplatform/images/grid/propeller-logo.svg" title="Continued" alt="Continued" />`
}, false);

igRegisterScript("WebGridBooleanCellTemplate", (ctx) => {
    var html = window.igTemplating.html;
    if (ctx.cell.value) {
        return html`<img src="https://www.infragistics.com/angular-demos-lob/assets/images/grid/active.png" title="Continued" alt="Continued" />`
    } else {
        return html`<img src="https://www.infragistics.com/angular-demos-lob/assets/images/grid/expired.png" title="Discontinued" alt="Discontinued" />`;
    }
}, false);

