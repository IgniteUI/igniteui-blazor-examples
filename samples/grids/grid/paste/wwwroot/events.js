

igRegisterScript("WebGridPasteModeChange", (sender, evtArgs) => {
    var item = sender;
    var newVal = item.primitiveValue;
    this["pasteMode"] = newVal === "NewRecords" ? "Paste data as new records" : "Paste starting from active cell";
}, false);

igRegisterScript("WebGridPasteFromExcel", (evtArgs) => {
    const grid = document.getElementById("grid");
    grid.addEventListener("keydown", onWebGridPasteFromExcelKeyDown);
}, false);

function onWebGridPasteFromExcelKeyDown(eventArgs) {
    const ctrl = eventArgs.ctrlKey;
    const key = eventArgs.keyCode;
    // Ctrl-V || Shift-Ins || Cmd-V
    if ((ctrl || eventArgs.metaKey) && key === 86 || eventArgs.shiftKey && key === 45) {
        textArea.focus();
    }
}

var txtArea;
var textArea = getTextArea();
var pasteMode = "Paste starting from active cell";

function getTextArea() {
    if(!txtArea) {
        const div = document.createElement("div");
        const divStyle = div.style;
        divStyle.position = "fixed";
        document.body.appendChild(div);
        txtArea = document.createElement("textarea");
        const style = txtArea.style;
        style.opacity = "0";
        style.height = "0px";
        style.width = "0px";
        style.overflow = "hidden";
        div.appendChild(txtArea);

        txtArea.addEventListener("paste", (eventArgs) => { onPaste(eventArgs); });
    }
    return txtArea;
}

function onPaste(eventArgs) {
    let data;
    const clData = "clipboardData";

    // get clipboard data - from window.cliboardData for IE or from the original event's arguments.
    if (window[clData]) {
        window.event.returnValue = false;
        data = window[clData].getData("text");
    } else {
        data = eventArgs[clData].getData("text/plain");
    }

    // process the clipboard data
    const processedData = processData(data);
        if (pasteMode === "Paste data as new records") {
            addRecords(processedData);
        } else {
            updateRecords(processedData);
        }
    }

    function addRecords(processedData) {
        const grid = document.getElementById("grid");
        const columns = grid.visibleColumns;
        const pk = grid.primaryKey;
        const addedData = [];
        for (const curentDataRow of processedData) {
            const rowData = {};
            for (const col of columns) {
                const index = columns.indexOf(col);
                rowData[col.field] = curentDataRow[index];
            }
            // generate PK
            rowData[pk] = grid.data.length + 1;
            grid.addRow(rowData);
            addedData.push(rowData);
        }
        // scroll to last added row
        grid.navigateTo(grid.data.length - 1, 0, () => {
            clearStyles();
            for (const data of addedData) {
                const row = grid.getRowByKey(data[pk]);
                if (row) {
                    const rowNative = getNative(row);
                    if (rowNative) {
                        rowNative.style["font-style"] = "italic";
                        rowNative.style.color = "gray";
                    }
                }
            }
        });
    }
    function updateRecords(processedData) {
        const grid = document.getElementById("grid");
        const cell = grid.selectedCells[0];
        const pk = grid.primaryKey;
        if (!cell) { return; }
        const rowIndex = cell.row.index;
        const columns = grid.visibleColumns;
        const cellIndex = grid.visibleColumns.indexOf(cell.column);
        let index = 0;
        const updatedRecsPK = [];
        for (const curentDataRow of processedData) {
            const rowData = {};
            const dataRec = grid.data[rowIndex + index];
            const rowPkValue = dataRec ? dataRec[pk] : grid.data.length + 1;
            rowData[pk] = rowPkValue;
            for (let j = 0; j < columns.length; j++) {
                let currentCell;
                if (j >= cellIndex) {
                    currentCell = curentDataRow.shift();
                }
                const colKey = columns[j].field;
                rowData[colKey] = currentCell || (dataRec ? dataRec[colKey] : null);
            }
            if (!dataRec) {
                // no rec to update, add instead
                rowData[pk] = rowPkValue;
                grid.addRow(rowData);
                continue;
            }
            grid.updateRow(rowData, rowPkValue);
            updatedRecsPK.push(rowPkValue);
            index++;
        }

        clearStyles();
        for (const pkVal of updatedRecsPK) {
            const row = grid.getRowByKey(pkVal);
            if (row) {
                const rowNative = getNative(row);
                if (rowNative) {
                    rowNative.style["font-style"] = "italic";
                    rowNative.style.color = "gray";
                }
            }
        }
    }

    function clearStyles() {
        const rows = [...(document.getElementsByTagName("igx-grid-row"))];
        for (const rowNative of rows) {
            rowNative.style["font-style"] = "";
            rowNative.style.color = "";
        }
    }

    function getNative(row) {
        const rows = [...document.getElementsByTagName("igx-grid-row")];
        const dataInd = row.index.toString();
        return rows.find(x => x.attributes["data-rowindex"] .value === dataInd);
    }

    function processData(data) {
        const pasteData = data.split("\n");
        for (let i = 0; i < pasteData.length; i++) {
            pasteData[i] = pasteData[i].split("\t");
            // Check if last row is a dummy row
            if (pasteData[pasteData.length - 1].length === 1 && pasteData[pasteData.length - 1][0] === "") {
                pasteData.pop();
            }
            // remove empty data
            if (pasteData.length === 1 &&
                 pasteData[0].length === 1 &&
                  (pasteData[0][0] === "" || pasteData[0][0] === "\r")) {
                    pasteData.pop();
            }
        }
        return pasteData;
    }

