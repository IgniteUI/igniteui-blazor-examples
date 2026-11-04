// Forward the raw tree because Blazor's callback omits filtering operands.
window.queryBuilderOverview = {
    initialize(service) {
        this.service = service;
    },
    dispose() {
        this.service = null;
    }
};

igRegisterScript("WebQueryBuilderOverviewExpressionTreeChange", async (evtArgs) => {
    if (evtArgs?.detail && window.queryBuilderOverview.service) {
        await window.queryBuilderOverview.service.invokeMethodAsync(
            "ExecuteQuery", JSON.stringify(evtArgs.detail));
    }
}, false);
