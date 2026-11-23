using System.Collections.Generic;

namespace Infragistics.Samples
{
    public class Destination
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public string Region { get; set; }
        public string Offset { get; set; }
    }

    public static class ComboTemplatesData
    {
        public static List<Destination> Destinations = new List<Destination>
        {
            new Destination { Id = "SOF", Name = "Sofia", Country = "Bulgaria", CountryCode = "BG", Region = "Europe", Offset = "UTC+2" },
            new Destination { Id = "LON", Name = "London", Country = "United Kingdom", CountryCode = "GB", Region = "Europe", Offset = "UTC+0" },
            new Destination { Id = "PAR", Name = "Paris", Country = "France", CountryCode = "FR", Region = "Europe", Offset = "UTC+1" },
            new Destination { Id = "BER", Name = "Berlin", Country = "Germany", CountryCode = "DE", Region = "Europe", Offset = "UTC+1" },
            new Destination { Id = "MAD", Name = "Madrid", Country = "Spain", CountryCode = "ES", Region = "Europe", Offset = "UTC+1" },
            new Destination { Id = "ROM", Name = "Rome", Country = "Italy", CountryCode = "IT", Region = "Europe", Offset = "UTC+1" },
            new Destination { Id = "CPT", Name = "Cape Town", Country = "South Africa", CountryCode = "ZA", Region = "Africa", Offset = "UTC+2" },
            new Destination { Id = "NBO", Name = "Nairobi", Country = "Kenya", CountryCode = "KE", Region = "Africa", Offset = "UTC+3" },
            new Destination { Id = "CAI", Name = "Cairo", Country = "Egypt", CountryCode = "EG", Region = "Africa", Offset = "UTC+2" },
            new Destination { Id = "RAK", Name = "Marrakesh", Country = "Morocco", CountryCode = "MA", Region = "Africa", Offset = "UTC+1" },
            new Destination { Id = "TYO", Name = "Tokyo", Country = "Japan", CountryCode = "JP", Region = "Asia", Offset = "UTC+9" },
            new Destination { Id = "SIN", Name = "Singapore", Country = "Singapore", CountryCode = "SG", Region = "Asia", Offset = "UTC+8" },
            new Destination { Id = "BKK", Name = "Bangkok", Country = "Thailand", CountryCode = "TH", Region = "Asia", Offset = "UTC+7" },
            new Destination { Id = "DXB", Name = "Dubai", Country = "United Arab Emirates", CountryCode = "AE", Region = "Asia", Offset = "UTC+4" },
            new Destination { Id = "NYC", Name = "New York", Country = "United States", CountryCode = "US", Region = "Americas", Offset = "UTC-5" },
            new Destination { Id = "YTO", Name = "Toronto", Country = "Canada", CountryCode = "CA", Region = "Americas", Offset = "UTC-5" },
            new Destination { Id = "MEX", Name = "Mexico City", Country = "Mexico", CountryCode = "MX", Region = "Americas", Offset = "UTC-6" },
            new Destination { Id = "SAO", Name = "São Paulo", Country = "Brazil", CountryCode = "BR", Region = "Americas", Offset = "UTC-3" },
            new Destination { Id = "BUE", Name = "Buenos Aires", Country = "Argentina", CountryCode = "AR", Region = "Americas", Offset = "UTC-3" },
        };
    }
}
