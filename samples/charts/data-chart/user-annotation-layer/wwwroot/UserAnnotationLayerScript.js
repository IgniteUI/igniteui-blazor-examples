import { registerScript } from './_content/IgniteUI.Blazor/api.js';

function onUserAnnotationToggleDialog(open) {
    var dialog = document.getElementsByClassName("annotationDialogPopup")[0];

    if (open) {
        dialog.style.display = "block";
    }
    else {
        dialog.style.display = "none";
    }
}

function onUserAnnotationToolTipContentUpdatingScript(o, e) {
    var tooltipText = e.annotationInfo.annotationData;

    if (e.content.children.length == 0) {
        var element = document.createElement("div");
        element.textContent = tooltipText;
        element.style = "color: white";
        e.content.appendChild(element);
    }
    else {
        var element = e.content.children[0];
        element.textContent = tooltipText;
    }
}

registerScript("onUserAnnotationToolTipContentUpdatingScript", onUserAnnotationToolTipContentUpdatingScript);

function getBadgeColor() {
    var badgeColorEditor = document.getElementById("annotationBadgeColorEditor").childNodes[0].childNodes[0];
    return badgeColorEditor.value;
}

function getMainColor() {
    var mainColorEditor = document.getElementById("annotationMainColorEditor").childNodes[0].childNodes[0];
    return mainColorEditor.value;
}

// called by name from the page, so keep them reachable from the module
window.onUserAnnotationToggleDialog = onUserAnnotationToggleDialog;
window.getBadgeColor = getBadgeColor;
window.getMainColor = getMainColor;
