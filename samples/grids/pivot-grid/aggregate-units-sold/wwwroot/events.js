import { registerScript } from './_content/IgniteUI.Blazor/api.js';

registerScript("PivotSalesDataAggregateUnitsSold", (members, data) => {
    if (!data) {
        return [];
    }
    return data.reduce((accumulator, item) => accumulator + (item.UnitsSold * item.SalePrice), 0);
});

