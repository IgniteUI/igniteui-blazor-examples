import { registerScript } from './_content/IgniteUI.Blazor/api.js';

registerScript("WebTreeGridRendered", (event) => {
        const grid = document.getElementsByTagName("igc-tree-grid")[0];
        grid.parentElement.style.display = "flex";
        const container = document.createElement("div");
        container.id = "container";
        container.style.height = "100vh";
        container.style.width = "100%";
        container.style.overflow = "auto";
        grid.parentElement.appendChild(container);
        const title = document.createElement("span");
        title.textContent = "Events execution sequence";
        container.appendChild(title);
});

registerScript("WebGridRowEditEnter", (event) => {
    const container = document.getElementById("container");
    const message = document.createElement("p");
    message.textContent = `=> 'rowEditEnter' with 'RowID':` + event.detail.rowID;
    container.appendChild(message);
});

registerScript("WebGridRowEdit", (event) => {
    const container = document.getElementById("container");
    const message = document.createElement("p");
    message.textContent = `=> 'rowEdit'`;
    container.appendChild(message);
});

registerScript("WebGridRowEditDone", (event) => {
    const container = document.getElementById("container");
    const message = document.createElement("p");
    message.textContent = `=> 'rowEditDone'`;
    container.appendChild(message);
});

registerScript("WebGridRowEditExit", (event) => {
    const container = document.getElementById("container");
    const message = document.createElement("p");
    message.textContent = `=> 'rowEditExit'  << End of cycle >>`;
    container.appendChild(message);
});

registerScript("WebGridCellEditEnter", (event) => {
    const container = document.getElementById("container");
    const message = document.createElement("p");
    message.textContent = `=> 'cellEditEnter' with 'value':` + event.detail.oldValue, event.detail.cancel;
    container.appendChild(message);
});

registerScript("WebGridCellEdit", (event) => {
    const container = document.getElementById("container");
    const message = document.createElement("p");
    message.textContent = `=> 'cellEdit' with 'newValue':` + event.detail.newValue, event.detail.cancel;
    container.appendChild(message);
});

registerScript("WebGridCellEditDone", (event) => {
    const container = document.getElementById("container");
    const message = document.createElement("p");
    message.textContent = `=> 'cellEditDone'`;
    container.appendChild(message);
});

registerScript("WebGridCellEditExit", (event) => {
    const container = document.getElementById("container");
    const message = document.createElement("p");
    message.textContent = `=> 'cellEditExit'`;
    container.appendChild(message);
});

