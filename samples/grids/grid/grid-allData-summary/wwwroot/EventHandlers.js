class DiscontinuedSummary {
    operate(data, allData, fieldName) {
        const discontinuedData = allData.filter((rec) => rec['Discontinued']).map(r => r[fieldName]);
        const result = [];
        result.push({
            key: 'products',
            label: 'Producs',
            summaryResult: data.length
        });
        result.push({
            key: 'total',
            label: 'Total Items',
            summaryResult: data.length ? data.reduce((a, b) => +a + +b) : 0
        });
        result.push({
            key: 'discontinued',
            label: 'Discontinued Producs',
            summaryResult: allData.map(r => r['Discontinued']).filter((rec) => rec).length
        });
        result.push({
            key: 'totalDiscontinued',
            label: 'Total Discontinued Items',
            summaryResult: discontinuedData.length ? discontinuedData.reduce((a, b) => +a + +b) : 0
        });
        return result;
    }
}
function OnColumnInit(evt) {
    if (evt.detail.field === "UnitsInStock") {
        event.detail.summaries = DiscontinuedSummary;
    }
}
 
igRegisterScript("OnColumnInit", OnColumnInit, false);