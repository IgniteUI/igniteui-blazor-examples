import { registerScript, html } from './_content/IgniteUI.Blazor/api.js';

registerScript("WebTreeGridAvatarCellTemplate", (ctx) => {
    return html`<div style="display: flex; align-items: center;">
    <igc-avatar shape="circle" src="${ctx.cell.row.data.Avatar}">
    </igc-avatar>
    <span style="margin-left: 30px;">${ctx.cell.value}</span>
</div>`;
});

var EnableFiltering = () => {
    var toolbarFiltering = document.getElementsByTagName("igc-grid-toolbar-advanced-filtering")[0];
    toolbarFiltering.hidden = !toolbarFiltering.hidden;
}

var EnableHiding = () => {
    var toolbarHiding = document.getElementsByTagName("igc-grid-toolbar-hiding")[0];
    toolbarHiding.hidden = !toolbarHiding.hidden;
}

var EnablePinning = () => {
    var toolbarPinning = document.getElementsByTagName("igc-grid-toolbar-pinning")[0];
    toolbarPinning.hidden = !toolbarPinning.hidden;
}

var EnableExport = () => {
    var toolbarExporter = document.getElementsByTagName("igc-grid-toolbar-exporter")[0];
    toolbarExporter.hidden = !toolbarExporter.hidden;
}

// called by name from the page, so keep them reachable from the module
window.EnableFiltering = EnableFiltering;
window.EnableHiding = EnableHiding;
window.EnablePinning = EnablePinning;
window.EnableExport = EnableExport;
