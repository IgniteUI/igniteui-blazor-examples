function renderChartToImage() {
    var chart = document.getElementsByClassName("ig-data-chart igc-data-chart")[0];
    var image = chart.renderToImage(chart.viewportRect.width, chart.viewportRect.height);
    this.saveBase64AsFile(image.src, "file.jpg");
}

function saveBase64AsFile(base64, fileName) {
    var link = document.createElement("a");
    document.body.appendChild(link);
    link.setAttribute("type", "hidden");
    link.href = base64;
    link.download = fileName;
    link.click();
    document.body.removeChild(link);
}