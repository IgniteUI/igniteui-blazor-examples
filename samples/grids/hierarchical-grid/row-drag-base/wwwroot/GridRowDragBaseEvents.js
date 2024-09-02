function OnHierarchicalRowDragEndHandler(evt) {    
    const ghostElement = evt.detail.dragDirective.ghostElement;
    const dragElementPos = ghostElement.getBoundingClientRect();
    const gridPosition = hierarchicalGrid2.getBoundingClientRect();
    const withinXBounds = dragElementPos.x >= gridPosition.x && dragElementPos.x <= gridPosition.x + gridPosition.width;
    const withinYBounds = dragElementPos.y >= gridPosition.y && dragElementPos.y <= gridPosition.y + gridPosition.height;
    if (withinXBounds && withinYBounds) {        
        hierarchicalGrid2.addRow(evt.detail.dragData.data);         
    }
}

igRegisterScript("OnHierarchicalRowDragEndHandler", OnHierarchicalRowDragEndHandler, false);