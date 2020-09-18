
var __highVolumeDataCount = 1000;
var __highVolumeData = [];
function setHighVolumeDataCount(dataCount) {
    __highVolumeDataCount = dataCount;
    __highVoluenData = generateHighVolumeData();
    var chart = document.querySelectorAll("igc-category-chart");
    if (chart && chart.length > 0) {
        for (var  i = 0; i < chart.length; i++) {
            if (chart[i].dataSource === __highVolumeData) {
                chart[i].notifyClearItems(__highVolumeData);
            }
        }       
    }
}

function generateHighVolumeData() {
    var dataCount = __highVolumeDataCount;
    var curr = 100.0;
    var data = __highVolumeData;
    __highVolumeData.length = dataCount;
    for (var i = 0; i < dataCount; i++) {
        curr += Math.random() * 4.0 - 2.0;
        data[i] = { Label: i.toString(), Value: curr };
    }

    return data;
}

function getHighVolumeData() {
    return __highVolumeData;
}

igRegisterScript("getHighVolumeData", getHighVolumeData, true);
