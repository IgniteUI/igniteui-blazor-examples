igRegisterScript("OnGridRendered", () => {
    const grid = document.getElementById("hGrid");

    grid.isLoading = true;

    getData({ parentID: null, rootLevel: true, key: "Customers" }).then(
        (data) => {
            grid.isLoading = false;
            grid.data = data;
            grid.markForCheck();
        });
}, false)

igRegisterScript("OnGridCreated", (args) => {
    const context = args.detail;
    const _parentKey = context.owner.childDataKey === "Orders" ? "CustomerID" : "OrderID";
    const dataState = {
        key: context.owner.childDataKey,
        parentID: context.parentID,
        parentKey: _parentKey,
        rootLevel: false,
    };

    context.grid.isLoading = true;

    getData(dataState).then((data) => {
        context.grid.isLoading = false;
        context.grid.data = data;
        context.grid.markForCheck();
    });
}, false)

function getData(dataState) {
    const key = dataState.key;
    let resultData = DATA[key];

    if (!dataState.rootLevel) {
        resultData = resultData.filter((record) => record[dataState.parentKey] === dataState.parentID);
    }

    return new Promise((resolve) => {
        setTimeout(() => {
            resolve(resultData);
        }, 1000);
    });
}