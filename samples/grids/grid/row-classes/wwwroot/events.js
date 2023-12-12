

igRegisterScript("WebGridRowClassesHandler", () => {
    return {
        activeRow: (row) => row.index % 2 === 0
    };
}, true);

