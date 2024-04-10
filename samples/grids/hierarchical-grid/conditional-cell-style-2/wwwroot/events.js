
igRegisterScript("WebHierarchicalGridCellStylesHandler", () => {
    return {
        background: (rowData, columnKey, cellValue, rowIndex) => rowIndex % 2 === 0 ? "#EFF4FD" : null,
        color: (rowData, columnKey, cellValue, rowIndex) => {
            if (columnKey === "Debut") {
                return cellValue > 2000 ? "#28a745" : "#dc3545";
            }
            return undefined;
        }
    };
}, true);

