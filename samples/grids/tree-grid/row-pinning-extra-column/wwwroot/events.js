import { registerScript, html } from './_content/IgniteUI.Blazor/api.js';

registerScript("WebTreeGridRowPinCellTemplate", (ctx) => {
    window.toggleRowPin = function toggleRowPin(index) {
        var treeGrid = document.getElementsByTagName("igc-tree-grid")[0];
        treeGrid.getRowByIndex(index).pinned = !treeGrid.getRowByIndex(index).pinned;
    }
    const index = ctx.cell.id.rowIndex;
    return html`<div>
    <span onpointerdown='toggleRowPin("${index}")'>📌</span>
</div>`;
});

