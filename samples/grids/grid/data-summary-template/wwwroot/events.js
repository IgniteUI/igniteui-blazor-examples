import { registerScript } from './_content/IgniteUI.Blazor/api.js';

registerScript("WebGridSetGridSize", (sender, evtArgs) => {
    var newVal = evtArgs.newValue.toLowerCase();
    var grid = document.getElementById("grid");
    grid.style.setProperty('--ig-size', `var(--ig-size-${newVal})`);
});

class WebGridDiscontinuedSummary {
    operate(data, allData, fieldName) {
        const discontinuedData = allData.filter((rec) => rec['Discontinued']).map(r => r[fieldName]);
        const result = [];
        result.push({
            key: 'products',
            label: 'Products',
            summaryResult: data.length
        });
        result.push({
            key: 'total',
            label: 'Total Items',
            summaryResult: data.length ? data.reduce((a, b) => + a + b) : 0
        });
        result.push({
            key: 'discontinued',
            label: 'Discontinued Products',
            summaryResult: allData.map(r => r['Discontinued']).filter((rec) => rec).length
        });
        result.push({
            key: 'totalDiscontinued',
            label: 'Total Discontinued Items',
            summaryResult: discontinuedData.length ? discontinuedData.reduce((a, b) => + a + b) : 0
        });
        return result;
    }
}
registerScript("WebGridDiscontinuedSummary", WebGridDiscontinuedSummary);
