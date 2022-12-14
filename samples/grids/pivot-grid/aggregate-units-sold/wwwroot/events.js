
igRegisterScript("PivotSalesDataAggregateUnitsSold", (members, data) => {
    if (!data) {
        return [];
    }
    return data.reduce((accumulator, item) => accumulator + (item.UnitsSold * item.SalePrice), 0);
}, false);

