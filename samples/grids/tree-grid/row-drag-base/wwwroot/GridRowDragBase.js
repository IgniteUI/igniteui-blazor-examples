function addRowAndChildrenTreeGrid(row, newData) {
    if (newData.includes(row)) {
        return;
    }
    else if (newData.length > 0 && row.Employees) {
        for (let i = row.Employees.length; i >= 0; i--) {
            if (newData.includes(row.Employees[i])) {
                let index = newData.findIndex(element => element.ID === row.Employees[i].ID);
                if (index > -1) {
                    newData.splice(index, 1);
                }
            }
        }
    }

    for (let record of newData) {
        if (record.Employees && record.Employees.includes(row)) {
            return;
        }
    }

    newData.push(row);
}
function OnTreeGridRowDragEndHandler(evt) {
    const ghostElement = evt.detail.dragDirective.ghostElement;
    const dragElementPos = ghostElement.getBoundingClientRect();
    const gridPosition = treeGrid2.getBoundingClientRect();
    const withinXBounds = dragElementPos.x >= gridPosition.x && dragElementPos.x <= gridPosition.x + gridPosition.width;
    const withinYBounds = dragElementPos.y >= gridPosition.y && dragElementPos.y <= gridPosition.y + gridPosition.height;
    if (withinXBounds && withinYBounds) {
        const newData = [...treeGrid2.data];
        const draggedRowData = evt.detail.dragData.data;
        addRowAndChildrenTreeGrid(draggedRowData, newData);
        treeGrid2.data = newData;
    }
}

igRegisterScript("OnTreeGridRowDragEndHandler", OnTreeGridRowDragEndHandler, false);