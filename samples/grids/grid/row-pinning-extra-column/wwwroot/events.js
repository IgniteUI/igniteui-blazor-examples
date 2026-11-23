import { registerScript, html } from './_content/IgniteUI.Blazor/api.js';

registerScript("WebGridRowPinCellTemplate", (ctx) => {
    window.toggleRowPin = function toggleRowPin(index) {
        var grid = document.getElementsByTagName("igc-grid")[0];
        grid.getRowByIndex(index).pinned = !grid.getRowByIndex(index).pinned;
    }
    var grid = document.getElementsByTagName("igc-grid")[0];
    const index = ctx.cell.id.rowIndex;
    const row = grid.rowList.toArray().find(x => x.index === index);
    if (row && row.pinned && row.disabled) {
        return html``;
    }
    return html`<div class='customIcon'>
    <span class='customIconSpan' onpointerdown='toggleRowPin("${index}")'>📌</span>
</div>`;
});

