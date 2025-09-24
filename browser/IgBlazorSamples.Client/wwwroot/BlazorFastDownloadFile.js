// these methods are from:  
// https://www.meziantou.net/generating-and-downloading-a-file-in-a-blazor-webassembly-application.htm
export function BlazorDownloadFileFast(name, contentType, content) {
    var nameStr = name;
    var contentTypeStr = contentType;
    var contentArray = new Uint8Array(content);
    // Create the URL
    var file = new File([contentArray], nameStr, { type: contentTypeStr });
    var exportUrl = URL.createObjectURL(file);
    // Create the <a> element and click on it
    var a = document.createElement("a");
    document.body.appendChild(a);
    a.href = exportUrl;
    a.download = nameStr;
    a.target = "_self";
    a.click();
    // We don't need to keep the url, let's release the memory
    URL.revokeObjectURL(exportUrl);
}
