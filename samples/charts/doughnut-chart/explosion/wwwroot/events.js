import { registerScript } from './_content/IgniteUI.Blazor/api.js';

registerScript("OnSliceClickScript", (ctx, evtArgs) => {

    evtArgs.isExploded = !evtArgs.isExploded;

});