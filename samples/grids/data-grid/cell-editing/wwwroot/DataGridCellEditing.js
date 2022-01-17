function onUpdatingTemplateColumn(grid, args) {
    let content = args.content;
     
    var row = args.cellInfo.dataRow;

    if (content.childElementCount === 0) {
        var gaugeButton = document.createElement("button");
        gaugeButton.id = row;

        var gaugeSpan = document.createElement("span");
        gaugeSpan.textContent = "DELETE";

        gaugeButton.appendChild(gaugeSpan);

        gaugeButton.onclick = function () {            
            var thing = gaugeButton;            
            DotNet.invokeMethodAsync('Infragistics.Samples', 'ButtonClickActionAtBlazorLevel', thing.id);
        }

        content.appendChild(gaugeButton);
    }
}

// this code allows calling above functions from a .razor file
igRegisterScript("onUpdatingTemplateColumn", onUpdatingTemplateColumn, false);