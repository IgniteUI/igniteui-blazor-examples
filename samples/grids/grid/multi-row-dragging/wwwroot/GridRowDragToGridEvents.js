function OnRowDragEndHandler(evt) {
    const ghostElement = evt.detail.dragDirective.ghostElement;
    const dragElementPos = ghostElement.getBoundingClientRect();
    const gridPosition = grid2.getBoundingClientRect();
    const withinXBounds = dragElementPos.x >= gridPosition.x && dragElementPos.x <= gridPosition.x + gridPosition.width;
    const withinYBounds = dragElementPos.y >= gridPosition.y && dragElementPos.y <= gridPosition.y + gridPosition.height;
    if (withinXBounds && withinYBounds) {
        for (let id of grid1.selectedRows) {
            const rowData = grid1.getRowData(id);
            grid1.deleteRow(rowData.ID);
            grid2.addRow(rowData);
        }

    }
}

igRegisterScript("OnRowDragEndHandler", OnRowDragEndHandler, false);