import { registerScript } from './_content/IgniteUI.Blazor/api.js';

registerScript("WebHierarchicalGridToolbarExporting", (evt) => {
    const args = evt.detail;
    const options = args.options;
    options.fileName = `Report_${new Date().toDateString()}`;
    args.exporter.columnExporting.subscribe((columnArgs) => {
        columnArgs.cancel = columnArgs.header === 'Photo';
    });
});

