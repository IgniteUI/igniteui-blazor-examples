const totalSale = (members, data) => {
    return data.reduce((accumulator, value) => accumulator + value.ProductUnitPrice * value.NumberOfUnits, 0);
};

const totalMin = (members, data) => {
    let min = 0;
    if (data.length === 1) {
        min = data[0].ProductUnitPrice * data[0].NumberOfUnits;
    } else if (data.length > 1) {
        const mappedData = data.map(x => x.ProductUnitPrice * x.NumberOfUnits);
        min = mappedData.reduce((a, b) => Math.min(a, b));
    }
    return min;
};

const totalMax = (members, data) => {
    let max = 0;
    if (data.length === 1) {
        max = data[0].ProductUnitPrice * data[0].NumberOfUnits;
    } else if (data.length > 1) {
        const mappedData = data.map(x => x.ProductUnitPrice * x.NumberOfUnits);
        max = mappedData.reduce((a, b) => Math.max(a, b));
    }
    return max;
};


igRegisterScript("PivotDataFlatAggregateSumSale", totalSale, false);

igRegisterScript("PivotDataFlatAggregateMinSale", totalMin, false);

igRegisterScript("PivotDataFlatAggregateMaxSale", totalMax, false);

igRegisterScript("OnValueInit", (args) => {
    const value = args.detail;
    if (value.member === "AmountOfSale") {
      value.aggregate.aggregator = totalSale;
      value.aggregateList?.forEach((aggr) => {
        switch (aggr.key) {
          case "SUM":
            aggr.aggregator = totalSale;
            break;
          case "MIN":
            aggr.aggregator = totalMin;
            break;
          case "MAX":
            aggr.aggregator = totalMax;
            break;
        }
      });
    }
}, false);

