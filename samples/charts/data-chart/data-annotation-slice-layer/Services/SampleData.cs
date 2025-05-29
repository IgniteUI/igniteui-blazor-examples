using System.Collections.Generic;

public class AnnotationData1Item
{
    public double Value { get; set; }
    public string Label { get; set; }
}

public class AnnotationData1
    : List<AnnotationData1Item>
{
    public AnnotationData1()
    {
        this.Add(new AnnotationData1Item()
        {
            Value = 126,
            Label = @"Stock Split 3-1"
        });
        this.Add(new AnnotationData1Item()
        {
            Value = 61,
            Label = @"Stock Split 5-1"
        });
    }
}
public class AnnotationData2Item
{
    public double Value { get; set; }
    public string Label { get; set; }
}

public class AnnotationData2
    : List<AnnotationData2Item>
{
    public AnnotationData2()
    {
        this.Add(new AnnotationData2Item()
        {
            Value = 9,
            Label = @"Earnings Miss"
        });
        this.Add(new AnnotationData2Item()
        {
            Value = 179,
            Label = @"Earnings Miss"
        });
        this.Add(new AnnotationData2Item()
        {
            Value = 215,
            Label = @"Earnings Miss"
        });
    }
}
public class AnnotationData3Item
{
    public double Value { get; set; }
    public string Label { get; set; }
}

public class AnnotationData3
    : List<AnnotationData3Item>
{
    public AnnotationData3()
    {
        this.Add(new AnnotationData3Item()
        {
            Value = 155,
            Label = @"Earnings Beat"
        });
        this.Add(new AnnotationData3Item()
        {
            Value = 86,
            Label = @"Earnings Beat"
        });
        this.Add(new AnnotationData3Item()
        {
            Value = 28,
            Label = @"Earnings Miss"
        });
    }
}
