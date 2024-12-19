using System;
using System.Collections.Generic;
public class WorldCitiesItem
{
    public bool Capital { get; set; }
    public double Population { get; set; }
    public double Y { get; set; }
    public double X { get; set; }
    public string Country { get; set; }
    public string Name { get; set; }
}

public class WorldCities
    : List<WorldCitiesItem>
{
    public WorldCities()
    {
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 23.62,
            Y = 35.68,
            X = 139.81,
            Country = @"Japan",
            Name = @"Tokyo"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 16.47,
            Y = 40.75,
            X = -74.1,
            Country = @"US",
            Name = @"New York"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 15.85,
            Y = 37.54,
            X = 126.94,
            Country = @"South Korea",
            Name = @"Seoul"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 15.18,
            Y = -23.58,
            X = -46.62,
            Country = @"Brazil",
            Name = @"Sao Paulo"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 15.04,
            Y = 34.64,
            X = 135.52,
            Country = @"Japan",
            Name = @"Osaka"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 14.1,
            Y = 19.43,
            X = -99.13,
            Country = @"Mexico",
            Name = @"Mexico City"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 13.1,
            Y = 55.75,
            X = 37.7,
            Country = @"Russia",
            Name = @"Moscow"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 11.1,
            Y = 22.54,
            X = 88.33,
            Country = @"India",
            Name = @"Calcutta"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 11.1,
            Y = 51.49,
            X = -0.18,
            Country = @"UK",
            Name = @"London"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 10.75,
            Y = -34.67,
            X = -58.41,
            Country = @"Argentina",
            Name = @"Buenos Aires"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 10.15,
            Y = -22.72,
            X = -43.46,
            Country = @"Brazil",
            Name = @"Rio de Janeiro"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 9.95,
            Y = 19.05,
            X = 73.17,
            Country = @"India",
            Name = @"Bombay"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 9.78,
            Y = 48.88,
            X = 2.43,
            Country = @"France",
            Name = @"Paris"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 9.76,
            Y = 34,
            X = -118.25,
            Country = @"US",
            Name = @"Los Angeles"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 9.41,
            Y = 24.98,
            X = 121.53,
            Country = @"Taiwan",
            Name = @"Chingmei"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 9.3,
            Y = 30.08,
            X = 31.25,
            Country = @"Egypt",
            Name = @"Cairo"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 9.3,
            Y = 31.25,
            X = 121.47,
            Country = @"China",
            Name = @"Shanghai"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 8.6,
            Y = -6.29,
            X = 106.76,
            Country = @"Indonesia",
            Name = @"Jakarta"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 7.72,
            Y = 41.83,
            X = -87.64,
            Country = @"US",
            Name = @"Chicago"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 7.2,
            Y = 28.53,
            X = 77.22,
            Country = @"India",
            Name = @"Delhi"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 6.45,
            Y = 13.75,
            X = 100.55,
            Country = @"Thailand",
            Name = @"Bangkok"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 6.45,
            Y = 39.91,
            X = 116.39,
            Country = @"China",
            Name = @"Beijing"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 6.4,
            Y = 35.77,
            X = 51.45,
            Country = @"Iran",
            Name = @"Tehran"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 6.13,
            Y = 25.04,
            X = 121.51,
            Country = @"Taiwan",
            Name = @"Taipei"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 5.83,
            Y = 59.95,
            X = 30.45,
            Country = @"Russia",
            Name = @"Saint Petersburg"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 5.75,
            Y = 41.07,
            X = 29.01,
            Country = @"Turkey",
            Name = @"Istanbul"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 5.47,
            Y = 14.55,
            X = 121.17,
            Country = @"Philippines",
            Name = @"Manila"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 5.4,
            Y = 22.43,
            X = 114.15,
            Country = @"UK",
            Name = @"Hong Kong"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 5.3,
            Y = 24.85,
            X = 67.03,
            Country = @"Pakistan",
            Name = @"Karachi"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 5.21,
            Y = 39.93,
            X = -75.22,
            Country = @"US",
            Name = @"Philadelphia"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 5.06,
            Y = 52.52,
            X = 13.33,
            Country = @"Germany",
            Name = @"Berlin"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 4.88,
            Y = 39.13,
            X = 117.19,
            Country = @"China",
            Name = @"Tianjin"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 4.8,
            Y = 35.15,
            X = 136.92,
            Country = @"Japan",
            Name = @"Nagoya"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 4.69,
            Y = 42.39,
            X = -83.08,
            Country = @"US",
            Name = @"Detroit"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 4.65,
            Y = 40.44,
            X = -3.69,
            Country = @"Spain",
            Name = @"Madrid"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 4.47,
            Y = 13.06,
            X = 80.25,
            Country = @"India",
            Name = @"Madras"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 4.34,
            Y = -12.07,
            X = -76.82,
            Country = @"Peru",
            Name = @"Lima"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 4.26,
            Y = 4.63,
            X = -74.08,
            Country = @"Colombia",
            Name = @"Bogota"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 4.1,
            Y = -33.48,
            X = -70.65,
            Country = @"Chile",
            Name = @"Santiago"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 4.05,
            Y = 37.73,
            X = -122.31,
            Country = @"US",
            Name = @"San Francisco"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 4.04,
            Y = 41.53,
            X = 2.17,
            Country = @"Spain",
            Name = @"BarceXa"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 3.97,
            Y = 42.38,
            X = -71.1,
            Country = @"US",
            Name = @"Boston"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 3.87,
            Y = 51.35,
            X = 7.12,
            Country = @"Germany",
            Name = @"Essen"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 3.84,
            Y = 33.33,
            X = 44.4,
            Country = @"Iraq",
            Name = @"Baghdad"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 3.84,
            Y = 41.8,
            X = 123.38,
            Country = @"China",
            Name = @"Shenyang"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 3.8,
            Y = 6.45,
            X = 3.3,
            Country = @"Nigeria",
            Name = @"Lagos"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 3.8,
            Y = 35.16,
            X = 129.05,
            Country = @"South Korea",
            Name = @"Pusan"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 3.75,
            Y = 45.47,
            X = 9.19,
            Country = @"Italy",
            Name = @"Milano"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 3.65,
            Y = -26.18,
            X = 28,
            Country = @"South Africa",
            Name = @"Johannesburg"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 3.6,
            Y = 10.5,
            X = -66.9,
            Country = @"Venezuela",
            Name = @"Caracas"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 3.49,
            Y = 30.57,
            X = 114.28,
            Country = @"China",
            Name = @"Wuhan"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 3.43,
            Y = 23.71,
            X = 90.41,
            Country = @"Bangladesh",
            Name = @"Dhaka"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 3.43,
            Y = 43.72,
            X = -79.41,
            Country = @"Canada",
            Name = @"Toronto"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 3.37,
            Y = -33.89,
            X = 151.03,
            Country = @"Australia",
            Name = @"Sydney"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 3.35,
            Y = 31.07,
            X = 29.98,
            Country = @"Egypt",
            Name = @"Alexandria"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 3.22,
            Y = 38.89,
            X = -76.95,
            Country = @"US",
            Name = @"Washington D.C."
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 3.17,
            Y = 41.88,
            X = 12.52,
            Country = @"Italy",
            Name = @"Roma"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 3.1,
            Y = 10.76,
            X = 106.66,
            Country = @"Vietnam",
            Name = @"Ho Chi Minh City"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 3.05,
            Y = 23.1,
            X = 113.29,
            Country = @"China",
            Name = @"Guangzhou"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 3.03,
            Y = 38.12,
            X = 23.65,
            Country = @"Greece",
            Name = @"Athens"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 3.02,
            Y = 1.23,
            X = 104.18,
            Country = @"Singapore",
            Name = @"Singapore"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 3.02,
            Y = 31.55,
            X = 74.34,
            Country = @"Pakistan",
            Name = @"Lahore"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 3,
            Y = -4.39,
            X = 15.47,
            Country = @"Zaire",
            Name = @"Kinshasa"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 2.99,
            Y = 35.44,
            X = 139.62,
            Country = @"Japan",
            Name = @"Yokohama"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 2.95,
            Y = -19.85,
            X = -43.91,
            Country = @"Brazil",
            Name = @"Belo Horizonte"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 2.95,
            Y = 12.97,
            X = 77.59,
            Country = @"India",
            Name = @"Bangalore"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 2.92,
            Y = 45.54,
            X = -73.65,
            Country = @"Canada",
            Name = @"Montreal"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 2.9,
            Y = 50.45,
            X = 30.5,
            Country = @"Ukraine",
            Name = @"Kiev"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 2.88,
            Y = 40.83,
            X = 14.27,
            Country = @"Italy",
            Name = @"Napoli"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 2.83,
            Y = -37.85,
            X = 145.08,
            Country = @"Australia",
            Name = @"Melbourne"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 2.83,
            Y = 25.83,
            X = -80.27,
            Country = @"US",
            Name = @"Miami"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 2.8,
            Y = 16.87,
            X = 96.12,
            Country = @"Burma",
            Name = @"Rangoon"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 2.77,
            Y = 53.48,
            X = -2.26,
            Country = @"UK",
            Name = @"Manchester"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 2.75,
            Y = 17.39,
            X = 78.49,
            Country = @"India",
            Name = @"Hyderabad"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 2.75,
            Y = 29.77,
            X = -95.41,
            Country = @"US",
            Name = @"Houston"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 2.73,
            Y = 32.76,
            X = -96.66,
            Country = @"US",
            Name = @"Dallas"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 2.67,
            Y = 45.76,
            X = 126.62,
            Country = @"China",
            Name = @"Harbin"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 2.67,
            Y = 52.49,
            X = -1.86,
            Country = @"UK",
            Name = @"Birmingham"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 2.63,
            Y = -8.09,
            X = -34.91,
            Country = @"Brazil",
            Name = @"Recife"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 2.6,
            Y = -30.04,
            X = -51.21,
            Country = @"Brazil",
            Name = @"Porto Alegre"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 2.56,
            Y = 47.51,
            X = 19.09,
            Country = @"Hungary",
            Name = @"Budapest"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 2.55,
            Y = 36.6,
            X = 2.99,
            Country = @"Algeria",
            Name = @"Algiers"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 2.48,
            Y = 33.54,
            X = -7.53,
            Country = @"Morocco",
            Name = @"Casablanca"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 2.45,
            Y = 29.54,
            X = 106.52,
            Country = @"China",
            Name = @"Chongqing"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 2.4,
            Y = 23.04,
            X = 72.57,
            Country = @"India",
            Name = @"Ahmadabad"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 2.4,
            Y = 39.93,
            X = 32.85,
            Country = @"Turkey",
            Name = @"Ankara"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 2.38,
            Y = 50.84,
            X = 4.37,
            Country = @"Belgium",
            Name = @"Bruxelles"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 2.33,
            Y = 41.25,
            X = 69.35,
            Country = @"Uzbekistan",
            Name = @"Toshkent"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 2.33,
            Y = 20.67,
            X = -103.34,
            Country = @"Mexico",
            Name = @"Guadalajara"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 2.32,
            Y = 52.24,
            X = 21.01,
            Country = @"Poland",
            Name = @"Warsaw"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 2.29,
            Y = 32.05,
            X = 118.77,
            Country = @"China",
            Name = @"Nanjing"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 2.25,
            Y = 38.73,
            X = -9.13,
            Country = @"Portugal",
            Name = @"Lisboa"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 2.25,
            Y = 44.43,
            X = 26.12,
            Country = @"Romania",
            Name = @"Bucharest"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 2.23,
            Y = 53.57,
            X = 10.03,
            Country = @"Germany",
            Name = @"Hamburg"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 2.22,
            Y = 40.5,
            X = -80,
            Country = @"US",
            Name = @"Pittsburgh"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 2.22,
            Y = 41.39,
            X = -81.73,
            Country = @"US",
            Name = @"Cleveland"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 2.21,
            Y = 35.86,
            X = 128.59,
            Country = @"South Korea",
            Name = @"Taegu"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 2.2,
            Y = 38.64,
            X = -90.34,
            Country = @"US",
            Name = @"St. Louis"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 2.2,
            Y = 48.04,
            X = 37.74,
            Country = @"Ukraine",
            Name = @"Donets'k"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 2.13,
            Y = 23.05,
            X = -82.42,
            Country = @"Cuba",
            Name = @"Havana"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 2.1,
            Y = 32.76,
            X = -117.13,
            Country = @"US",
            Name = @"San Diego"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 2.1,
            Y = 6.24,
            X = -75.59,
            Country = @"Colombia",
            Name = @"Medellin"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 2.08,
            Y = 47.59,
            X = -122.32,
            Country = @"US",
            Name = @"Seattle"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 2.05,
            Y = -12.6,
            X = -38.48,
            Country = @"Brazil",
            Name = @"Salvador"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 2.05,
            Y = 7.02,
            X = 80.09,
            Country = @"Sri Lanka",
            Name = @"Colombo"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 2.05,
            Y = 34.27,
            X = 108.88,
            Country = @"China",
            Name = @"Xian"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 2.03,
            Y = -7.4,
            X = 112.68,
            Country = @"Indonesia",
            Name = @"Surabaja"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 2.02,
            Y = 25.68,
            X = -100.32,
            Country = @"Mexico",
            Name = @"Monterrey"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 2.02,
            Y = 40.32,
            X = 49.82,
            Country = @"Azerbaijan",
            Name = @"Baku"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 2.02,
            Y = 56.29,
            X = 43.94,
            Country = @"Russia",
            Name = @"Nizhniy Novgorod"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 2.01,
            Y = 44.92,
            X = -93.31,
            Country = @"US",
            Name = @"Minneapolis"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.96,
            Y = 33.8,
            X = -84.35,
            Country = @"US",
            Name = @"Atlanta"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.96,
            Y = 39.32,
            X = -76.62,
            Country = @"US",
            Name = @"Baltimore"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.96,
            Y = 48.14,
            X = 11.54,
            Country = @"Germany",
            Name = @"Munich"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 1.95,
            Y = 5.32,
            X = -4.02,
            Country = @"Ivory Coast",
            Name = @"Abidjan"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.94,
            Y = 49.99,
            X = 36.21,
            Country = @"Ukraine",
            Name = @"Kharkov"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.9,
            Y = 43.06,
            X = 141.35,
            Country = @"Japan",
            Name = @"Sapporo"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.88,
            Y = 26.46,
            X = 80.32,
            Country = @"India",
            Name = @"Kanpur"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 1.88,
            Y = 48.2,
            X = 16.32,
            Country = @"Austria",
            Name = @"Vienna"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.87,
            Y = 30.47,
            X = 30.85,
            Country = @"Egypt",
            Name = @"Giza"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 1.86,
            Y = 52.37,
            X = 4.89,
            Country = @"Netherlands",
            Name = @"Amsterdam"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 1.85,
            Y = 33.52,
            X = 36.31,
            Country = @"Syria",
            Name = @"Damascus"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.85,
            Y = 50.13,
            X = 8.67,
            Country = @"Germany",
            Name = @"Frankfurt am Main"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.84,
            Y = 22.67,
            X = 120.34,
            Country = @"Taiwan",
            Name = @"Kao-Hsiung"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.82,
            Y = -3.78,
            X = -38.59,
            Country = @"Brazil",
            Name = @"Fortaleza"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.81,
            Y = 30.67,
            X = 104.07,
            Country = @"China",
            Name = @"Chengdu"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.8,
            Y = -6.91,
            X = 107.61,
            Country = @"Indonesia",
            Name = @"Bandung"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.8,
            Y = 55.86,
            X = -4.27,
            Country = @"UK",
            Name = @"Glasgow"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.79,
            Y = -33.8,
            X = 18.69,
            Country = @"South Africa",
            Name = @"Cape Town"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 1.77,
            Y = 18.4,
            X = -66.08,
            Country = @"Puerto Rico",
            Name = @"San Juan"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.77,
            Y = 18.54,
            X = 73.85,
            Country = @"India",
            Name = @"Pune"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.76,
            Y = 50.94,
            X = 6.93,
            Country = @"Germany",
            Name = @"Koln"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.75,
            Y = 33.31,
            X = 130.32,
            Country = @"Japan",
            Name = @"Fukuoka"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.74,
            Y = 43.88,
            X = 125.31,
            Country = @"China",
            Name = @"Changchung"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.7,
            Y = -25.43,
            X = -49.28,
            Country = @"Brazil",
            Name = @"Curitiba"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 1.69,
            Y = 55.72,
            X = 12.55,
            Country = @"Denmark",
            Name = @"Kobenhavn"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 1.68,
            Y = 33.78,
            X = 35.66,
            Country = @"Lebanon",
            Name = @"Beirut"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.68,
            Y = 39.03,
            X = 121.6,
            Country = @"China",
            Name = @"Dalian"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 1.67,
            Y = 31.92,
            X = 34.86,
            Country = @"Israel",
            Name = @"Tel Aviv-Yafo"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.66,
            Y = 37.89,
            X = 112.55,
            Country = @"China",
            Name = @"Taiyuan"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 1.65,
            Y = 53.9,
            X = 27.58,
            Country = @"Belarus",
            Name = @"Minsk"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.62,
            Y = 56.85,
            X = 60.61,
            Country = @"Russia",
            Name = @"Yekaterinburg"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.6,
            Y = 48.42,
            X = 35.14,
            Country = @"Ukraine",
            Name = @"Dnepropetrovsk"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.6,
            Y = 37.59,
            X = 126.77,
            Country = @"South Korea",
            Name = @"Inch`on"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 1.6,
            Y = 39.03,
            X = 125.76,
            Country = @"North Korea",
            Name = @"Pyongyang"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.6,
            Y = 55.03,
            X = 82.94,
            Country = @"Russia",
            Name = @"Novosibirsk"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 1.57,
            Y = -15.79,
            X = -47.9,
            Country = @"Brazil",
            Name = @"Brasilia"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.57,
            Y = 34.38,
            X = 132.44,
            Country = @"Japan",
            Name = @"Hiroshima"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 1.55,
            Y = -34.92,
            X = -56.17,
            Country = @"Uruguay",
            Name = @"Montevideo"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.55,
            Y = 38.44,
            X = 27.21,
            Country = @"Turkey",
            Name = @"Izmir"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.55,
            Y = -29.84,
            X = 30.94,
            Country = @"South Africa",
            Name = @"Durban"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.55,
            Y = 45.07,
            X = 7.67,
            Country = @"Italy",
            Name = @"Torino"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.54,
            Y = 53.81,
            X = -1.5,
            Country = @"UK",
            Name = @"Leeds"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.52,
            Y = 53.42,
            X = -2.77,
            Country = @"UK",
            Name = @"Liverpool"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.52,
            Y = 33.68,
            X = 130.8,
            Country = @"Japan",
            Name = @"Kita Kyushu"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 1.5,
            Y = 9.03,
            X = 38.7,
            Country = @"Ethiopia",
            Name = @"Adis Abeba"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 1.5,
            Y = 21.03,
            X = 105.82,
            Country = @"Vietnam",
            Name = @"Hanoi"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.5,
            Y = 53.14,
            X = 50.1,
            Country = @"Russia",
            Name = @"Samara"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 1.48,
            Y = 3.15,
            X = 101.71,
            Country = @"Malaysia",
            Name = @"Kuala Lumpur"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.48,
            Y = 33.51,
            X = -112.11,
            Country = @"US",
            Name = @"Phoenix"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.48,
            Y = 35.01,
            X = 135.75,
            Country = @"Japan",
            Name = @"Kyoto"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.48,
            Y = 39.15,
            X = -84.48,
            Country = @"US",
            Name = @"Cincinnati"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.48,
            Y = 42.9,
            X = -78.85,
            Country = @"US",
            Name = @"Buffalo"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 1.46,
            Y = -9,
            X = 13.46,
            Country = @"Angola",
            Name = @"Luanda"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.46,
            Y = 36.29,
            X = 59.6,
            Country = @"Iran",
            Name = @"Mashhad"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.46,
            Y = 36.66,
            X = 116.97,
            Country = @"China",
            Name = @"Jinan"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 1.46,
            Y = 41.72,
            X = 44.78,
            Country = @"Georgia",
            Name = @"Tbilisi"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 1.45,
            Y = 59.24,
            X = 18.08,
            Country = @"Sweden",
            Name = @"Stockholm"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 1.43,
            Y = 14.63,
            X = -16.85,
            Country = @"Senegal",
            Name = @"Dakar"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.41,
            Y = 39.75,
            X = -105.07,
            Country = @"US",
            Name = @"Denver"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.41,
            Y = 34.66,
            X = 135.18,
            Country = @"Japan",
            Name = @"Kobe"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.4,
            Y = 3.46,
            X = -76.52,
            Country = @"Colombia",
            Name = @"Cali"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 1.4,
            Y = 14.62,
            X = -90.52,
            Country = @"Guatemala",
            Name = @"Guatemala"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 1.4,
            Y = 44.8,
            X = 20.41,
            Country = @"Serbia",
            Name = @"Belgrade"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.39,
            Y = 22.48,
            X = 91.83,
            Country = @"Bangladesh",
            Name = @"Chittagong"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.38,
            Y = 49.27,
            X = -122.96,
            Country = @"Canada",
            Name = @"Vancouver"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 1.38,
            Y = 29.19,
            X = 48,
            Country = @"Kuwait",
            Name = @"Al Kuwayt"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.38,
            Y = 43.07,
            X = -87.99,
            Country = @"US",
            Name = @"Milwaukee"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.37,
            Y = 3.59,
            X = 98.68,
            Country = @"Indonesia",
            Name = @"Medan"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.36,
            Y = 48.71,
            X = 44.48,
            Country = @"Russia",
            Name = @"Volgograd"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.33,
            Y = 14.65,
            X = 121.03,
            Country = @"Philippines",
            Name = @"Quezon City"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 1.32,
            Y = 50.11,
            X = 14.46,
            Country = @"Czechia",
            Name = @"Prague"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.32,
            Y = 55.15,
            X = 61.39,
            Country = @"Russia",
            Name = @"Chelyabinsk"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 1.31,
            Y = 18.5,
            X = -69.91,
            Country = @"Dominican Rp",
            Name = @"Santo Domingo"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 1.31,
            Y = 40.21,
            X = 44.53,
            Country = @"Armenia",
            Name = @"Yerevan"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.3,
            Y = 21.62,
            X = 39.37,
            Country = @"Saudi Arabia",
            Name = @"Jiddah"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 1.3,
            Y = -6.82,
            X = 39.25,
            Country = @"Tanzania",
            Name = @"Dar es Salaam"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.3,
            Y = 21.16,
            X = 79.09,
            Country = @"India",
            Name = @"Nagpur"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.3,
            Y = 41.12,
            X = 122.98,
            Country = @"China",
            Name = @"Anshan"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 1.29,
            Y = -1.17,
            X = 36.83,
            Country = @"Kenya",
            Name = @"Nairobi"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.28,
            Y = 25.05,
            X = 102.7,
            Country = @"China",
            Name = @"Kunming"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.27,
            Y = 36.15,
            X = 120.43,
            Country = @"China",
            Name = @"Qingdao"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.27,
            Y = 30.25,
            X = 120.17,
            Country = @"China",
            Name = @"Hangzhou"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.27,
            Y = 36.11,
            X = 103.6,
            Country = @"China",
            Name = @"Lanzhou"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.27,
            Y = 38.99,
            X = -94.63,
            Country = @"US",
            Name = @"Kansas City"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.27,
            Y = 39.47,
            X = -0.37,
            Country = @"Spain",
            Name = @"Valencia"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.27,
            Y = 41.86,
            X = 123.91,
            Country = @"China",
            Name = @"Fushun"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.27,
            Y = 45.75,
            X = 4.86,
            Country = @"France",
            Name = @"Lyon"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 1.25,
            Y = 24.65,
            X = 46.77,
            Country = @"Saudi Arabia",
            Name = @"Ar Riyad"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.25,
            Y = -2.2,
            X = -79.91,
            Country = @"Ecuador",
            Name = @"Guayaquil"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 1.25,
            Y = 5.56,
            X = -0.2,
            Country = @"Ghana",
            Name = @"Accra"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 1.25,
            Y = 31.95,
            X = 35.93,
            Country = @"Jordan",
            Name = @"Amman"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.23,
            Y = 41.15,
            X = -8.49,
            Country = @"Portugal",
            Name = @"Porto"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.23,
            Y = 43.3,
            X = 5.38,
            Country = @"France",
            Name = @"Marseille"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.23,
            Y = 45.44,
            X = -122.64,
            Country = @"US",
            Name = @"Portland"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 1.23,
            Y = 36.82,
            X = 10.17,
            Country = @"Tunisia",
            Name = @"Tunis"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.22,
            Y = 36.22,
            X = 37.16,
            Country = @"Syria",
            Name = @"Aleppo"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 1.21,
            Y = 42.71,
            X = 23.33,
            Country = @"Bulgaria",
            Name = @"Sofia"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.2,
            Y = -1.61,
            X = -48.32,
            Country = @"Brazil",
            Name = @"Belem"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.19,
            Y = 28.2,
            X = 112.97,
            Country = @"China",
            Name = @"Changsha"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.19,
            Y = 29.96,
            X = -90.1,
            Country = @"US",
            Name = @"New Orleans"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.19,
            Y = 38.08,
            X = 114.56,
            Country = @"China",
            Name = @"Shijiazhuang"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 1.19,
            Y = 43.26,
            X = 76.91,
            Country = @"Kazakhstan",
            Name = @"Almaty"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.19,
            Y = 46.57,
            X = 30.68,
            Country = @"Ukraine",
            Name = @"Odessa"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 1.18,
            Y = 34.53,
            X = 69.14,
            Country = @"Afghanistan",
            Name = @"Kabul"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.18,
            Y = 55.06,
            X = 73.25,
            Country = @"Russia",
            Name = @"Omsk"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.17,
            Y = 34.76,
            X = 113.64,
            Country = @"China",
            Name = @"Zhengzhou"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.17,
            Y = 43.85,
            X = 126.57,
            Country = @"China",
            Name = @"Jilin"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.17,
            Y = 47.23,
            X = 39.69,
            Country = @"Russia",
            Name = @"Rostov-na-Donu"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.16,
            Y = 58,
            X = 56.23,
            Country = @"Russia",
            Name = @"Perm'"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.15,
            Y = -27.45,
            X = 153.03,
            Country = @"Australia",
            Name = @"Brisbane"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.15,
            Y = 47.34,
            X = 123.96,
            Country = @"China",
            Name = @"Qiqihar"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.14,
            Y = 11.01,
            X = -74.68,
            Country = @"Colombia",
            Name = @"Barranquilla"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.14,
            Y = 7.38,
            X = 3.9,
            Country = @"Nigeria",
            Name = @"Ibadan"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 1.14,
            Y = 53.34,
            X = -6.26,
            Country = @"Ireland",
            Name = @"Dublin"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.14,
            Y = 55.73,
            X = 49.15,
            Country = @"Russia",
            Name = @"Kazan'"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.12,
            Y = 40.65,
            X = 109.98,
            Country = @"China",
            Name = @"Baotou"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.11,
            Y = 51.93,
            X = 4.49,
            Country = @"Netherlands",
            Name = @"Rotterdam"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.1,
            Y = 31.41,
            X = 73.08,
            Country = @"Pakistan",
            Name = @"Faisalabad"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.1,
            Y = 51.21,
            X = 4.43,
            Country = @"Belgium",
            Name = @"Antwerp"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.1,
            Y = 54.82,
            X = 56.1,
            Country = @"Russia",
            Name = @"Ufa"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.09,
            Y = 35.5,
            X = 139.73,
            Country = @"Japan",
            Name = @"Kawasaki"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.07,
            Y = -31.32,
            X = -64.18,
            Country = @"Argentina",
            Name = @"Cordoba"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 1.07,
            Y = -25.96,
            X = 32.57,
            Country = @"Mozambique",
            Name = @"Maputo"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.06,
            Y = -23.95,
            X = -46.31,
            Country = @"Brazil",
            Name = @"Santos"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.06,
            Y = 26.85,
            X = 80.92,
            Country = @"India",
            Name = @"Lucknow"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.06,
            Y = 39.62,
            X = 118.18,
            Country = @"China",
            Name = @"Tangshan"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.06,
            Y = 51.78,
            X = 19.48,
            Country = @"Poland",
            Name = @"Lodz"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 1.05,
            Y = -0.23,
            X = -78.52,
            Country = @"Ecuador",
            Name = @"Quito"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.05,
            Y = 19.05,
            X = -98.19,
            Country = @"Mexico",
            Name = @"Puebla de Zaragoza"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.04,
            Y = 31.78,
            X = -106.45,
            Country = @"US",
            Name = @"El Paso"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.04,
            Y = -32.94,
            X = -60.66,
            Country = @"Argentina",
            Name = @"Rosario"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.04,
            Y = 43.78,
            X = 87.59,
            Country = @"China",
            Name = @"Urumqi"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.03,
            Y = 4.14,
            X = 9.71,
            Country = @"Cameroon",
            Name = @"Douala"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.03,
            Y = 28.67,
            X = 115.89,
            Country = @"China",
            Name = @"Nanchang"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.02,
            Y = -7.03,
            X = 110.44,
            Country = @"Indonesia",
            Name = @"Semarang"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.02,
            Y = 25.61,
            X = 85.14,
            Country = @"India",
            Name = @"Patna"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.02,
            Y = 26.91,
            X = 75.8,
            Country = @"India",
            Name = @"Jaipur"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.02,
            Y = 50.63,
            X = 3.06,
            Country = @"France",
            Name = @"Lille"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 1.01,
            Y = 26.57,
            X = 106.7,
            Country = @"China",
            Name = @"Guiyang"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 1,
            Y = 56.88,
            X = 24.05,
            Country = @"Latvia",
            Name = @"Riga"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.99,
            Y = -31.98,
            X = 115.92,
            Country = @"Australia",
            Name = @"Perth"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.99,
            Y = 32.75,
            X = 13.21,
            Country = @"Libya",
            Name = @"Tripoli"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.99,
            Y = -16.73,
            X = -49.25,
            Country = @"Brazil",
            Name = @"Goiania"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.99,
            Y = -16.5,
            X = -68.15,
            Country = @"Bolivia",
            Name = @"La Paz"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.99,
            Y = 32.65,
            X = 51.68,
            Country = @"Iran",
            Name = @"Esfahan"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.98,
            Y = 33.92,
            X = -6.75,
            Country = @"Morocco",
            Name = @"Rabat"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.98,
            Y = -34.92,
            X = 138.87,
            Country = @"Australia",
            Name = @"Adelaide"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.98,
            Y = 43.28,
            X = -2.97,
            Country = @"Spain",
            Name = @"Bilbao"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.97,
            Y = 29.43,
            X = -98.52,
            Country = @"US",
            Name = @"San Antonio"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.97,
            Y = 38.08,
            X = 46.29,
            Country = @"Iran",
            Name = @"Tabriz"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.96,
            Y = -25.73,
            X = 28.22,
            Country = @"South Africa",
            Name = @"Pretoria"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.96,
            Y = 9.91,
            X = 78.12,
            Country = @"India",
            Name = @"Madurai"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.96,
            Y = 40.04,
            X = -82.99,
            Country = @"US",
            Name = @"Columbus"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.94,
            Y = 37.37,
            X = -5.97,
            Country = @"Spain",
            Name = @"Sevilla"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.93,
            Y = 25.28,
            X = 82.96,
            Country = @"India",
            Name = @"Benares"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.92,
            Y = 15.55,
            X = 32.53,
            Country = @"Sudan",
            Name = @"Khartoum"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.92,
            Y = 13.7,
            X = -89.2,
            Country = @"El Salvador",
            Name = @"San Salvador"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.91,
            Y = 54.37,
            X = 18.62,
            Country = @"Poland",
            Name = @"Gdansk"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.9,
            Y = 60.2,
            X = 24.98,
            Country = @"Finland",
            Name = @"Helsinki"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.89,
            Y = -17.83,
            X = 31.02,
            Country = @"Zimbabwe",
            Name = @"Harare"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.89,
            Y = 10.65,
            X = -71.64,
            Country = @"Venezuela",
            Name = @"Maracaibo"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.89,
            Y = 26.07,
            X = 119.3,
            Country = @"China",
            Name = @"Fuzhou"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.88,
            Y = 18.53,
            X = -72.34,
            Country = @"Haiti",
            Name = @"Port-au-Prince"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.87,
            Y = 38.57,
            X = -121.42,
            Country = @"US",
            Name = @"Sacramento"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.85,
            Y = 29.63,
            X = 52.57,
            Country = @"Iran",
            Name = @"Shiraz"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.85,
            Y = -36.89,
            X = 174.8,
            Country = @"New Zealand",
            Name = @"Auckland"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.85,
            Y = 35.11,
            X = -90,
            Country = @"US",
            Name = @"Memphis"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.84,
            Y = 33.61,
            X = 73.04,
            Country = @"Pakistan",
            Name = @"Rawalpindi"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.83,
            Y = 36.79,
            X = 118.06,
            Country = @"China",
            Name = @"Zibo"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.83,
            Y = 50.06,
            X = 19.95,
            Country = @"Poland",
            Name = @"Krakow"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.82,
            Y = 43.21,
            X = -77.64,
            Country = @"US",
            Name = @"Rochester"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.82,
            Y = 45.37,
            X = -75.65,
            Country = @"Canada",
            Name = @"Ottawa"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.81,
            Y = 44.46,
            X = 8.92,
            Country = @"Italy",
            Name = @"Genova"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.81,
            Y = -3.12,
            X = -60.01,
            Country = @"Brazil",
            Name = @"Manaus"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.8,
            Y = 9.52,
            X = -12.8,
            Country = @"Guinea",
            Name = @"Conakry"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.8,
            Y = 25.38,
            X = 68.37,
            Country = @"Pakistan",
            Name = @"Hyderabad"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.8,
            Y = 36.88,
            X = -76.27,
            Country = @"US",
            Name = @"Norfolk"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.8,
            Y = 53.08,
            X = 8.86,
            Country = @"Germany",
            Name = @"Bremen"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.79,
            Y = 53.57,
            X = -113.27,
            Country = @"Canada",
            Name = @"Edmonton"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.79,
            Y = -3,
            X = 104.83,
            Country = @"Indonesia",
            Name = @"Palembang"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.79,
            Y = 49.84,
            X = 24.03,
            Country = @"Ukraine",
            Name = @"Lvov"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.78,
            Y = 22.38,
            X = 114.23,
            Country = @"UK",
            Name = @"Kowloon"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.78,
            Y = 37,
            X = 35.32,
            Country = @"Turkey",
            Name = @"Adana"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.77,
            Y = 51.9,
            X = 4.3,
            Country = @"Netherlands",
            Name = @"The Hague"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.77,
            Y = 18.02,
            X = -76.8,
            Country = @"Jamaica",
            Name = @"Kingston"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.76,
            Y = 21.32,
            X = -157.81,
            Country = @"US",
            Name = @"Honolulu"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.75,
            Y = 50.62,
            X = 5.57,
            Country = @"Belgium",
            Name = @"Liege"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.74,
            Y = 34.67,
            X = 112.36,
            Country = @"China",
            Name = @"Luoyang"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.74,
            Y = 35.49,
            X = -97.53,
            Country = @"US",
            Name = @"Oklahoma City"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.72,
            Y = 38.13,
            X = 13.4,
            Country = @"Italy",
            Name = @"Palermo"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.72,
            Y = 59.93,
            X = 10.72,
            Country = @"Norway",
            Name = @"Oslo"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.71,
            Y = 40.63,
            X = 22.8,
            Country = @"Greece",
            Name = @"ThessaXiki"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.71,
            Y = 57.75,
            X = 12,
            Country = @"Sweden",
            Name = @"Goteborg"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.71,
            Y = -5.19,
            X = 119.72,
            Country = @"Indonesia",
            Name = @"Vjuag Padang"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.71,
            Y = 24.14,
            X = 120.67,
            Country = @"Taiwan",
            Name = @"T`ai-chung"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.71,
            Y = 53.37,
            X = -1.46,
            Country = @"UK",
            Name = @"Sheffield"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.7,
            Y = -25.22,
            X = -57.67,
            Country = @"Paraguay",
            Name = @"Asuncion"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.7,
            Y = 45.81,
            X = 15.96,
            Country = @"Croatia",
            Name = @"Zagreb"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.7,
            Y = 11.56,
            X = 104.91,
            Country = @"Cambodia",
            Name = @"Phnom Penh"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.7,
            Y = 51.35,
            X = 12.4,
            Country = @"Germany",
            Name = @"Leipzig"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.69,
            Y = 9.99,
            X = 76.52,
            Country = @"India",
            Name = @"Cochin"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.69,
            Y = -33.88,
            X = 25.48,
            Country = @"South Africa",
            Name = @"Port Elizabeth"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.69,
            Y = 54.59,
            X = -5.91,
            Country = @"UK",
            Name = @"Belfast"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.68,
            Y = -32.9,
            X = -71.3,
            Country = @"Chile",
            Name = @"Valparaiso"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.68,
            Y = -36.88,
            X = -72.85,
            Country = @"Chile",
            Name = @"Concepcion"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.68,
            Y = 12.15,
            X = -86.27,
            Country = @"Nicaragua",
            Name = @"Managua"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.68,
            Y = 40.69,
            X = -111.89,
            Country = @"US",
            Name = @"Salt Lake City"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.67,
            Y = 47,
            X = 28.83,
            Country = @"Moldova",
            Name = @"Kishinev"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.67,
            Y = 9.93,
            X = -84.08,
            Country = @"Costa Rica",
            Name = @"San Jose"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.67,
            Y = 51.03,
            X = -114.05,
            Country = @"Canada",
            Name = @"Calgary"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.67,
            Y = 51.05,
            X = 13.71,
            Country = @"Germany",
            Name = @"Dresden"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.66,
            Y = 23.17,
            X = 120.23,
            Country = @"Taiwan",
            Name = @"T`ai-nan"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.66,
            Y = -18.87,
            X = 47.5,
            Country = @"Madagascar",
            Name = @"Antananarivo"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.65,
            Y = 43.13,
            X = 131.96,
            Country = @"Russia",
            Name = @"Vladivostok"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.65,
            Y = -32.9,
            X = -68.83,
            Country = @"Argentina",
            Name = @"Mendoza"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.65,
            Y = 3.87,
            X = 11.51,
            Country = @"Cameroon",
            Name = @"Yaounde"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.65,
            Y = 12.65,
            X = -7.99,
            Country = @"Mali",
            Name = @"Bamako"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.65,
            Y = 22.84,
            X = 89.56,
            Country = @"Bangladesh",
            Name = @"Khulna"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.64,
            Y = 30.33,
            X = -81.66,
            Country = @"US",
            Name = @"Jacksonville"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.64,
            Y = 43.78,
            X = 11.21,
            Country = @"Italy",
            Name = @"Firenze"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.64,
            Y = 44.84,
            X = -0.6,
            Country = @"France",
            Name = @"Bordeaux"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.64,
            Y = 51.12,
            X = 17.04,
            Country = @"Poland",
            Name = @"Wroclaw"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.63,
            Y = 37.31,
            X = -121.85,
            Country = @"US",
            Name = @"San Jose"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.63,
            Y = 8.95,
            X = -79.4,
            Country = @"Panama",
            Name = @"Panama"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.63,
            Y = 35.75,
            X = -0.52,
            Country = @"Algeria",
            Name = @"Oran"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.63,
            Y = 51.5,
            X = -3.15,
            Country = @"UK",
            Name = @"Cardiff"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.63,
            Y = 55.88,
            X = -3.3,
            Country = @"UK",
            Name = @"Edinburgh"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.63,
            Y = 49.92,
            X = -97.12,
            Country = @"Canada",
            Name = @"Winnipeg"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.63,
            Y = 52.32,
            X = 104.25,
            Country = @"Russia",
            Name = @"Irkutsk"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.62,
            Y = 42.88,
            X = 74.77,
            Country = @"Kyrgyzstan",
            Name = @"Frunze"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.62,
            Y = 10.18,
            X = -68,
            Country = @"Venezuela",
            Name = @"Valencia"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.62,
            Y = 30.5,
            X = 47.76,
            Country = @"Iraq",
            Name = @"Al Basra"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.61,
            Y = 49.88,
            X = 73.2,
            Country = @"Kazakhstan",
            Name = @"Karaganda"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.6,
            Y = 48.53,
            X = 135.07,
            Country = @"Russia",
            Name = @"Khabarovsk"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.6,
            Y = 17.75,
            X = 83.33,
            Country = @"India",
            Name = @"Vishakhapatnam"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.6,
            Y = -2.5,
            X = -44.43,
            Country = @"Brazil",
            Name = @"Sao Luis"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.6,
            Y = 53.7,
            X = 87.17,
            Country = @"Russia",
            Name = @"Novokuznetsk"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.6,
            Y = 2.04,
            X = 45.34,
            Country = @"Somalia",
            Name = @"Muqdisho"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.6,
            Y = 46.8,
            X = -71.24,
            Country = @"Canada",
            Name = @"Quebec"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.59,
            Y = 28,
            X = -82.59,
            Country = @"US",
            Name = @"Tampa"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.59,
            Y = 38.63,
            X = 68.9,
            Country = @"Tajikistan",
            Name = @"Dushanfe"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.59,
            Y = -4.29,
            X = 15.29,
            Country = @"Congo",
            Name = @"Brazzaville"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.59,
            Y = 31.63,
            X = 74.87,
            Country = @"India",
            Name = @"Amritsar"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.58,
            Y = 54.69,
            X = 25.28,
            Country = @"Lithuania",
            Name = @"Vilnius"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.57,
            Y = 36.34,
            X = 43.14,
            Country = @"Iraq",
            Name = @"Mosul"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.57,
            Y = 41.65,
            X = -0.88,
            Country = @"Spain",
            Name = @"Zaragoza"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.57,
            Y = 50.73,
            X = 7.1,
            Country = @"Germany",
            Name = @"Bonn"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.57,
            Y = 51.51,
            X = 7.47,
            Country = @"Germany",
            Name = @"Dortmund"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.55,
            Y = 14.1,
            X = -87.2,
            Country = @"Honduras",
            Name = @"Tegucigalpa"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.55,
            Y = 21.43,
            X = 39.81,
            Country = @"Saudi Arabia",
            Name = @"Mecca"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.55,
            Y = 47.93,
            X = 106.91,
            Country = @"Mongolia",
            Name = @"Ulaanbaatar"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.54,
            Y = -15.43,
            X = 28.17,
            Country = @"Zambia",
            Name = @"Lusaka"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.54,
            Y = -11.68,
            X = 27.55,
            Country = @"Zaire",
            Name = @"Lumumbashi"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.54,
            Y = 11.92,
            X = 8.52,
            Country = @"Nigeria",
            Name = @"Kano"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.54,
            Y = 31.15,
            X = -8,
            Country = @"Morocco",
            Name = @"Marrakech"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.54,
            Y = 34.04,
            X = -5,
            Country = @"Morocco",
            Name = @"Fes"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.54,
            Y = 43.6,
            X = 1.44,
            Country = @"France",
            Name = @"Toulouse"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.53,
            Y = 15.62,
            X = 32.48,
            Country = @"Sudan",
            Name = @"Omdurman"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.53,
            Y = 8.38,
            X = -12.91,
            Country = @"Sierra Leone",
            Name = @"Freetown"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.53,
            Y = 21.98,
            X = 96.08,
            Country = @"Burma",
            Name = @"Mandalay"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.52,
            Y = 51.49,
            X = 6.78,
            Country = @"Germany",
            Name = @"Duisburg"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.51,
            Y = 46.25,
            X = 48,
            Country = @"Russia",
            Name = @"Astrakhan"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.51,
            Y = -5.78,
            X = -35.25,
            Country = @"Brazil",
            Name = @"Natal"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.5,
            Y = 10.07,
            X = -69.34,
            Country = @"Venezuela",
            Name = @"Barquisimeto"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.49,
            Y = 5.35,
            X = 100.55,
            Country = @"Malaysia",
            Name = @"George Town"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.49,
            Y = 31.77,
            X = 35.23,
            Country = @"Israel",
            Name = @"Jerusalem"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.48,
            Y = 59.28,
            X = 24.75,
            Country = @"Estonia",
            Name = @"Tallinn"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.48,
            Y = 35.21,
            X = -80.84,
            Country = @"US",
            Name = @"Charlotte"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.47,
            Y = 6.52,
            X = -10.77,
            Country = @"Liberia",
            Name = @"Monrovia"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.47,
            Y = 4.37,
            X = 18.56,
            Country = @"Cent Af Rep",
            Name = @"Bangui"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.47,
            Y = 47.22,
            X = -1.56,
            Country = @"France",
            Name = @"Nantes"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.47,
            Y = 51.05,
            X = 3.74,
            Country = @"Belgium",
            Name = @"Gent"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.47,
            Y = 68.96,
            X = 33.09,
            Country = @"Russia",
            Name = @"Murmansk"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.46,
            Y = 0.32,
            X = 32.58,
            Country = @"Uganda",
            Name = @"Kampala"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.45,
            Y = 42,
            X = 21.53,
            Country = @"Macedonia",
            Name = @"Skopje"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.45,
            Y = 32.88,
            X = 129.86,
            Country = @"Japan",
            Name = @"Nagasaki"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.45,
            Y = -16.4,
            X = -71.52,
            Country = @"Peru",
            Name = @"Arequipa"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.45,
            Y = 49.2,
            X = 16.62,
            Country = @"Czechia",
            Name = @"Brno"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.44,
            Y = 12.48,
            X = -1.67,
            Country = @"Burkina Faso",
            Name = @"Ouagadouou"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.44,
            Y = -4.02,
            X = 39.67,
            Country = @"Kenya",
            Name = @"Mombasa"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.44,
            Y = 32.04,
            X = 20.31,
            Country = @"Libya",
            Name = @"Banghazi"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.44,
            Y = -17.79,
            X = -63.2,
            Country = @"Bolivia",
            Name = @"Santa Cruz de La Sierra"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.43,
            Y = 48.27,
            X = 17.27,
            Country = @"Slovakia",
            Name = @"Bratislava"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.43,
            Y = 15.36,
            X = 44.21,
            Country = @"Yemen",
            Name = @"Sanaa"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.43,
            Y = 22.24,
            X = -97.84,
            Country = @"Mexico",
            Name = @"Tampico"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.43,
            Y = 34.73,
            X = 36.72,
            Country = @"Syria",
            Name = @"Homs"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.42,
            Y = 45.42,
            X = 12.37,
            Country = @"Italy",
            Name = @"Venezia"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.42,
            Y = 64.52,
            X = 40.65,
            Country = @"Russia",
            Name = @"Arkhangelsk"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.41,
            Y = -20.2,
            X = 28.71,
            Country = @"Zimbabwe",
            Name = @"Bulawayo"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.41,
            Y = -33,
            X = 151.91,
            Country = @"Australia",
            Name = @"Newcastle"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.41,
            Y = 7.08,
            X = 125.61,
            Country = @"Philippines",
            Name = @"Davao"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.4,
            Y = 6.28,
            X = 1.35,
            Country = @"Togo",
            Name = @"Lome"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.4,
            Y = 13.6,
            X = 2.08,
            Country = @"Niger",
            Name = @"Niamey"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.4,
            Y = 20.82,
            X = -89.55,
            Country = @"Mexico",
            Name = @"Merida"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.4,
            Y = 37.95,
            X = 58.39,
            Country = @"Turkmenistan",
            Name = @"Ashkhabad"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.4,
            Y = 48.58,
            X = 7.77,
            Country = @"France",
            Name = @"Strasbourg"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.39,
            Y = 19.01,
            X = -96.08,
            Country = @"Mexico",
            Name = @"Veracruz"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.39,
            Y = 28.56,
            X = -105.97,
            Country = @"Mexico",
            Name = @"Chihuaha"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.39,
            Y = 20.86,
            X = 106.68,
            Country = @"Vietnam",
            Name = @"Haiphong"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.38,
            Y = 18,
            X = 102.68,
            Country = @"Laos",
            Name = @"Vientiane"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.37,
            Y = 10.64,
            X = -61.49,
            Country = @"Trinidad",
            Name = @"Port of Spain"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.37,
            Y = 39.66,
            X = 66.95,
            Country = @"Uzbekistan",
            Name = @"Samarkand"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.35,
            Y = -41.21,
            X = 175.14,
            Country = @"New Zealand",
            Name = @"Wellington"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.35,
            Y = -7.93,
            X = -79,
            Country = @"Peru",
            Name = @"Trujillo"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.34,
            Y = 43.87,
            X = 18.43,
            Country = @"Bosnia",
            Name = @"Sarajevo"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.34,
            Y = 48.3,
            X = 14.29,
            Country = @"Austria",
            Name = @"Linz"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.33,
            Y = 40.72,
            X = -74.2,
            Country = @"US",
            Name = @"Newark"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.33,
            Y = 29.96,
            X = 32.56,
            Country = @"Egypt",
            Name = @"Suez"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.33,
            Y = 47.06,
            X = 15.43,
            Country = @"Austria",
            Name = @"Graz"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.32,
            Y = 12.86,
            X = 45.18,
            Country = @"Yemen",
            Name = @"Aden"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.32,
            Y = -33.03,
            X = 27.9,
            Country = @"South Africa",
            Name = @"East Xdon"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.32,
            Y = -43.55,
            X = 172.68,
            Country = @"New Zealand",
            Name = @"Christchurch"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.32,
            Y = 27.71,
            X = 85.31,
            Country = @"Nepal",
            Name = @"Kathmandu"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.31,
            Y = 12.95,
            X = 75.16,
            Country = @"India",
            Name = @"Mangalore"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.31,
            Y = 34.75,
            X = 10.76,
            Country = @"Tunisia",
            Name = @"Sfax"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.31,
            Y = 25.2,
            X = 51.5,
            Country = @"Qatar",
            Name = @"Doha"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.3,
            Y = -0.92,
            X = 100.48,
            Country = @"Indonesia",
            Name = @"Padang"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.3,
            Y = 44.63,
            X = -63.58,
            Country = @"Canada",
            Name = @"Halifax"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.3,
            Y = 16.97,
            X = -99.93,
            Country = @"Mexico",
            Name = @"ACapulco"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.3,
            Y = 12.1,
            X = 15.24,
            Country = @"Chad",
            Name = @"N'Djamena"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.3,
            Y = 39.23,
            X = 9.11,
            Country = @"Italy",
            Name = @"Cagliari"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.3,
            Y = 46.95,
            X = 7.45,
            Country = @"Switzerland",
            Name = @"Bern"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.29,
            Y = -19.77,
            X = 35.02,
            Country = @"Mozambique",
            Name = @"Beira"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.29,
            Y = -4.64,
            X = 12.06,
            Country = @"Congo",
            Name = @"Pointe Noire"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.29,
            Y = 40.75,
            X = 140.67,
            Country = @"Japan",
            Name = @"Aomori"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.29,
            Y = 24.43,
            X = 39.7,
            Country = @"Saudi Arabia",
            Name = @"Al Madinah"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.29,
            Y = -31.62,
            X = -60.7,
            Country = @"Argentina",
            Name = @"Santa Fe"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.29,
            Y = -5.89,
            X = 22.4,
            Country = @"Zaire",
            Name = @"Kananga"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.28,
            Y = 18.03,
            X = -15.78,
            Country = @"Mauritania",
            Name = @"Nouakchott"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.28,
            Y = 15.33,
            X = 38.97,
            Country = @"Eritrea",
            Name = @"Asmara"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.28,
            Y = 29.6,
            X = 60.83,
            Country = @"Iran",
            Name = @"Zahedan"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.28,
            Y = -6.62,
            X = -79.83,
            Country = @"Peru",
            Name = @"Chiclayo"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.28,
            Y = -15.55,
            X = -56.05,
            Country = @"Brazil",
            Name = @"Cuiaba"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.28,
            Y = 0.52,
            X = 25.2,
            Country = @"Zaire",
            Name = @"Kisangani"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.27,
            Y = 53.2,
            X = 158.72,
            Country = @"Russia",
            Name = @"Petropavloski-Kamchatskiy"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.27,
            Y = -3.27,
            X = 29.53,
            Country = @"Burundi",
            Name = @"Bujumbura"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.27,
            Y = -35.35,
            X = 149.04,
            Country = @"Australia",
            Name = @"Canberra"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.27,
            Y = 28.57,
            X = 77.22,
            Country = @"India",
            Name = @"New Delhi"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.26,
            Y = 49.32,
            X = 0.22,
            Country = @"France",
            Name = @"Le Havre"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.26,
            Y = 48.65,
            X = -123.57,
            Country = @"Canada",
            Name = @"Victoria"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.26,
            Y = 11.88,
            X = 13.26,
            Country = @"Niger",
            Name = @"Maiduguri"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.26,
            Y = -12.04,
            X = -76.84,
            Country = @"Peru",
            Name = @"Callao"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.25,
            Y = -7.33,
            X = 19,
            Country = @"Zaire",
            Name = @"Kahemba"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.25,
            Y = 6.45,
            X = 7.49,
            Country = @"Nigeria",
            Name = @"Enugu"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.25,
            Y = 39.9,
            X = 41.29,
            Country = @"Turkey",
            Name = @"Erzurum"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.24,
            Y = 24.24,
            X = 54.62,
            Country = @"UAE",
            Name = @"Abu Zaby"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.24,
            Y = 5.93,
            X = -55.23,
            Country = @"SuriName",
            Name = @"Paramaribo"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.24,
            Y = -0.5,
            X = 9.49,
            Country = @"Gabon",
            Name = @"Libreville"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.24,
            Y = 60.35,
            X = 5.49,
            Country = @"Norway",
            Name = @"Bergen"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.24,
            Y = 41.32,
            X = 36.37,
            Country = @"Turkey",
            Name = @"Samsun"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.24,
            Y = 45.7,
            X = 13.93,
            Country = @"Italy",
            Name = @"Trieste"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.23,
            Y = -13.92,
            X = 33.82,
            Country = @"Malawi",
            Name = @"LiXgwe"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.23,
            Y = 31.97,
            X = 54.45,
            Country = @"Iran",
            Name = @"Yazd"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.23,
            Y = -29.15,
            X = 26.26,
            Country = @"South Africa",
            Name = @"Bloemfontein"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.23,
            Y = -2.46,
            X = -54.61,
            Country = @"Brazil",
            Name = @"Santarem"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.23,
            Y = 46.07,
            X = 14.64,
            Country = @"Slovenia",
            Name = @"Ljubljana"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.22,
            Y = 1.42,
            X = 124.88,
            Country = @"Indonesia",
            Name = @"Manado"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.22,
            Y = -8.93,
            X = -78.45,
            Country = @"Peru",
            Name = @"Chimbote"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.22,
            Y = -27.4,
            X = -58.9,
            Country = @"Argentina",
            Name = @"Resistencia"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.22,
            Y = 47.8,
            X = 13.09,
            Country = @"Austria",
            Name = @"Salzburg"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.22,
            Y = -38.73,
            X = -62.27,
            Country = @"Argentina",
            Name = @"Bahia Blanca"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.21,
            Y = -1.21,
            X = 116.86,
            Country = @"Indonesia",
            Name = @"Balikpapan"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.21,
            Y = 19.62,
            X = 37.22,
            Country = @"Sudan",
            Name = @"Bur Sudan"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.21,
            Y = 41.33,
            X = 19.83,
            Country = @"Albania",
            Name = @"Tirane"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.2,
            Y = 7.58,
            X = -72.01,
            Country = @"Venezuela",
            Name = @"San Cristobal"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.2,
            Y = 34.34,
            X = 36.01,
            Country = @"Lebanon",
            Name = @"Tripoli"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.2,
            Y = 31.6,
            X = 65.5,
            Country = @"Afghanistan",
            Name = @"Qandahar"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.2,
            Y = 23.36,
            X = -106.27,
            Country = @"Mexico",
            Name = @"Mazatlan"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.2,
            Y = -12.73,
            X = 15.78,
            Country = @"Angola",
            Name = @"Huambo"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.2,
            Y = -8.75,
            X = -63.9,
            Country = @"Brazil",
            Name = @"Porto Velho"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.2,
            Y = 52.11,
            X = -106.63,
            Country = @"Canada",
            Name = @"Saskatoon"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.2,
            Y = 33.72,
            X = 73.06,
            Country = @"Pakistan",
            Name = @"Islamabad"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.19,
            Y = 6.77,
            X = -58.17,
            Country = @"Guyana",
            Name = @"Georgetown"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.19,
            Y = 24.08,
            X = 32.95,
            Country = @"Egypt",
            Name = @"Aswan"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.19,
            Y = 62.01,
            X = 129.83,
            Country = @"Russia",
            Name = @"Yakutsk"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.19,
            Y = 50.41,
            X = -104.65,
            Country = @"Canada",
            Name = @"Regina"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.18,
            Y = 61.19,
            X = -149.17,
            Country = @"US",
            Name = @"Anchorage"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.18,
            Y = -23.83,
            X = -70.23,
            Country = @"Chile",
            Name = @"Antofagasta"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.18,
            Y = -13.6,
            X = -71.86,
            Country = @"Peru",
            Name = @"Cuzco"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.18,
            Y = -2.12,
            X = 29.99,
            Country = @"Rwanda",
            Name = @"Kigali"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.18,
            Y = 35.17,
            X = 33.39,
            Country = @"Cyprus",
            Name = @"Nicosia"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.18,
            Y = -3.75,
            X = -73.19,
            Country = @"Peru",
            Name = @"Iquitos"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.18,
            Y = 47.27,
            X = 11.35,
            Country = @"Austria",
            Name = @"Innsbruck"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.17,
            Y = 69.33,
            X = 88.1,
            Country = @"Russia",
            Name = @"Noril`sk"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.17,
            Y = -43,
            X = 147.5,
            Country = @"Australia",
            Name = @"Hobart"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.17,
            Y = 50.33,
            X = 110.75,
            Country = @"Russia",
            Name = @"Chatanga"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.17,
            Y = 16.46,
            X = 107.7,
            Country = @"Vietnam",
            Name = @"Hue"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.16,
            Y = 6.6,
            X = 2.63,
            Country = @"Benin",
            Name = @"Porto Novo"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.16,
            Y = 34.46,
            X = 62.21,
            Country = @"Afghanistan",
            Name = @"Herat"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.15,
            Y = 16.92,
            X = -96.94,
            Country = @"Mexico",
            Name = @"Oaxaca"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.15,
            Y = -9.55,
            X = 147.41,
            Country = @"Papua N Guin",
            Name = @"Port Moresby"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.15,
            Y = 38.14,
            X = 21.88,
            Country = @"Greece",
            Name = @"Patras"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.15,
            Y = 39.48,
            X = 76,
            Country = @"China",
            Name = @"Kashi"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.15,
            Y = -12.72,
            X = 13.46,
            Country = @"Angola",
            Name = @"Benguela"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.15,
            Y = 59.57,
            X = 150.78,
            Country = @"Russia",
            Name = @"Magadan"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.14,
            Y = 64.31,
            X = -21.34,
            Country = @"Iceland",
            Name = @"Reykjavik"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.14,
            Y = 55.57,
            X = 9.9,
            Country = @"Denmark",
            Name = @"Odense"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.14,
            Y = 13.18,
            X = 30.16,
            Country = @"Sudan",
            Name = @"El Obeid"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.14,
            Y = -28.66,
            X = 24.83,
            Country = @"South Africa",
            Name = @"Kimberley"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.14,
            Y = -5.81,
            X = 13.45,
            Country = @"Zaire",
            Name = @"Matadi"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.13,
            Y = 0.05,
            X = 18.46,
            Country = @"Zaire",
            Name = @"Mbandaka"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.13,
            Y = 49.74,
            X = 6.27,
            Country = @"Luxembourg",
            Name = @"Luxembourg"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.12,
            Y = -22.57,
            X = 17.1,
            Country = @"Namibia",
            Name = @"Windhoek"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.12,
            Y = 67.8,
            X = 64.33,
            Country = @"Russia",
            Name = @"Vorkuta"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.12,
            Y = 45.34,
            X = -65.65,
            Country = @"Canada",
            Name = @"Saint John"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.12,
            Y = -0.82,
            X = 9.15,
            Country = @"Gabon",
            Name = @"Port Gentil"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.12,
            Y = 11.5,
            X = 43.1,
            Country = @"Djibouti",
            Name = @"Djibouti"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.11,
            Y = -20.26,
            X = -69.91,
            Country = @"Chile",
            Name = @"Iquique"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.11,
            Y = 11.91,
            X = -15.65,
            Country = @"GuineaBissau",
            Name = @"Bissau"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.11,
            Y = -3.39,
            X = 129.31,
            Country = @"Indonesia",
            Name = @"Ambon"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.11,
            Y = -45.86,
            X = 170.5,
            Country = @"New Zealand",
            Name = @"Dunedin"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.11,
            Y = -19.3,
            X = 146.83,
            Country = @"Australia",
            Name = @"Townsville"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.11,
            Y = -29.26,
            X = 27.89,
            Country = @"Lesotho",
            Name = @"Maseru"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.1,
            Y = 46.92,
            X = -122.88,
            Country = @"US",
            Name = @"Olympia"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.1,
            Y = 13.45,
            X = -16.49,
            Country = @"Gambia",
            Name = @"Banjul"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.1,
            Y = -45.83,
            X = -67.5,
            Country = @"Argentina",
            Name = @"Comodoro Rivadavia"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.1,
            Y = -53.15,
            X = -70.8,
            Country = @"Chile",
            Name = @"Punte Arenas"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.1,
            Y = -18.23,
            X = 49.41,
            Country = @"Madagascar",
            Name = @"Toamasina"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.1,
            Y = -24.66,
            X = 25.79,
            Country = @"Botswana",
            Name = @"Gaborone"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.09,
            Y = 15.95,
            X = -16.3,
            Country = @"Senegal",
            Name = @"Saint Louis"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.09,
            Y = 27,
            X = -13.18,
            Country = @"W Sahara",
            Name = @"Laayoune"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.09,
            Y = -19.04,
            X = -65.26,
            Country = @"Bolivia",
            Name = @"Sucre"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.08,
            Y = -31.31,
            X = -57.71,
            Country = @"Uruguay",
            Name = @"Salto"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.08,
            Y = 42.5,
            X = 19.4,
            Country = @"Montenegro",
            Name = @"Podgorica"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.08,
            Y = -41.48,
            X = -73,
            Country = @"Chile",
            Name = @"Puerto Montt"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.08,
            Y = 29.65,
            X = 91.13,
            Country = @"China",
            Name = @"Lhasa"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.07,
            Y = 61.15,
            X = 47,
            Country = @"Russia",
            Name = @"Kotlas"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.07,
            Y = -12.7,
            X = 130.99,
            Country = @"Australia",
            Name = @"Darwin"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.07,
            Y = 1.5,
            X = 110.43,
            Country = @"Malaysia",
            Name = @"Kuching"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.06,
            Y = -23.29,
            X = 44.02,
            Country = @"Madagascar",
            Name = @"Toliara"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.06,
            Y = -31,
            X = -71.02,
            Country = @"Chile",
            Name = @"Coquimbo"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.06,
            Y = 4.93,
            X = 114.97,
            Country = @"Brunei",
            Name = @"Bandar Seri Begawan"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.06,
            Y = -17.83,
            X = 25.88,
            Country = @"Zambia",
            Name = @"Livingstone"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.06,
            Y = -23.43,
            X = 150.48,
            Country = @"Australia",
            Name = @"Rockhampton"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.05,
            Y = 23.52,
            X = 58.63,
            Country = @"Oman",
            Name = @"Masqat"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.05,
            Y = -4.95,
            X = 30,
            Country = @"Tanzania",
            Name = @"Kigoma"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.05,
            Y = 16.96,
            X = 7.98,
            Country = @"Niger",
            Name = @"Agadez"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.05,
            Y = -10.26,
            X = 40.18,
            Country = @"Tanzania",
            Name = @"Mtwara"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.05,
            Y = -46.41,
            X = 168.45,
            Country = @"New Zealand",
            Name = @"Invercargill"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.05,
            Y = -6.18,
            X = 35.75,
            Country = @"Tanzania",
            Name = @"Dodoma"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.04,
            Y = 64.84,
            X = -147.65,
            Country = @"US",
            Name = @"Fairbanks"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.04,
            Y = 19.71,
            X = -155.07,
            Country = @"US",
            Name = @"Hilo"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.04,
            Y = 4.92,
            X = -52.4,
            Country = @"Fr Guiana",
            Name = @"Cayenne"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.04,
            Y = -26.3,
            X = 31.19,
            Country = @"Swaziland",
            Name = @"Mbabne"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.04,
            Y = -16.85,
            X = 145.71,
            Country = @"Australia",
            Name = @"Cairns"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.03,
            Y = 3.64,
            X = 8.82,
            Country = @"Eq Guinea",
            Name = @"Malabo"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.03,
            Y = 50.28,
            X = -66.4,
            Country = @"Canada",
            Name = @"Sept-Iles"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.03,
            Y = -41.3,
            X = 173.27,
            Country = @"New Zealand",
            Name = @"Nelson"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.03,
            Y = 16.76,
            X = -3.01,
            Country = @"Mali",
            Name = @"Tombouctoo"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.02,
            Y = 58.39,
            X = -134.13,
            Country = @"US",
            Name = @"Juneau"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.02,
            Y = -23.1,
            X = 14.62,
            Country = @"Namibia",
            Name = @"Walvis Bay"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.02,
            Y = 54.42,
            X = -130.05,
            Country = @"Canada",
            Name = @"Prince Rupert"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.02,
            Y = 20.9,
            X = -16.83,
            Country = @"Mauritania",
            Name = @"Nouadnibou"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.02,
            Y = 27.2,
            X = 2.53,
            Country = @"Algeria",
            Name = @"In Salah"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.02,
            Y = -32.04,
            X = 115.93,
            Country = @"Australia",
            Name = @"Fremantle"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.02,
            Y = 68.35,
            X = 17.3,
            Country = @"Norway",
            Name = @"Narvik"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.01,
            Y = 62.52,
            X = -114.06,
            Country = @"Canada",
            Name = @"Yellowknife"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.01,
            Y = 17.12,
            X = -88.8,
            Country = @"Belize",
            Name = @"Belmopan"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.01,
            Y = 70.39,
            X = 23.91,
            Country = @"Norway",
            Name = @"Hammerfest"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.01,
            Y = 64.27,
            X = -51.58,
            Country = @"Greenland",
            Name = @"Godthab"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.01,
            Y = 60.65,
            X = -135.01,
            Country = @"Canada",
            Name = @"Whitehorse"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.01,
            Y = 59.33,
            X = 143.25,
            Country = @"Russia",
            Name = @"Okhotsk"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.01,
            Y = 52.05,
            X = 113.58,
            Country = @"Russia",
            Name = @"Chita"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.01,
            Y = 55.88,
            X = 37.75,
            Country = @"Russia",
            Name = @"Druzba"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0.01,
            Y = 53.31,
            X = -60.55,
            Country = @"Canada",
            Name = @"Goose Bay"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = true,
            Population = 0.01,
            Y = 27.44,
            X = 89.67,
            Country = @"Bhutan",
            Name = @"Thimbu"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0,
            Y = 78.2,
            X = 15.66,
            Country = @"Norway",
            Name = @"Xgyearbyen"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0,
            Y = 30.14,
            X = 9.82,
            Country = @"Libya",
            Name = @"Ghadamis"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0,
            Y = 71.7,
            X = 128.75,
            Country = @"Russia",
            Name = @"Tiksi"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0,
            Y = 77.67,
            X = -69,
            Country = @"Greenland",
            Name = @"Thule"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0,
            Y = 22.83,
            X = 5.55,
            Country = @"Algeria",
            Name = @"Tamanrasset"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0,
            Y = 60.12,
            X = -149.45,
            Country = @"US",
            Name = @"Seward"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0,
            Y = 70.53,
            X = -23,
            Country = @"Greenland",
            Name = @"Scoresbyund"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0,
            Y = 66.57,
            X = 66.58,
            Country = @"Russia",
            Name = @"Salekhard"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0,
            Y = 64.59,
            X = -165.27,
            Country = @"US",
            Name = @"Nome"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0,
            Y = 68.27,
            X = -133.67,
            Country = @"Canada",
            Name = @"Inuvik"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0,
            Y = 67.35,
            X = 86.55,
            Country = @"Russia",
            Name = @"Igarka"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0,
            Y = 69.38,
            X = -53.63,
            Country = @"Greenland",
            Name = @"Godhavn"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0,
            Y = 58.71,
            X = -94.18,
            Country = @"Canada",
            Name = @"Churchill"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0,
            Y = 2.75,
            X = -60.5,
            Country = @"Brazil",
            Name = @"Boa Vista"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0,
            Y = -15.75,
            X = 133.22,
            Country = @"Australia",
            Name = @"Birdum"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0,
            Y = 65.67,
            X = -37.31,
            Country = @"Greenland",
            Name = @"Angmagssalik"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0,
            Y = 64.4,
            X = 177.13,
            Country = @"Russia",
            Name = @"Anadyr"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0,
            Y = 47.81,
            X = 97,
            Country = @"Mongolia",
            Name = @"Uliastay"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0,
            Y = -15.05,
            X = 40.7,
            Country = @"Mozambique",
            Name = @"Mocambique"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0,
            Y = -51.71,
            X = -69.41,
            Country = @"Argentina",
            Name = @"Rio Gallegos"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0,
            Y = 27.7,
            X = -8.16,
            Country = @"Algeria",
            Name = @"Tindouf"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0,
            Y = 25.91,
            X = 13.91,
            Country = @"Libya",
            Name = @"Murzuq"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0,
            Y = 21.76,
            X = 31.28,
            Country = @"Sudan",
            Name = @"Wadi Halfa"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0,
            Y = -23.63,
            X = 133.93,
            Country = @"Australia",
            Name = @"Alice Springs"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0,
            Y = 46.96,
            X = 142.75,
            Country = @"Russia",
            Name = @"Yuzhno-Sakhalinsk"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0,
            Y = 50.08,
            X = 45.53,
            Country = @"Russia",
            Name = @"Nikolayevsk"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0,
            Y = 67.58,
            X = 133.41,
            Country = @"Russia",
            Name = @"Verkhoyansk"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0,
            Y = 54.86,
            X = -67.01,
            Country = @"Canada",
            Name = @"Schefferville"
        });
        this.Add(new WorldCitiesItem()
        {
            Capital = false,
            Population = 0,
            Y = 51.33,
            X = -80.73,
            Country = @"Canada",
            Name = @"Moosonee"
        });
    }
}
