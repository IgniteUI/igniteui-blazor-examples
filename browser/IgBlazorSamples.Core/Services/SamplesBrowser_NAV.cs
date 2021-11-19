using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infragistics.Samples.Core
{
    public partial class SampleBrowser
    {
        public string AppBaseUri { get; set; }
        public string AppHomeUri { get; set; }

        private string _AppName = "Blazor Samples";
        public string AppName
        {
            get { return _AppName; }
            set { _AppName = value; NotifyPropertyChanged(); }
        }

        public string CurrentSamplePath { get; set; }

        private readonly string DefaultHelpTopic = "general-getting-started.html";
        private string CurrentHelpTopic = "";
        private string _CurrentHelpUrl = "";
        public string CurrentHelpUrl
        {
            get { return _CurrentHelpUrl; }
            set { _CurrentHelpUrl = value; NotifyPropertyChanged(); }
        }

        private string _HomeTitle = "";
        public string HomeTitle
        {
            get { return _HomeTitle; }
            set { _HomeTitle = value; NotifyPropertyChanged(); }
        }

        private string _CurrentSampleTitle = "";
        public string CurrentSampleTitle
        {
            get { return _CurrentSampleTitle; }
            set { _CurrentSampleTitle = value; NotifyPropertyChanged(); }
        }

        private string _CurrentComponent = "";
        public string CurrentComponent
        {
            get { return _CurrentComponent; }
            set { _CurrentComponent = value; NotifyPropertyChanged(); }
        }

        private bool _IsEmbedded = false;
        public bool IsEmbedded
        {
            get { return _IsEmbedded; }
            set { _IsEmbedded = value; NotifyPropertyChanged(); }
        }

        private bool _IsHostingOnStaging = true;
        public bool IsHostingOnStaging
        {
            get { return _IsHostingOnStaging; }
            set { _IsHostingOnStaging = value; NotifyPropertyChanged(); }
        }

        public void ToggleComponent(string name)
        {
            if (this.IsLoading) return;

            foreach (var group in TOC.Groups)
            {
                foreach (var comp in group.Components)
                {
                    if (comp.Name == name) {
                        comp.IsExpanded = !comp.IsExpanded;
                        var toggleState = comp.IsExpanded ? "on" : "off";
                        //Console.WriteLine("SB.TOC toggle '" + comp.Name + "' " + toggleState);
                        return;
                    }
                }
            }
        }

        public async Task CheckUIAsync(string url)
        {
            CheckUI(url);
            await Task.Delay(1);
        }

        public void CheckUI(string url)
        {
            if (this.IsLoading) return;

            //Console.WriteLine("SB CheckUI " + url);

            var sampleFound = false;
            //this.IsEmbedded = !url.Contains("/samples") && url != this.NavManager.BaseUri;

            if (url.EndsWith("/home") || url.EndsWith("/index") || url.EndsWith("/samples"))
            {
                this.CurrentSamplePath = url;
                this.CurrentSampleTitle = this.HomeTitle;
                this.CurrentHelpTopic = "";
            }
            else
            {
                // using TOC to lookup sample name by a route in provided url
                foreach (var group in TOC.Groups)
                {
                    foreach (var comp in group.Components)
                    {
                        foreach (var sample in comp.Samples)
                        {
                            if (url.Contains(sample.Route))
                            {
                                sampleFound = true;
                                this.CurrentSamplePath = url;
                                this.CurrentSampleTitle = sample.Component + " - " + sample.Name;
                                //  this.CurrentHelpTopic = comp.Topic;
                                if (!this.IsEmbedded)
                                     this.SetMetadata(sample);
                                break;
                            }
                        }
                    }
                }

                if (!sampleFound)
                {
                    // Console.WriteLine("SB.NAV not found " + url);
                    this.CurrentSamplePath = url;
                    this.CurrentSampleTitle = "";
                    this.CurrentHelpTopic = "";
                    if (!this.IsEmbedded)
                        this.SetMetadata(null);
                }

                if (string.IsNullOrEmpty(this.CurrentHelpTopic))
                    this.CurrentHelpTopic = this.DefaultHelpTopic;

                this.IsHostingOnStaging = url.Contains("staging") || url.Contains("localhost");
                if (this.IsHostingOnStaging)
                    this.CurrentHelpUrl = "https://staging.infragistics.com/reactsite/components/" + this.CurrentHelpTopic;
                else
                    this.CurrentHelpUrl = "https://infragistics.com/reactsite/components/" + this.CurrentHelpTopic;

            }

        }

        public int GetCurrentSampleID() {
            var currentSampleID = 0;
            for (int i = 0; i < this.SampleRoutes.Count; i++)
            {
                var sampleRoute = this.SampleRoutes[i];
                if (CurrentSamplePath.Contains(sampleRoute)) {
                    currentSampleID = i;
                    break;
                }
            }
            return currentSampleID;
        }

        public void NavigateToNextSample() {
            var currentSampleID = GetCurrentSampleID();

            var nextSampleID = currentSampleID + 1;
            if (nextSampleID >= this.SampleRoutes.Count)
                nextSampleID = 0;

            // var nextSamplePath = NavManager.BaseUri + "samples" + this.SampleRoutes[nextSampleID];
            var nextSamplePath = this.SampleRoutes[nextSampleID];
            NavManager.NavigateTo(nextSamplePath);
        }

        public void NavigateToBackSample() {
            var currentSampleID = GetCurrentSampleID();

            var nextSampleID = currentSampleID - 1;
            if (nextSampleID < 0)
                nextSampleID = this.SampleRoutes.Count - 1;

            var nextSamplePath = this.SampleRoutes[nextSampleID];
            NavManager.NavigateTo(nextSamplePath);
        }

        // public void Init(NavigationManager navigationManager)
        // // public async Task Init(NavigationManager navigationManager)
        // {
        //     this.NavManager = navigationManager;
        //     this.NavManager.LocationChanged += this.OnLocationChanged;
        //     this.CurrentSample = this.NavManager.Uri;

        //     // await Task.Delay(1);
        //     // NavManager.LocationChanged += new EventHandler<LocationChangedEventArgs>(this.OnLocationChanged);

        // }

        // public async void OnLocationChanged(object sender, LocationChangedEventArgs arg)
        // {
        //     await Task.Delay(10);
        //     // this.CurrentSample = NavManager.ToBaseRelativePath(NavManager.BaseUri);
        //     this.CurrentSample = arg.Location;

        // }
    }

}