import { registerScript } from './_content/IgniteUI.Blazor/api.js';

registerScript("WebGridExportEventMultiColumnHeaders", (ev) => {
    ev.detail.options.ignoreMultiColumnHeaders = false;
});

