

igRegisterScript("WebTreeGridAllergensCellClassesHandler", () => {
    let allergenItems = ['Frozen Shrimps', 'Wild Salmon Fillets', 'Fresh Cheese', 'Skimmed Milk 1L', 'Butter'];

    return {
        allergensFont: (rowData, columnKey) => allergenItems.indexOf(rowData[columnKey]) >= 0,
    };
}, true);

igRegisterScript("WebTreeGridUnitPriceCellClassesHandler", () => {
    return {
        downPrice: (rowData, columnKey) => rowData[columnKey] <= 5,
        upPrice: (rowData, columnKey) => rowData[columnKey] > 5,
    };
}, true);

