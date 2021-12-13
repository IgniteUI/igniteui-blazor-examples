using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IgniteUI.Blazor.Controls;

namespace Infragistics.Samples
{
    public class CustomFilter : IgbFilterOperand
    {
        public CustomFilter()
        {
            DisplayName = "Filter As Class";
            IsInputRequired = false;
            EditorType = EditorType.Numeric;
            FilterRequested = OnFilter;
        }

        public IgbFilterExpression OnFilter(IgbGridCustomFilterRequestedEventArgs args)
        {
            var prop = args.FilterFactory.Property(args.Column.Field);
            //Age 30 only
            return prop.IsEqualTo(30);
        }
    }
}
