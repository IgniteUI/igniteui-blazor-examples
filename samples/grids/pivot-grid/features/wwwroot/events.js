
igRegisterScript("PivotDataFlatAggregateSumSale", (members, data) => {
    return data.reduce((accumulator, value) => accumulator + value.ProductUnitPrice * value.NumberOfUnits, 0);
}, false);

igRegisterScript("PivotDataFlatAggregateMinSale", (members, data) => {
    let min = 0;
    if (data.length === 1) {
        min = data[0].ProductUnitPrice * data[0].NumberOfUnits;
    } else if (data.length > 1) {
        const mappedData = data.map(x => x.ProductUnitPrice * x.NumberOfUnits);
        min = mappedData.reduce((a, b) => Math.min(a, b));
    }
    return min;
}, false);

igRegisterScript("PivotDataFlatAggregateMaxSale", (members, data) => {
    let max = 0;
    if (data.length === 1) {
        max = data[0].ProductUnitPrice * data[0].NumberOfUnits;
    } else if (data.length > 1) {
        const mappedData = data.map(x => x.ProductUnitPrice * x.NumberOfUnits);
        max = mappedData.reduce((a, b) => Math.max(a, b));
    }
    return max;
}, false);

