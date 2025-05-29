using System.Collections.Generic;

public class AnnotationDataItem
{
    public double Value { get; set; }
}

public class AnnotationData
    : List<AnnotationDataItem>
{
    public AnnotationData()
    {
        this.Add(new AnnotationDataItem()
        {
            Value = 50
        });
    }
}
