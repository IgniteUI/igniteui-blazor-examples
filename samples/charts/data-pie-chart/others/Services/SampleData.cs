using System.Collections.Generic;

public class LocalDataItem
{
    public double V1 { get; set; }
    public string Category { get; set; }
}

public class LocalData
    : List<LocalDataItem>
{
    public LocalData()
    {
        this.Add(new LocalDataItem()
        {
            V1 = 100,
            Category = @"Maintenance"
        });
        this.Add(new LocalDataItem()
        {
            V1 = 40,
            Category = @"Cooling"
        });
        this.Add(new LocalDataItem()
        {
            V1 = 20,
            Category = @"Residential"
        });
        this.Add(new LocalDataItem()
        {
            V1 = 15,
            Category = @"Utilities"
        });
        this.Add(new LocalDataItem()
        {
            V1 = 10,
            Category = @"Heating"
        });
        this.Add(new LocalDataItem()
        {
            V1 = 5,
            Category = @"Lighting"
        });
        this.Add(new LocalDataItem()
        {
            V1 = 4,
            Category = @"Electric"
        });
        this.Add(new LocalDataItem()
        {
            V1 = 3,
            Category = @"Misc"
        });
    }
}
