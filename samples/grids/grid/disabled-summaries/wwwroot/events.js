

class WebGridDiscontinuedSummary {
    operate(data, allData, fieldName) {
        const result = [];
        const values = allData.map((item) => item[fieldName] ?? 0).filter((value) => value !== null);

        const discontinuedItems = allData.filter((item) => item["Discontinued"] === true);
        const discontinuedValues = discontinuedItems.map((item) => item[fieldName] ?? 0).filter((value) => !isNaN(value));

        result.push({ key: "count", label: "Count", summaryResult: values.length });
        result.push({ key: "min", label: "Min", summaryResult: values.length > 0 ? Math.min(...values) : "N/A" });
        result.push({ key: "max", label: "Max", summaryResult: values.length > 0 ? Math.max(...values) : "N/A" });
        result.push({ key: "sum", label: "Sum", summaryResult: values.reduce((a, b) => a + b, 0) });
        result.push({
            key: "average",
            label: "Average",
            summaryResult: values.length > 0 ? values.reduce((a, b) => a + b, 0) / values.length : "N/A"
        });
        result.push({
            key: "median",
            label: "Median",
            summaryResult:
                values.length > 0
                    ? (() => {
                        const sortedValues = values.slice().sort((a, b) => a - b);
                        return sortedValues.length % 2 === 0 ? (sortedValues[sortedValues.length / 2 - 1] + sortedValues[sortedValues.length / 2]) / 2 : sortedValues[Math.floor(sortedValues.length / 2)];
                    })()
                    : "N/A"
        });
        result.push({ key: "range", label: "Range", summaryResult: values.length > 0 ? Math.max(...values) - Math.min(...values) : "N/A" });
        result.push({ key: "discontinued", label: "Discontinued Products", summaryResult: discontinuedItems.length });
        result.push({ key: "totalDiscontinued", label: "Total Discontinued Items", summaryResult: discontinuedValues.length > 0 ? discontinuedValues.reduce((a, b) => a + b, 0) : 0 });
        return result;
    }
}

class DiscontinuedSummary {
    operate(data, allData, fieldName) {
        const result = [];
        result.push({ key: "count", label: "Count", summaryResult: allData.length });
        result.push({ key: "true", label: "True", summaryResult: allData.filter((item) => item[fieldName] === true).length });
        result.push({ key: "false", label: "False", summaryResult: allData.filter((item) => item[fieldName] === false).length });
        return result;
    }
}

igRegisterScript("ColumnInitScript", (event) => {
    if (event.detail.field === "UnitsInStock") {
        event.detail.summaries = WebGridDiscontinuedSummary;
    } else if (event.detail.field === "Discontinued") {
        event.detail.summaries = DiscontinuedSummary;
    }
}, false);


window.getSummaries = (field) => {
    const grid = document.getElementById("grid");
    const col = grid.getColumnByName(field);
    const summaryOperand = col?.summaries;
    if (summaryOperand) {
        let result = summaryOperand.operate([], grid.data, field).map(s => ({ [s.key]: s.label }));
        return Object.assign({}, ...result);
    }
    return {};
};
