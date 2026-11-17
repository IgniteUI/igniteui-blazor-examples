import { registerScript, html } from './_content/IgniteUI.Blazor/api.js';

const itemTemplate = ({ item }) => {
    return html`<span><b>${item.Name}</b> [${item.Id}]</span>`;
}

const groupHeaderTemplate = ({ item }) => {
    return html`<span>Country of ${item.Country}</span>`;
}

registerScript("ComboItemTemplate", itemTemplate);
registerScript('ComboGroupHeaderTemplate', groupHeaderTemplate)
