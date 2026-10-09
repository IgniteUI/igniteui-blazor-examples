
igRegisterScript("GridThemingColumnInit", (event) => {
    if (event.detail.field === "UnitPrice") {
        event.detail.summaries = class {
            operate(data) {
                const values = (data || []).filter((value) => value !== null && value !== undefined && !isNaN(value));
                return [
                    { key: "count", label: "Count", summaryResult: (data || []).length },
                    { key: "sum", label: "Sum", summaryResult: values.reduce((a, b) => +a + +b, 0) }
                ];
            }
        };
    }
}, false);

igRegisterScript("GridThemingCurrencyFormatter", (value) => {
    return "$" + Number(value).toFixed(2);
}, false);

igRegisterScript("GridThemingSummaryFormatter", (summary) => {
    const result = summary.summaryResult;
    return typeof result === "number" ? new Intl.NumberFormat("en-US", { maximumFractionDigits: 3 }).format(result) : result;
}, false);
