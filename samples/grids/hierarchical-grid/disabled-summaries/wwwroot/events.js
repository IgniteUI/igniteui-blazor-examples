class GrammySummary {
    operate(data, allData, fieldName) {
        const result = [];

        result.push({
            key: "count",
            label: "Count",
            summaryResult: allData.filter((rec) => rec["Artist"] !== undefined && rec["Artist"] !== null && rec["Artist"] !== "").length
        });

        result.push({
            key: "nominatedSingers",
            label: "Nominated Singers",
            summaryResult: allData.filter((rec) => rec["GrammyNominations"] > 0).length
        });

        result.push({
            key: "singersWithAwards",
            label: "Singers with Awards",
            summaryResult: allData.filter((rec) => rec["GrammyAwards"] > 0).length
        });

        let grammyNominations = allData.map((item) => item["GrammyNominations"] ?? 0).filter((value) => !isNaN(value));

        result.push({
            key: "nominations",
            label: "Total Nominations",
            summaryResult: grammyNominations.reduce((a, b) => a + b, 0)
        });

        let grammyAwayrds = allData.map((item) => item["GrammyAwards"] ?? 0).filter((value) => !isNaN(value));

        result.push({
            key: "awards",
            label: "Total Awards",
            summaryResult: grammyAwayrds.reduce((a, b) => a + b, 0)
        });

        return result;
    }
}

igRegisterScript("ColumnInitScript", (event) => {
    if (event.detail.field === "Photo") {
        event.detail.summaries = GrammySummary;
    }
}, false);

window.getSummaries = (field) => {
    const grid = document.getElementById("hierarchicalGrid");
    const col = grid.getColumnByName(field);
    const summaryOperand = col?.summaries;
    if (summaryOperand) {
        let result = summaryOperand.operate([], grid.data, field).map(s => ({ [s.key]: s.label }));
        return Object.assign({}, ...result);
    }
    return {};
};