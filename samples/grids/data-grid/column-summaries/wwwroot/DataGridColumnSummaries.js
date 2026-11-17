import { registerScript } from './_content/IgniteUI.Blazor/api.js';

function onProvideCalculator(grid, args) {

    args.setCalculator(null);

}

registerScript("onProvideCalculator", onProvideCalculator);