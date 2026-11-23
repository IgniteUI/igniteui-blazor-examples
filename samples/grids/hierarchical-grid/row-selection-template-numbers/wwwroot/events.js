import { registerScript, html } from './_content/IgniteUI.Blazor/api.js';

registerScript("WebGridRowSelectorTemplate", (ctx) => {
    if (ctx.implicit.selected) {
        return html`<div style="justify-content: space-evenly;display: flex;width: 70px;">
    <span> ${ctx.implicit.index}</span>
<igc-checkbox checked></igc-checkbox>
</div>`;
    } else {
        return html`<div style="justify-content: space-evenly;display: flex;width: 70px;">
    <span> ${ctx.implicit.index}</span>
<igc-checkbox></igc-checkbox>
</div>`;
    }
});

registerScript("WebGridHeaderRowSelectorTemplate", (ctx) => {
    return html`<div style="width: 70px;height: 60px;display: flex;">
    <img src="https://dl.infragistics.com/x/img/browsers/ig.png" class="header-image">
</div>`;
});

