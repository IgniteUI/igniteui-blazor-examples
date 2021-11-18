using System;
using System.Collections.Generic;
using Microsoft.JSInterop;

namespace Infragistics.Samples.Core
{
    public partial class SampleBrowser
    {
        public void SetTitle(string pageTitle) {
           JSRuntime.InvokeVoidAsync("setTitle", pageTitle);
        }

        public void SetDescription(string pageDescr) {
           JSRuntime.InvokeVoidAsync("setDescription", pageDescr);
        }

        public void SetKeywords(List<string> keywords) {
           JSRuntime.InvokeVoidAsync("setKeywords", string.Join(",", keywords));
        }

        public void SetMetadata(TocSample sample = null) {
            var defaultKeys = new List<string> { "Blazor", "Sample", "Demo", "Infragistics", "IgniteUI for Blazor", "Components" };

            if (sample == null) {
                this.SetTitle("Blazor Samples | Infragistics");
                this.SetKeywords(defaultKeys);
                this.SetDescription("Explore samples demonstrating features of IgniteUI components for Blazor");
            } else {
                var sampleTitle = sample.Name + " | Blazor Samples | Infragistics";
                var sampleDescr = "This sample demostrate how to use " + sample.Component + " with " + sample.Name;
                var sampleKeywords = new List<string>();
                sampleKeywords.Add(sample.Component);
                sampleKeywords.AddRange(sample.Name.Split(' '));
                sampleKeywords.AddRange(defaultKeys);

                this.SetTitle(sampleTitle);
                this.SetDescription(sampleDescr);
                this.SetKeywords(sampleKeywords);
            }

        }
    }

}