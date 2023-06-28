//begin imports
import { IgcNumberSummaryOperand } from 'igniteui-webcomponents-grids/grids';
//end imports

//begin eventHandler
class WebTreeGridCustomNumberSummary {
    operate(data) {
		const result = [];
        result.push({
            key: 'Min',
            label: 'Min',
            summaryResult: IgcNumberSummaryOperand.min(data)
        });

        result.push({
            key: 'max',
            label: 'Max',
            summaryResult: IgcNumberSummaryOperand.max(data)
        });

        return result;
    }
}

igRegisterScript("WebTreeGridCustomNumberSummary", (event) => {
    if (event.detail.field === "Age") {
        event.detail.summaries = WebTreeGridCustomNumberSummary;
    }
}, false);
//end eventHandler

