using System.Collections.Generic;

namespace Infragistics.Samples
{
    public class UsState
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Region { get; set; }
    }

    public static class UsStatesData
    {
        public static readonly List<UsState> States = new List<UsState>
        {
            new UsState { Id = "CT", Name = "Connecticut", Region = "New England" },
            new UsState { Id = "ME", Name = "Maine", Region = "New England" },
            new UsState { Id = "MA", Name = "Massachusetts", Region = "New England" },
            new UsState { Id = "NH", Name = "New Hampshire", Region = "New England" },
            new UsState { Id = "RI", Name = "Rhode Island", Region = "New England" },
            new UsState { Id = "VT", Name = "Vermont", Region = "New England" },
            new UsState { Id = "NJ", Name = "New Jersey", Region = "Mid-Atlantic" },
            new UsState { Id = "NY", Name = "New York", Region = "Mid-Atlantic" },
            new UsState { Id = "PA", Name = "Pennsylvania", Region = "Mid-Atlantic" },
            new UsState { Id = "IL", Name = "Illinois", Region = "East North Central" },
            new UsState { Id = "IN", Name = "Indiana", Region = "East North Central" },
            new UsState { Id = "MI", Name = "Michigan", Region = "East North Central" },
            new UsState { Id = "OH", Name = "Ohio", Region = "East North Central" },
            new UsState { Id = "WI", Name = "Wisconsin", Region = "East North Central" },
            new UsState { Id = "IA", Name = "Iowa", Region = "West North Central" },
            new UsState { Id = "KS", Name = "Kansas", Region = "West North Central" },
            new UsState { Id = "MN", Name = "Minnesota", Region = "West North Central" },
            new UsState { Id = "MO", Name = "Missouri", Region = "West North Central" },
            new UsState { Id = "NE", Name = "Nebraska", Region = "West North Central" },
            new UsState { Id = "ND", Name = "North Dakota", Region = "West North Central" },
            new UsState { Id = "SD", Name = "South Dakota", Region = "West North Central" },
            new UsState { Id = "DE", Name = "Delaware", Region = "South Atlantic" },
            new UsState { Id = "DC", Name = "District of Columbia", Region = "South Atlantic" },
            new UsState { Id = "FL", Name = "Florida", Region = "South Atlantic" },
            new UsState { Id = "GA", Name = "Georgia", Region = "South Atlantic" },
            new UsState { Id = "MD", Name = "Maryland", Region = "South Atlantic" },
            new UsState { Id = "NC", Name = "North Carolina", Region = "South Atlantic" },
            new UsState { Id = "SC", Name = "South Carolina", Region = "South Atlantic" },
            new UsState { Id = "VA", Name = "Virginia", Region = "South Atlantic" },
            new UsState { Id = "WV", Name = "West Virginia", Region = "South Atlantic" },
            new UsState { Id = "AL", Name = "Alabama", Region = "East South Central" },
            new UsState { Id = "KY", Name = "Kentucky", Region = "East South Central" },
            new UsState { Id = "MS", Name = "Mississippi", Region = "East South Central" },
            new UsState { Id = "TN", Name = "Tennessee", Region = "East South Central" },
            new UsState { Id = "AR", Name = "Arkansas", Region = "West South Central" },
            new UsState { Id = "LA", Name = "Louisiana", Region = "West South Central" },
            new UsState { Id = "OK", Name = "Oklahoma", Region = "West South Central" },
            new UsState { Id = "TX", Name = "Texas", Region = "West South Central" },
            new UsState { Id = "AZ", Name = "Arizona", Region = "Mountain" },
            new UsState { Id = "CO", Name = "Colorado", Region = "Mountain" },
            new UsState { Id = "ID", Name = "Idaho", Region = "Mountain" },
            new UsState { Id = "MT", Name = "Montana", Region = "Mountain" },
            new UsState { Id = "NV", Name = "Nevada", Region = "Mountain" },
            new UsState { Id = "NM", Name = "New Mexico", Region = "Mountain" },
            new UsState { Id = "UT", Name = "Utah", Region = "Mountain" },
            new UsState { Id = "WY", Name = "Wyoming", Region = "Mountain" },
            new UsState { Id = "AK", Name = "Alaska", Region = "Pacific" },
            new UsState { Id = "CA", Name = "California", Region = "Pacific" },
            new UsState { Id = "HI", Name = "Hawaii", Region = "Pacific" },
            new UsState { Id = "OR", Name = "Oregon", Region = "Pacific" },
            new UsState { Id = "WA", Name = "Washington", Region = "Pacific" }
        };
    }
}
