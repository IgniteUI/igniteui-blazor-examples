
    var ___intervalDays = 0;
    var ___intervalHours = 1;
    var ___intervalMinutes = 0;

    var ___priceStart = 200;
    var ___priceRange = 1;
    var ___volumeRange = 1000;
    var ___volumeStart = 20000000;

    var ___dateStart;
    var ___dateEnd;
    var ___fcVolumeData;

    function setFCGenerationRange(dateStart, dateEnd) {
        ___dateStart = new Date(dateStart);
        ___dateEnd = new Date(dateEnd);
        generateFCHighVolumeData();
        var chart = document.querySelectorAll("igc-financial-chart");
        if (chart && chart.length > 0) {
            for (var  i = 0; i < chart.length; i++) {
                if (chart[i].dataSource === ___fcVolumeData) {
                    chart[i].notifyClearItems(___fcVolumeData);
                }
            }       
        }
    }
    
    function generateFCHighVolumeData() {
        ___fcVolumeData = getStocksBetween(___dateStart, ___dateEnd);
    
        return ___fcVolumeData;
    }
    
    function getFCHighVolumeData() {
        return ___fcVolumeData;
    }

    function addMinutes(date, minutes) {
        return new Date(date.getTime() + minutes*60000);
    }

    function getStocksBetween(dateStart, dateEnd)
    {
        var interval = ___intervalDays * 24 * 60;
        interval += ___intervalHours * 60;
        interval += ___intervalMinutes;

        var time = new Date();
        time.setTime(dateStart.getTime());
        var v = ___volumeStart;
        var o = ___priceStart;

        var h = o + (Math.random() * ___priceRange);
        var l = o - (Math.random() * ___priceRange);
        var c = l + (Math.random() * (h - l));

        var stock = [];
        while (time < dateEnd)
        {
            var stockItem =
            {
                Date: time, Open: o, High: h, Low: l, Close: c, Volume: v
            };

            stock.push(stockItem);

            o = c + ((Math.random() - 0.5) * ___priceRange);
            if (o < 0)
            {
                o = Math.abs(o) + 2;
            }
            h = o + (Math.random() * ___priceRange);
            l = o - (Math.random() * ___priceRange);
            c = l + (Math.random() * (h - l));
            v = v + ((Math.random() - 0.5) * ___volumeRange);
            if (v < 0)
            {
                v = Math.Abs(v) + 10000;
            }

            o = Math.round(o * 100) / 100;
            h = Math.round(h * 100) / 100;
            l = Math.round(l * 100) / 100;
            c = Math.round(c * 100) / 100;
            v = Math.round(v * 100) / 100;

            time = addMinutes(time, interval);
        }
        //setting data intent for Series Title
        //   (stock as any).__dataIntents = {
        //    close: ["SeriesTitle/Stock Prices"]
        //};

        return stock;
    }

    igRegisterScript("getFCHighVolumeData", getFCHighVolumeData, true);

    