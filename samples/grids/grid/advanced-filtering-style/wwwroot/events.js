import { registerScript, html } from './_content/IgniteUI.Blazor/api.js';

registerScript("WebGridDiscontinuedCellTemplate", (ctx) => {
    if (ctx.cell.value) {
        return html`<img src="https://dl.infragistics.com/x/img/grid/active.png" title="Continued" alt="Continued" />`
    } else {
        return html`<img src="https://dl.infragistics.com/x/img/grid/expired.png" title="Discontinued" alt="Discontinued" />`;
    }
});

