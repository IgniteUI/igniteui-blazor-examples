// NOTE this JavaScript file implements functions for styling/templating columnd of the Financial Chart control
// at end of this file, the igRegisterScript registers functions that are used .razor file

function onApplyCustomIndicators(chart, args) {

    if (args.Index === 0) {

        let info = args.IndicatorInfo;

        if (info === null)
        {
            console.log("indicatorInfo is undefined");
        }

        var ds = info.dataSource;
        if (ds === null)
        {
            console.log("dataSource is undefined");
        }
        if (ds.openColumn === null)
        {
            console.log("dataSource has no openColumn");
        }
        if (ds.indicatorColumn.length === 0)
        {
            console.log("dataSource has no indicatorColumn");
        }

        let prices = ds.openColumn;
        let priceStart = ds.openColumn[0];
        let min = int.MaxValue;
        let max = int.MinValue;

        // calculating price changes using start price as reference
        for (i = 0; i < ds.indicatorColumn.length; i++)
        {
            let priceChange = prices[i] - priceStart;
            let pricePercentage = (priceChange / priceStart) * 100;
            min = Math.Min(min, pricePercentage);
            max = Math.Max(max, pricePercentage);
            // setting values for indicator
            ds.indicatorColumn[i] = pricePercentage;
        }

        // setting min and max on data source
        ds.minimumValue = min;
        ds.maximumValue = max;

        console.log("custom indicator created between " + min + "  " + max);
    }
}

// this code allows calling above functions from a .razor file
igRegisterScript("onApplyCustomIndicators", onApplyCustomIndicators, false);
