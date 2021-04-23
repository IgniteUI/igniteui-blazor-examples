
var __highVolumeDataCount = 1000000;
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
    var index = "";
    __highVolumeData.length = dataCount;
    for (var i = 0; i <= dataCount; i++) {
        curr += Math.random() * 4.0 - 2.0;
        index = toStringWithCommas(i); 
        data[i] = { Label: index, Value: curr };
    }
    return data;
}

function toStringWithCommas(num) {
    return num.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",");
}

function getHighVolumeData() {
    return __highVolumeData;
}

igRegisterScript("getHighVolumeData", getHighVolumeData, true);
