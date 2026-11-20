import { registerScript } from './_content/IgniteUI.Blazor/api.js';

registerScript("PivotGridThemingProductMember", (data) => {
    return data.ProductName;
});

registerScript("PivotGridThemingCityMember", (data) => {
    return data.SellerCity;
});

registerScript("PivotGridThemingSellerMember", (data) => {
    return data.SellerName;
});
