import { registerScript, html } from './_content/IgniteUI.Blazor/api.js';

const columnGroupStatesTreeGrid = new Map();
function toggleTreeGridColumnGroup(name) {
    const grid = document.getElementsByTagName("igc-tree-grid")[0];
    var columnGroup = grid.columns.find((col) => col.header === name)
    const columns = columnGroup.childColumns;
    if (columnGroup.header === 'General Information') {
        const col = columns[1];
        col.hidden = !col.hidden;
    } else if (columnGroup.header === 'Address Information') {
        for (const col of columns) {
            col.hidden = !col.hidden;
        }
    }
    columnGroupStatesTreeGrid.set(name, !columnGroupStatesTreeGrid.get(name));
}
registerScript("WebTreeGridColumnGroupHeaderTemplate", (ctx) => {
    var iconName = columnGroupStatesTreeGrid.get(ctx.column.header) ? '🔽' : '🔼';
    return html`<div>
    <span draggable="false" onclick='toggleTreeGridColumnGroup("${ctx.column.header}")'>${iconName}</span>
    <span>${ctx.column.header}</span>
</div>`;
});


// called by name from the page, so keep it reachable from the module
window.toggleTreeGridColumnGroup = toggleTreeGridColumnGroup;
