function OnRowDragEndHandler(evt) {
    const ghostElement = evt.detail.dragDirective.ghostElement;
    const dragElementPos = ghostElement.getBoundingClientRect();
    const gridPosition = treeGrid2.getBoundingClientRect();
    const withinXBounds = dragElementPos.x >= gridPosition.x && dragElementPos.x <= gridPosition.x + gridPosition.width;
    const withinYBounds = dragElementPos.y >= gridPosition.y && dragElementPos.y <= gridPosition.y + gridPosition.height;
    if (withinXBounds && withinYBounds) {
        treeGrid2.addRow(evt.detail.dragData.data);
    }
}

igRegisterScript("OnRowDragEndHandler", OnRowDragEndHandler, false);