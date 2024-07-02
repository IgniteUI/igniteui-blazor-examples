

igRegisterScript("WebTreeGridCellStylesHandler", () => {
    return {
        background: (rowData, columnKey, cellValue, rowIndex) => rowIndex % 2 === 0 ? "#EFF4FD" : null,
        color: (rowData, columnKey, cellValue, rowIndex) => {
            if (columnKey === "UnitPrice") {
                if (cellValue > 10) return "#dc3545";
                if (cellValue < 5) return "#28a745";
                if (cellValue >= 5 && cellValue <= 10) return "#17a2b8";
            }
        }
    };
}, true);

