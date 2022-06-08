using System;
using System.Collections.Generic;
public class BoatSailingDataItem
{
    public double Direction{ get; set; }
    public double BoatSpeed{ get; set; }
    public double WindSpeed{ get; set; }
}
public class BoatSailingData
    : List<BoatSailingDataItem>
{
    public BoatSailingData()
    {
        this.Add(new BoatSailingDataItem()
        {
            Direction = 0,
            BoatSpeed = 70,
            WindSpeed = 90
        });
        this.Add(new BoatSailingDataItem()
        {
            Direction = 45,
            BoatSpeed = 35,
            WindSpeed = 65
        });
        this.Add(new BoatSailingDataItem()
        {
            Direction = 90,
            BoatSpeed = 25,
            WindSpeed = 45
        });
        this.Add(new BoatSailingDataItem()
        {
            Direction = 135,
            BoatSpeed = 15,
            WindSpeed = 25
        });
        this.Add(new BoatSailingDataItem()
        {
            Direction = 180,
            BoatSpeed = 0,
            WindSpeed = 0
        });
        this.Add(new BoatSailingDataItem()
        {
            Direction = 225,
            BoatSpeed = 15,
            WindSpeed = 25
        });
        this.Add(new BoatSailingDataItem()
        {
            Direction = 270,
            BoatSpeed = 25,
            WindSpeed = 45
        });
        this.Add(new BoatSailingDataItem()
        {
            Direction = 315,
            BoatSpeed = 35,
            WindSpeed = 65
        });
        this.Add(new BoatSailingDataItem()
        {
            Direction = 360,
            BoatSpeed = 70,
            WindSpeed = 90
        });
    }
}
