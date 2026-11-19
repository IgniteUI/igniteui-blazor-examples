import { registerScript } from './_content/IgniteUI.Blazor/api.js';

registerScript("WebHierarchicalGridExportMultiColumnHeaders", (ev) => {
    ev.detail.options.ignoreMultiColumnHeaders = false;
});

