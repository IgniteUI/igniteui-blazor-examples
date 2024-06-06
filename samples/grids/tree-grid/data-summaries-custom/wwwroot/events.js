
class PtoSummary {
    count(data) {
        return data.length;
    };
    operate(data, allData, fieldName) {
        const result = [];
        result.push({
            key: 'totalOnPTO',
            label: 'Employees On PTO',
            summaryResult: this.count(allData.filter((rec) => rec['OnPTO']).map(r => r[fieldName]))
        });
        result.push({
            key: 'devs',
            label: 'Developers',
            summaryResult: this.count(allData.filter((rec) => rec[fieldName].includes('Developer') && rec['OnPTO']).map(r => r[fieldName]))
        });
        result.push({
            key: 'tl',
            label: 'Team Leads',
            summaryResult: this.count(allData.filter((rec) => rec[fieldName].includes('Team Lead') && rec['OnPTO']).map(r => r[fieldName]))
        });
        result.push({
            key: 'managers',
            label: 'Managers/Directors',
            summaryResult: this.count(allData.filter((rec) => (rec[fieldName].includes('Manager') || rec[fieldName].includes('Director')) && rec['OnPTO']).map(r => r[fieldName]))
        });
        result.push({
            key: 'ceo',
            label: 'CEO/President',
            summaryResult: this.count(allData.filter((rec) => (rec[fieldName].includes('CEO') || rec[fieldName].includes('President')) && rec['OnPTO']).map(r => r[fieldName]))
        });
        return result;
    }
}

igRegisterScript("WebTreeGridCustomSummary", (event) => {
    if (event.detail.field === "Title") {
        event.detail.summaries = PtoSummary;
    }
}, false);


