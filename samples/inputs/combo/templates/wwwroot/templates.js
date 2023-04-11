const html = window.igTemplating.html;

const itemTemplate = ({ item }) => {
    return html`<span><b>${item.Name}</b> [${item.Id}]</span>`;
}

const groupHeaderTemplate = ({ item }) => {
    return html`<span>Country of ${item.Country}</span>`;
}

igRegisterScript("ComboItemTemplate", itemTemplate, false);
igRegisterScript('ComboGroupHeaderTemplate', groupHeaderTemplate, false)
