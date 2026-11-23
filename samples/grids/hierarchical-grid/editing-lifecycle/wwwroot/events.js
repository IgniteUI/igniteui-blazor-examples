import { registerScript } from './_content/IgniteUI.Blazor/api.js';

registerScript("WebHierarchicalGridRendered", (event) => {
        const hierarchicalGrid = document.getElementById("hierarchicalGrid");
        hierarchicalGrid.parentElement.style.display = "flex";
        const container = document.createElement("div");
        container.id = "container";
        container.style.height = "80vh";
        container.style.width = "100%";
        container.style.overflow = "auto";
        hierarchicalGrid.parentElement.appendChild(container);
        const title = document.createElement("span");
        title.textContent = "Events execution sequence:";
        container.appendChild(title);
});

registerScript("WebHierarchicalGridRowEditEnter", (event) => {
    const container = document.getElementById("container");
    const message = document.createElement("p");
    message.textContent = `Hierarchical Grid => 'rowEditEnter' with 'RowID':` + event.detail.rowID;
    container.appendChild(message);
});

registerScript("WebHierarchicalGridRowEdit", (event) => {
    const container = document.getElementById("container");
    const message = document.createElement("p");
    message.textContent = `Hierarchical Grid => 'rowEdit'`;
    container.appendChild(message);
});

registerScript("WebHierarchicalGridRowEditDone", (event) => {
    const container = document.getElementById("container");
    const message = document.createElement("p");
    message.textContent = `Hierarchical Grid => 'rowEditDone'`;
    container.appendChild(message);
});

registerScript("WebHierarchicalGridRowEditExit", (event) => {
    const container = document.getElementById("container");
    const message = document.createElement("p");
    message.textContent = `Hierarchical Grid => 'rowEditExit'  << End of cycle >>`;
    container.appendChild(message);
});

registerScript("WebHierarchicalGridCellEditEnter", (event) => {
    const container = document.getElementById("container");
    const message = document.createElement("p");
    message.textContent = `Hierarchical Grid => 'cellEditEnter' with 'value':` + event.detail.oldValue, event.detail.cancel;
    container.appendChild(message);
});

registerScript("WebHierarchicalGridCellEdit", (event) => {
    const container = document.getElementById("container");
    const message = document.createElement("p");
    message.textContent = `Hierarchical Grid => 'cellEdit' with 'newValue':` + event.detail.newValue, event.detail.cancel;
    container.appendChild(message);
});

registerScript("WebHierarchicalGridCellEditExit", (event) => {
    const container = document.getElementById("container");
    const message = document.createElement("p");
    message.textContent = `Hierarchical Grid => 'cellEditExit'`;
    container.appendChild(message);
});

registerScript("WebRowIslandGridRowEditEnter", (event) => {
    const container = document.getElementById("container");
    const message = document.createElement("p");
    message.textContent = `Row Island => 'rowEditEnter' with 'RowID':` + event.detail.rowID;
    container.appendChild(message);
});

registerScript("WebRowIslandGridRowEdit", (event) => {
    const container = document.getElementById("container");
    const message = document.createElement("p");
    message.textContent = `Row Island => 'rowEdit'`;
    container.appendChild(message);
});

registerScript("WebRowIslandGridRowEditDone", (event) => {
    const container = document.getElementById("container");
    const message = document.createElement("p");
    message.textContent = `Row Island => 'rowEditDone'`;
    container.appendChild(message);
});

registerScript("WebRowIslandGridRowEditExit", (event) => {
    const container = document.getElementById("container");
    const message = document.createElement("p");
    message.textContent = `Row Island => 'rowEditExit'  << End of cycle >>`;
    container.appendChild(message);
});

registerScript("WebRowIslandGridCellEditEnter", (event) => {
    const container = document.getElementById("container");
    const message = document.createElement("p");
    message.textContent = `Row Island => 'cellEditEnter' with 'value':` + event.detail.oldValue, event.detail.cancel;
    container.appendChild(message);
});

registerScript("WebRowIslandGridCellEdit", (event) => {
    const container = document.getElementById("container");
    const message = document.createElement("p");
    message.textContent = `Row Island => 'cellEdit' with 'newValue':` + event.detail.newValue, event.detail.cancel;
    container.appendChild(message);
});

registerScript("WebRowIslandGridCellEditExit", (event) => {
    const container = document.getElementById("container");
    const message = document.createElement("p");
    message.textContent = `Row Island => 'cellEditExit'`;
    container.appendChild(message);
});

