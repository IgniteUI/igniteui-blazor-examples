

igRegisterScript("WebGridEditingExcelStyle", (ev) => {
    var key = ev.detail.event.keyCode;
    var grid = ev.detail.target.grid;
    var activeElem = grid.navigation.activeNode;

    if ((key >= 48 && key <= 57) || (key >= 65 && key <= 90) || (key >= 97 && key <= 122)) {
        var columnName = grid.getColumnByVisibleIndex(activeElem.column).field;
        var cell = grid.getCellByColumn(activeElem.row, columnName);

        if (cell && !grid.crudService.cellInEditMode) {
            grid.crudService.enterEditMode(cell);
            cell.editValue = key;
        }
    }

    if (key == 13) {
        var thisRow = activeElem.row;
        var column = activeElem.column;
        var rowInfo = grid.dataView;

        var nextRow = this.getNextEditableRowIndex(thisRow, rowInfo, event.shiftKey);

        grid.navigateTo(nextRow, column, (obj) => {
            obj.target.activate();
            grid.clearCellSelection();
        });
    }
}, false);

