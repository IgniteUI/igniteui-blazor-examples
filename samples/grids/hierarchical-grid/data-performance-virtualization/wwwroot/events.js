// Child-grid references are not available in Blazor's GridCreated callback.
window.hierarchicalGridMock = {
    initialize(service) {
        this.service = service;
    },
    dispose() {
        this.service = null;
    }
};

igRegisterScript("OnGridCreated", (args) => {
    const context = args.detail;
    const grid = context.grid;
    grid.isLoading = true;
    window.hierarchicalGridMock.service.invokeMethodAsync(
        "GetChildData", context.owner.childDataKey, String(context.parentID))
        .then((data) => {
            grid.data = data;
        })
        .catch((error) => {
            console.error(error);
            grid.data = [];
        })
        .finally(() => {
            grid.isLoading = false;
            grid.markForCheck();
        });
}, false);
