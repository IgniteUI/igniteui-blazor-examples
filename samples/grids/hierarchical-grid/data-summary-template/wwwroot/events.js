import { registerScript } from './_content/IgniteUI.Blazor/api.js';

registerScript("WebHierarchicalGridSetGridSize", (sender, evtArgs) => {
    var newVal = evtArgs.newValue.toLowerCase();
    var grid = document.getElementById("hierarchicalGrid");
    grid.style.setProperty('--ig-size', `var(--ig-size-${newVal})`);
});



class WebHierarchicalGridSingerSummary {
    operate(data, allData, fieldName) {
        const sum = (values) => values.reduce((a, b) => +a + +b, 0);
        const result = [];
        result.push({
            key: 'nominatedSingers',
            label: 'Nominated Singers',
            summaryResult: allData.filter((rec) => rec['GrammyNominations'] > 0).length
        });
        result.push({
            key: 'singersWithAwards',
            label: 'Singers with Awards',
            summaryResult: allData.filter((rec) => rec['GrammyAwards'] > 0).length
        });
        result.push({
            key: 'nominations',
            label: 'Total Nominations',
            summaryResult: sum(allData.map(r => r['GrammyNominations']))
        });
        result.push({
            key: 'awards',
            label: 'Total Awards',
            summaryResult: sum(allData.map(r => r['GrammyAwards']))
        });
        return result;
    }
}
registerScript("WebHierarchicalGridSingerSummary", WebHierarchicalGridSingerSummary);
