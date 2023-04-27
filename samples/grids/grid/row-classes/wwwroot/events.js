igRegisterScript("RowClassesHandler", () => {
    return {
        activeRow: (row) => row.index === 0
    };
}, true);