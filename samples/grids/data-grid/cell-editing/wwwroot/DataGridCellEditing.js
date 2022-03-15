function onUpdatingTemplateColumn(grid, args) {
    let content = args.content;
     
    var row = args.cellInfo.dataRow;

    if (content.childElementCount === 0) {
        var deleteButton = document.createElement("button");
        deleteButton.id = row;

        var deleteSpan = document.createElement("span");
        deleteSpan.textContent = "DELETE";

        deleteButton.appendChild(deleteSpan);

        deleteButton.onclick = function () {
            var button = deleteButton;
            DotNet.invokeMethodAsync('Infragistics.Samples', 'ButtonClickActionAtBlazorLevel', button.id);
        }

        content.appendChild(deleteButton);
    }
}

// this code allows calling above functions from a .razor file
igRegisterScript("onUpdatingTemplateColumn", onUpdatingTemplateColumn, false);