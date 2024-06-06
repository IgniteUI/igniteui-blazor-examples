

igRegisterScript("WebTreeGridReorderRowStartHandler", (args) => {
    const draggedRow = args.detail.dragElement;
    const row = this.treeGrid.getRowByIndex(draggedRow.getAttribute('data-rowindex'));
    if (row.expanded) {
        row.expanded = false;
    }
}, false);

igRegisterScript("WebTreeGridReorderRowHandler", (args) => {
    const ghostElement = args.detail.dragDirective.ghostElement;
    const dragElementPos = ghostElement.getBoundingClientRect();
    const grid = document.getElementsByTagName("igc-tree-grid")[0];
    const rows = Array.prototype.slice.call(document.getElementsByTagName("igx-tree-grid-row"));
    const currRowIndex = this.getCurrentRowIndex(rows,
    { x: dragElementPos.x, y: dragElementPos.y });
    if (currRowIndex === -1) { return; }
    const draggedRow = args.detail.dragData.data;
    const childRows = this.findChildRows(grid.data, draggedRow);
    //remove the row that was dragged and place it onto its new location
    grid.deleteRow(args.detail.dragData.key);
    grid.data.splice(currRowIndex, 0, args.detail.dragData.data);
    // reinsert the child rows
    childRows.reverse().forEach(childRow => {
        grid.data.splice(currRowIndex + 1, 0, childRow);
    });
}, false);

function findChildRows(rows, parent) {
    const childRows = [];
    rows.forEach(row => {
        if (row.ParentID === parent.ID) {
            childRows.push(row);
            // Recursively find children of current row
            const grandchildren = this.findChildRows(rows, row);
            childRows.push(...grandchildren);
        }
    });
    return childRows;
}

function getCurrentRowIndex(rowList, cursorPosition) {
    for (const row of rowList) {
        const rowRect = row.getBoundingClientRect();
        if (cursorPosition.y > rowRect.top + window.scrollY && cursorPosition.y < rowRect.bottom + window.scrollY &&
            cursorPosition.x > rowRect.left + window.scrollX && cursorPosition.x < rowRect.right + window.scrollX) {
            // return the index of the targeted row
            return parseInt(row.attributes["data-rowindex"].value);
        }
    }
    return -1;
}

