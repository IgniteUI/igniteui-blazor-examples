
igRegisterScript("WebHierarchicalGridSummaryFormatter", (summary) => {
    const result = summary.summaryResult;
    if (summaryOperand instanceof IgcDateSummaryOperand && summary.key !== "count" && result !== null && result !== undefined) {
        const format = new Intl.DateTimeFormat("en", { year: "numeric" });
        return format.format(new Date(result));
    }
    return result;
}, true);

igRegisterScript("WebHierarchicalGridRenderedExpand", (event) => {
    this.hierarchicalGrid.expandAll();
    setTimeout(() => {
        this.hierarchicalGrid.getColumnByName("Debut").formatter = (value) => Math.floor(value / 10) * 10 + 's';
    }, 50);
}, false);

