

igRegisterScript("WebHierarchicalGridRendered", (event) => {
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
}, false);

igRegisterScript("WebHierarchicalGridRowEditEnter", (event) => {
    const container = document.getElementById("container");
    const message = document.createElement("p");
    message.textContent = `Hierarchical Grid => 'rowEditEnter' with 'RowID':` + event.detail.rowID;
    container.appendChild(message);
}, false);

igRegisterScript("WebHierarchicalGridRowEdit", (event) => {
    const container = document.getElementById("container");
    const message = document.createElement("p");
    message.textContent = `Hierarchical Grid => 'rowEdit'`;
    container.appendChild(message);
}, false);

igRegisterScript("WebHierarchicalGridRowEditDone", (event) => {
    const container = document.getElementById("container");
    const message = document.createElement("p");
    message.textContent = `Hierarchical Grid => 'rowEditDone'`;
    container.appendChild(message);
}, false);

igRegisterScript("WebHierarchicalGridRowEditExit", (event) => {
    const container = document.getElementById("container");
    const message = document.createElement("p");
    message.textContent = `Hierarchical Grid => 'rowEditExit'  << End of cycle >>`;
    container.appendChild(message);
}, false);

igRegisterScript("WebHierarchicalGridCellEditEnter", (event) => {
    const container = document.getElementById("container");
    const message = document.createElement("p");
    message.textContent = `Hierarchical Grid => 'cellEditEnter' with 'value':` + event.detail.oldValue, event.detail.cancel;
    container.appendChild(message);
}, false);

igRegisterScript("WebHierarchicalGridCellEdit", (event) => {
    const container = document.getElementById("container");
    const message = document.createElement("p");
    message.textContent = `Hierarchical Grid => 'cellEdit' with 'newValue':` + event.detail.newValue, event.detail.cancel;
    container.appendChild(message);
}, false);

igRegisterScript("WebHierarchicalGridCellEditExit", (event) => {
    const container = document.getElementById("container");
    const message = document.createElement("p");
    message.textContent = `Hierarchical Grid => 'cellEditExit'`;
    container.appendChild(message);
}, false);

igRegisterScript("WebRowIslandGridRowEditEnter", (event) => {
    const container = document.getElementById("container");
    const message = document.createElement("p");
    message.textContent = `Row Island => 'rowEditEnter' with 'RowID':` + event.detail.rowID;
    container.appendChild(message);
}, false);

igRegisterScript("WebRowIslandGridRowEdit", (event) => {
    const container = document.getElementById("container");
    const message = document.createElement("p");
    message.textContent = `Row Island => 'rowEdit'`;
    container.appendChild(message);
}, false);

igRegisterScript("WebRowIslandGridRowEditDone", (event) => {
    const container = document.getElementById("container");
    const message = document.createElement("p");
    message.textContent = `Row Island => 'rowEditDone'`;
    container.appendChild(message);
}, false);

igRegisterScript("WebRowIslandGridRowEditExit", (event) => {
    const container = document.getElementById("container");
    const message = document.createElement("p");
    message.textContent = `Row Island => 'rowEditExit'  << End of cycle >>`;
    container.appendChild(message);
}, false);

igRegisterScript("WebRowIslandGridCellEditEnter", (event) => {
    const container = document.getElementById("container");
    const message = document.createElement("p");
    message.textContent = `Row Island => 'cellEditEnter' with 'value':` + event.detail.oldValue, event.detail.cancel;
    container.appendChild(message);
}, false);

igRegisterScript("WebRowIslandGridCellEdit", (event) => {
    const container = document.getElementById("container");
    const message = document.createElement("p");
    message.textContent = `Row Island => 'cellEdit' with 'newValue':` + event.detail.newValue, event.detail.cancel;
    container.appendChild(message);
}, false);

igRegisterScript("WebRowIslandGridCellEditExit", (event) => {
    const container = document.getElementById("container");
    const message = document.createElement("p");
    message.textContent = `Row Island => 'cellEditExit'`;
    container.appendChild(message);
}, false);

