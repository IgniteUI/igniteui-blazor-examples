
const columnGroupStatesHGrid = new Map();
function toggleHierarchicalColumnGroup(name) {
    const grid = document.getElementsByTagName("igc-hierarchical-grid")[0];
    var columnGroup = grid.columns.find((col) => col.header === name)
    const columns = columnGroup.childColumns;
    if (columnGroup.header === 'General Information') {
        const column = columns[1];
        column.hidden = !column.hidden;
    } else if (columnGroup.header === 'Address Information') {
        for (const column of columns) {
            const col = column;
            if (col.header === "Location"){
                for (const cl of col.childColumns) {
                    const c = cl;
                    if (c.field !== "Address"){
                        c.hidden = !c.hidden;
                    }
                }
            }
            else if (col.header === "Contact Information"){
                const c = col.childColumns[1];
                c.hidden = !c.hidden;
            }
        }
    } else {
        for (let i = 1; i < columns.length; i++) {
            const c = columns[i];
            c.hidden = !c.hidden;
        }
    }
    columnGroupStatesHGrid.set(name, !columnGroupStatesHGrid.get(name));
}
igRegisterScript("WebHierarchicalGridColumnGroupHeaderTemplate", (ctx) => {
    var html = window.igTemplating.html;
    var iconName = columnGroupStatesHGrid.get(ctx.column.header) ? '🔽' : '🔼';
    return html`<div>
    <span draggable="false" onclick='toggleHierarchicalColumnGroup("${ctx.column.header}")'>${iconName}</span>
    <span>${ctx.column.header}</span>
</div>`;
}, false);

