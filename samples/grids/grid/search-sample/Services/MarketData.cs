using System;
using System.Collections;
using System.Collections.Generic;

namespace Infragistics.Samples
{
    public class MarketRecord
    {
        public string IndustryGroup { get; set; }
        public string IndustrySector { get; set; }
        public string SectorType { get; set; }
        public double KRD { get; set; }
        public double MarketNotion { get; set; }
        public string Date { get; set; }
    }

    public class MarketData
    {
        public static List<MarketRecord> GetData()
        {
            var data = new List<MarketRecord>() {
            new MarketRecord() {
                Date = "new",
                IndustryGroup = "Airlines",
                IndustrySector = "Consumer",
                KRD = 6E-05,
                MarketNotion = 47338486.0,
                SectorType = "PUBLIC"
              },
              new MarketRecord() {
                Date = "new",
                IndustryGroup = "Insurance",
                IndustrySector = "Financial",
                KRD = 1.46433,
                MarketNotion = 42605156.0,
                SectorType = "PUBLIC"
              },
              new MarketRecord() {
                Date = "new",
                IndustryGroup = "Insurance",
                IndustrySector = "Financial",
                KRD = 0.0,
                MarketNotion = 41030865.0,
                SectorType = "PUBLIC"
              },
              new MarketRecord() {
                Date = "new",
                IndustryGroup = "Banks",
                IndustrySector = "Financial",
                KRD = 6E-05,
                MarketNotion = 30346443.0,
                SectorType = "PUBLIC"
              },
              new MarketRecord() {
                Date = "new",
                IndustryGroup = "Retail",
                IndustrySector = "Consumer, Cyclical",
                KRD = 0.20296,
                MarketNotion = 25111160.0,
                SectorType = "PUBLIC"
              },
              new MarketRecord() {
                Date = "new",
                IndustryGroup = "Sovereign",
                IndustrySector = "Government",
                KRD = 0.05421,
                MarketNotion = 23189929.0,
                SectorType = "US GOVERNMENT"
              },
              new MarketRecord() {
                Date = "new",
                IndustryGroup = "Municipal",
                IndustrySector = "Government",
                KRD = 0.00031,
                MarketNotion = 19365191.0,
                SectorType = "FIXED"
              },
              new MarketRecord() {
                Date = "new",
                IndustryGroup = "Municipal",
                IndustrySector = "Government",
                KRD = 0.0,
                MarketNotion = 16235303.0,
                SectorType = "FIXED"
              },
              new MarketRecord() {
                Date = "new",
                IndustryGroup = "Engineering&Construction",
                IndustrySector = "Industrial",
                KRD = 0.00087,
                MarketNotion = 11072448.0,
                SectorType = "GLOBAL"
              },
              new MarketRecord() {
                Date = "new",
                IndustryGroup = "Engineering&Construction",
                IndustrySector = "Industrial",
                KRD = -0.00063,
                MarketNotion = 7550053.0,
                SectorType = "GLOBAL"
              },
              new MarketRecord() {
                Date = "new",
                IndustryGroup = "Municipal",
                IndustrySector = "Government",
                KRD = -1E-05,
                MarketNotion = 6372222.0,
                SectorType = "ADJUSTABLE"
              },
              new MarketRecord() {
                Date = "new",
                IndustryGroup = "Municipal",
                IndustrySector = "Government",
                KRD = 0.0,
                MarketNotion = 5990939.0,
                SectorType = "FIXED, OID"
              },
              new MarketRecord() {
                Date = "new",
                IndustryGroup = "Banks",
                IndustrySector = "Financial",
                KRD = 2E-05,
                MarketNotion = 5809637.0,
                SectorType = "EURO-DOLLAR"
              },
              new MarketRecord() {
                Date = "new",
                IndustryGroup = "Banks",
                IndustrySector = "Financial",
                KRD = 0.00377,
                MarketNotion = 1435870.0,
                SectorType = "GLOBAL"
              },
              new MarketRecord() {
                Date = "new",
                IndustryGroup = "Airlines",
                IndustrySector = "Consumer",
                KRD = 6E-05,
                MarketNotion = 47338486.0,
                SectorType = "PUBLIC"
              },
              new MarketRecord() {
                Date = "new",
                IndustryGroup = "Insurance",
                IndustrySector = "Financial",
                KRD = 1.46433,
                MarketNotion = 42605156.0,
                SectorType = "PUBLIC"
              },
              new MarketRecord() {
                Date = "new",
                IndustryGroup = "Insurance",
                IndustrySector = "Financial",
                KRD = 0.0,
                MarketNotion = 41030865.0,
                SectorType = "PUBLIC"
              },
              new MarketRecord() {
                Date = "new",
                IndustryGroup = "Banks",
                IndustrySector = "Financial",
                KRD = 6E-05,
                MarketNotion = 30346443.0,
                SectorType = "PUBLIC"
              },
              new MarketRecord() {
                Date = "new",
                IndustryGroup = "Retail",
                IndustrySector = "Consumer, Cyclical",
                KRD = 0.20296,
                MarketNotion = 25111160.0,
                SectorType = "PUBLIC"
              },
              new MarketRecord() {
                Date = "new",
                IndustryGroup = "Sovereign",
                IndustrySector = "Government",
                KRD = 0.05421,
                MarketNotion = 23189929.0,
                SectorType = "US GOVERNMENT"
              },
              new MarketRecord() {
                Date = "new",
                IndustryGroup = "Municipal",
                IndustrySector = "Government",
                KRD = 0.00031,
                MarketNotion = 19365191.0,
                SectorType = "FIXED"
              },
              new MarketRecord() {
                Date = "new",
                IndustryGroup = "Municipal",
                IndustrySector = "Government",
                KRD = 0.0,
                MarketNotion = 16235303.0,
                SectorType = "FIXED"
              },
              new MarketRecord() {
                Date = "new",
                IndustryGroup = "Engineering&Construction",
                IndustrySector = "Industrial",
                KRD = 0.00087,
                MarketNotion = 11072448.0,
                SectorType = "GLOBAL"
              },
              new MarketRecord() {
                Date = "new",
                IndustryGroup = "Engineering&Construction",
                IndustrySector = "Industrial",
                KRD = -0.00063,
                MarketNotion = 7550053.0,
                SectorType = "GLOBAL"
              },
              new MarketRecord() {
                Date = "new",
                IndustryGroup = "Municipal",
                IndustrySector = "Government",
                KRD = -1E-05,
                MarketNotion = 6372222.0,
                SectorType = "ADJUSTABLE"
              },
              new MarketRecord() {
                Date = "new",
                IndustryGroup = "Municipal",
                IndustrySector = "Government",
                KRD = 0.0,
                MarketNotion = 5990939.0,
                SectorType = "FIXED, OID"
              },
              new MarketRecord() {
                Date = "new",
                IndustryGroup = "Banks",
                IndustrySector = "Financial",
                KRD = 2E-05,
                MarketNotion = 5809637.0,
                SectorType = "EURO-DOLLAR"
              },
              new MarketRecord() {
                Date = "new",
                IndustryGroup = "Banks",
                IndustrySector = "Financial",
                KRD = 0.00377,
                MarketNotion = 1435870.0,
                SectorType = "GLOBAL"
              },
              new MarketRecord() {
                Date = "new",
                IndustryGroup = "Airlines",
                IndustrySector = "Consumer",
                KRD = 6E-05,
                MarketNotion = 47338486.0,
                SectorType = "PUBLIC"
              },
              new MarketRecord() {
                Date = "new",
                IndustryGroup = "Insurance",
                IndustrySector = "Financial",
                KRD = 1.46433,
                MarketNotion = 42605156.0,
                SectorType = "PUBLIC"
              },
              new MarketRecord() {
                Date = "new",
                IndustryGroup = "Insurance",
                IndustrySector = "Financial",
                KRD = 0.0,
                MarketNotion = 41030865.0,
                SectorType = "PUBLIC"
              },
              new MarketRecord() {
                Date = "new",
                IndustryGroup = "Banks",
                IndustrySector = "Financial",
                KRD = 6E-05,
                MarketNotion = 30346443.0,
                SectorType = "PUBLIC"
              },
              new MarketRecord() {
                Date = "new",
                IndustryGroup = "Retail",
                IndustrySector = "Consumer, Cyclical",
                KRD = 0.20296,
                MarketNotion = 25111160.0,
                SectorType = "PUBLIC"
              },
              new MarketRecord() {
                Date = "new",
                IndustryGroup = "Sovereign",
                IndustrySector = "Government",
                KRD = 0.05421,
                MarketNotion = 23189929.0,
                SectorType = "US GOVERNMENT"
              },
              new MarketRecord() {
                Date = "new",
                IndustryGroup = "Municipal",
                IndustrySector = "Government",
                KRD = 0.00031,
                MarketNotion = 19365191.0,
                SectorType = "FIXED"
              },
              new MarketRecord() {
                Date = "new",
                IndustryGroup = "Municipal",
                IndustrySector = "Government",
                KRD = 0.0,
                MarketNotion = 16235303.0,
                SectorType = "FIXED"
              },
              new MarketRecord() {
                Date = "new",
                IndustryGroup = "Engineering&Construction",
                IndustrySector = "Industrial",
                KRD = 0.00087,
                MarketNotion = 11072448.0,
                SectorType = "GLOBAL"
              },
              new MarketRecord() {
                Date = "new",
                IndustryGroup = "Engineering&Construction",
                IndustrySector = "Industrial",
                KRD = -0.00063,
                MarketNotion = 7550053.0,
                SectorType = "GLOBAL"
              },
              new MarketRecord() {
                Date = "new",
                IndustryGroup = "Municipal",
                IndustrySector = "Government",
                KRD = -1E-05,
                MarketNotion = 6372222.0,
                SectorType = "ADJUSTABLE"
              },
              new MarketRecord() {
                Date = "new",
                IndustryGroup = "Municipal",
                IndustrySector = "Government",
                KRD = 0.0,
                MarketNotion = 5990939.0,
                SectorType = "FIXED, OID"
              },
              new MarketRecord() {
                Date = "new",
                IndustryGroup = "Banks",
                IndustrySector = "Financial",
                KRD = 2E-05,
                MarketNotion = 5809637.0,
                SectorType = "EURO-DOLLAR"
              },
              new MarketRecord() {
                Date = "new",
                IndustryGroup = "Banks",
                IndustrySector = "Financial",
                KRD = 0.00377,
                MarketNotion = 1435870.0,
                SectorType = "GLOBAL"
              }
            };
            return data;
        }
    }

}