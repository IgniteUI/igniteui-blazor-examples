import { registerScript } from './_content/IgniteUI.Blazor/api.js';

function OnRowDragEndHandler(evt) {
    const ghostElement = evt.detail.dragDirective.ghostElement;
    if (!ghostElement) {
        return;
    }
    const dragElementPos = ghostElement.getBoundingClientRect();
    const gridPosition = grid2.getBoundingClientRect();
    const withinXBounds = dragElementPos.x >= gridPosition.x && dragElementPos.x <= gridPosition.x + gridPosition.width;
    const withinYBounds = dragElementPos.y >= gridPosition.y && dragElementPos.y <= gridPosition.y + gridPosition.height;
    if (withinXBounds && withinYBounds) {
        grid1.deleteRow(evt.detail.dragData.key);
        grid2.addRow(evt.detail.dragData.data);
    }
}

registerScript("OnRowDragEndHandler", OnRowDragEndHandler);