
igRegisterScript("WebGridBooleanCellTemplate", (ctx) => {
    var html = window.igTemplating.html;
    if (ctx.cell.value) {
        return html`<img src="https://static.infragistics.com/xplatform/images/grid/active.png" title="Continued" alt="Continued" />`
    } else {
        return html`<img src="https://static.infragistics.com/xplatform/images/grid/expired.png" title="Discontinued" alt="Discontinued" />`;
    }
}, false);

igRegisterScript("WebGridSetGridSize", (sender, evtArgs) => {
    var newVal = evtArgs.newValue.toLowerCase();
    var grid = document.getElementById("grid");
    grid.style.setProperty('--ig-size', `var(--ig-size-${newVal})`);
}, false);

