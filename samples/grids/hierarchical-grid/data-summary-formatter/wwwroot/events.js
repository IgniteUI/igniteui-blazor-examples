import { registerScript } from './_content/IgniteUI.Blazor/api.js';

registerScript("WebHierarchicalGridRenderedExpand", (event) => {
    const hierarchicalGrid = event.target;
    hierarchicalGrid.expandAll();
    setTimeout(() => {
        hierarchicalGrid.getColumnByName("Debut").formatter = (value) => Math.floor(value / 10) * 10 + 's';
    }, 50);
});

registerScript("WebHierarchicalGridSummaryFormatter", (summary) => {
    const result = summary.summaryResult;
    if (summaryOperand instanceof IgcDateSummaryOperand && summary.key !== "count" && result !== null && result !== undefined) {
        const format = new Intl.DateTimeFormat("en", { year: "numeric" });
        return format.format(new Date(result));
    }
    return result;
}, true);

