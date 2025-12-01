function onUserAnnotationEnable() {
    var x = document.getElementsByClassName("igc-data-chart")[0];
    x.isUserAnnotationsEnabled = true;
}

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

igRegisterScript("onUserAnnotationToolTipContentUpdatingScript", onUserAnnotationToolTipContentUpdatingScript, false);


function getBadgeColor() {
    var badgeColorEditor = document.getElementById("annotationBadgeColorEditor").childNodes[0].childNodes[0];
    return badgeColorEditor.value;
}

function getMainColor() {
    var mainColorEditor = document.getElementById("annotationMainColorEditor").childNodes[0].childNodes[0];
    return mainColorEditor.value;
}



