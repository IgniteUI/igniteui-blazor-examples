

igRegisterScript("WebGridRendered", (event) => {
        const grid = document.getElementsByTagName("igc-grid")[0];
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
}, false);

igRegisterScript("WebGridRowEditEnter", (event) => {
    const container = document.getElementById("container");
    const message = document.createElement("p");
    message.textContent = `=> 'rowEditEnter' with 'RowID':` + event.detail.rowID;
    container.appendChild(message);
}, false);

igRegisterScript("WebGridRowEdit", (event) => {
    const container = document.getElementById("container");
    const message = document.createElement("p");
    message.textContent = `=> 'rowEdit'`;
    container.appendChild(message);
}, false);

igRegisterScript("WebGridRowEditDone", (event) => {
    const container = document.getElementById("container");
    const message = document.createElement("p");
    message.textContent = `=> 'rowEditDone'`;
    container.appendChild(message);
}, false);

igRegisterScript("WebGridRowEditExit", (event) => {
    const container = document.getElementById("container");
    const message = document.createElement("p");
    message.textContent = `=> 'rowEditExit'  << End of cycle >>`;
    container.appendChild(message);
}, false);

igRegisterScript("WebGridCellEditEnter", (event) => {
    const container = document.getElementById("container");
    const message = document.createElement("p");
    message.textContent = `=> 'cellEditEnter' with 'value':` + event.detail.oldValue, event.detail.cancel;
    container.appendChild(message);
}, false);

igRegisterScript("WebGridCellEdit", (event) => {
    const container = document.getElementById("container");
    const message = document.createElement("p");
    message.textContent = `=> 'cellEdit' with 'newValue':` + event.detail.newValue, event.detail.cancel;
    container.appendChild(message);
}, false);

igRegisterScript("WebGridCellEditDone", (event) => {
    const container = document.getElementById("container");
    const message = document.createElement("p");
    message.textContent = `=> 'cellEditDone'`;
    container.appendChild(message);
}, false);

igRegisterScript("WebGridCellEditExit", (event) => {
    const container = document.getElementById("container");
    const message = document.createElement("p");
    message.textContent = `=> 'cellEditExit'`;
    container.appendChild(message);
}, false);

