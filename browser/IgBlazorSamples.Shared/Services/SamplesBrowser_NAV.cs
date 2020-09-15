using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infragistics.Samples.Shared.Services
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

        public string CurrentPath { get; set; }

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

        private string _CurrentSample = "";
        public string CurrentSample
        {
            get { return _CurrentSample; }
            set { _CurrentSample = value; NotifyPropertyChanged(); }
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
                        Console.WriteLine("SB.TOC toggle " + comp.Name);
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

            Console.WriteLine("SB CheckUI " + url);

            var sampleFound = false;
            //this.IsEmbedded = !url.Contains("/samples") && url != this.NavManager.BaseUri;
            
            if (url.EndsWith("/home") || url.EndsWith("/index") || url.EndsWith("/samples"))
            {
                this.CurrentPath = url;
                this.CurrentSample = this.HomeTitle;
                this.CurrentHelpTopic = "";
            }
            else
            {
                foreach (var group in TOC.Groups)
                {
                    foreach (var comp in group.Components)
                    {
                        foreach (var sample in comp.Samples)
                        {
                            if (url.Contains(sample.Route))
                            {
                                sampleFound = true;
                                this.CurrentPath = url;
                                this.CurrentSample = sample.Component + " - " + sample.Name;
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
                    this.CurrentPath = url;
                    this.CurrentSample = "";
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