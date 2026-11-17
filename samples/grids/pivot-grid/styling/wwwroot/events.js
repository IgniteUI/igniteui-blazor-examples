import { registerScript } from './_content/IgniteUI.Blazor/api.js';

registerScript("PivotSalesData", (members, data) => {
    if (!data) {
        return [];
    }
    return data.map(x => x.Sales).reduce((a, b) => Math.max(a, b));
});

