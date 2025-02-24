class UnitsSummary {
    operate(data, allData, fieldName) {
        const result = [];

        const values = allData.map((rec) => rec[fieldName]).filter((value) => value !== undefined && value !== null);
        const totalSum = values.reduce((sum, value) => sum + value, 0);
        const sortedValues = values.slice().sort((a, b) => a - b);
        const deliveredValues = allData
            .filter((rec) => rec["Delivered"])
            .map((rec) => rec[fieldName])
            .filter((value) => value !== undefined && value !== null);

        result.push({
            key: "count",
            label: "Count",
            summaryResult: allData.length
        });

        result.push({
            key: "min",
            label: "Min",
            summaryResult: values.length > 0 ? Math.min(...values) : "N/A"
        });

        result.push({
            key: "max",
            label: "Max",
            summaryResult: values.length > 0 ? Math.max(...values) : "N/A"
        });

        result.push({
            key: "sum",
            label: "Sum",
            summaryResult: totalSum
        });

        result.push({
            key: "average",
            label: "Average",
            summaryResult: values.length > 0 ? totalSum / values.length : "N/A"
        });

        result.push({
            key: "totalDelivered",
            label: "Total Units Delivered",
            summaryResult: deliveredValues.length > 0 ? deliveredValues.reduce((sum, value) => sum + value, 0) : "N/A"
        });

        result.push({
            key: "medianUnits",
            label: "Median Units",
            summaryResult:
                values.length > 0
                    ? (() => {
                        const mid = Math.floor(sortedValues.length / 2);
                        return sortedValues.length % 2 !== 0 ? sortedValues[mid] : (sortedValues[mid - 1] + sortedValues[mid]) / 2;
                    })()
                    : "N/A"
        });

        result.push({
            key: "uniqueCount",
            label: "Count of Unique Unit Values",
            summaryResult: values.length > 0 ? new Set(values).size : "N/A"
        });

        result.push({
            key: "maxDifference",
            label: "Max Difference Between Units",
            summaryResult:
                values.length > 1
                    ? values.reduce((maxDiff, value, idx, arr) => {
                        if (idx === 0) return maxDiff;
                        const diff = Math.abs(value - arr[idx - 1]);
                        return Math.max(maxDiff, diff);
                    }, 0)
                    : "N/A"
        });

        return result;
    }
}

igRegisterScript("ColumnInitScript", (event) => {
    if (event.detail.field === "Units") {
        event.detail.summaries = UnitsSummary;
    }
}, false);

window.getSummaries = (field) => {
    const grid = document.getElementById("treeGrid");
    const col = grid.getColumnByName(field);
    const summaryOperand = col?.summaries;
    if (summaryOperand) {
        let result = summaryOperand.operate([], grid.data, field).map(s => ({ [s.key]: s.label }));
        return Object.assign({}, ...result);
    }
    return {};
};
