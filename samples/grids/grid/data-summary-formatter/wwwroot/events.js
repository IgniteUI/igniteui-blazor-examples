import { registerScript } from './_content/IgniteUI.Blazor/api.js';

registerScript("WebGridSummaryFormatter", (summary) => {
    const result = summary.summaryResult;
    if (summaryOperand instanceof IgcDateSummaryOperand && summary.key !== "count" && result !== null && result !== undefined) {
        const format = new Intl.DateTimeFormat("en", { year: "numeric" });
        return format.format(new Date(result));
    }
    return result;
}, true);

