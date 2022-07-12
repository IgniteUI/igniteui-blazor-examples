using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Infragistics.Samples.Core
{
    public partial class SampleBrowser
    {
        public string IgVersion { get; set; }

        //public bool IsLoading { get; set; }
        private bool _IsLoading = true;
        public bool IsLoading
        {
            get { return _IsLoading; }
            set { _IsLoading = value; NotifyPropertyChanged(); }
        }

        public TocGroup[] SampleGroups { get { return Groups.Values.ToArray(); } }
        protected Dictionary<string, TocGroup> Groups = new Dictionary<string, TocGroup>();

        protected List<string> ComponentNames = new List<string>();
        private int _ComponentsCount = 0;
        public int ComponentsCount
        {
            get { return _ComponentsCount; }
            set { _ComponentsCount = value; NotifyPropertyChanged(); }
        }

        protected List<string> SampleRoutes = new List<string>();
        private int _SamplesCount = 0;
        public int SamplesCount
        {
            get { return _SamplesCount; }
            set { _SamplesCount = value; NotifyPropertyChanged(); }
        }

        public TOC TOC { get; set; }

        public async Task Load(TOC toc)
        {
            this.IsLoading = true;
            //Console.WriteLine("SB.TOC parsing ...");

            this.AppHomeUri = this.AppBaseUri + "/home";
            //this.AppHomeUri = this.AppBaseUri + "samples/home";
            foreach (var group in toc.Groups)
            {
                foreach (var component in group.Components)
                {
                    foreach (var sample in component.Samples)
                    {
                        //sample.Route = this.AppBaseUri + "samples" + sample.Route;
                        sample.Route = this.AppBaseUri + sample.Route;
                        sample.Component = component.Name;
                        sample.Group = group.Name;

                        if (this.SampleRoutes.Contains(sample.Route))
                            Console.WriteLine("SB.TOC duplicate: " + sample.Route.Replace("/samples", ""));
                        else
                            this.SampleRoutes.Add(sample.Route);
                    }

                    if (this.ComponentNames.Contains(component.Name))
                    {
                        Console.WriteLine("SB.TOC duplicate component: " + component.Name);
                    }
                    else
                    {
                        this.ComponentNames.Add(component.Name);
                    }
                    // comp.IsExpanded = TocFiles.Count == 1;
                    // comp.Name += " (" + comp.Samples.Length + ")";
                    // comp.Name += " Samples";
                    component.Group = group.Name;
                }

                if (this.Groups.ContainsKey(group.Name))
                {
                    Console.WriteLine("SB.TOC duplicate group " + group.Name);
                }
                else
                {
                    Groups.Add(group.Name, group);
                    //Console.WriteLine("SB.TOC added group " + group.Name);
                }
            }

            this.TOC = toc;
            _SamplesCount = this.SampleRoutes.Count;
            _ComponentsCount = this.ComponentNames.Count;

            Console.WriteLine("SB.TOC parsed " + _SamplesCount + " samples");

            this.IsLoading = false;
            OnLoaded();
            await Task.Delay(1);
        }

        public event EventHandler<EventArgs> SamplesLoaded;
        public void OnLoaded()
        {
            this.SamplesLoaded?.Invoke(this, EventArgs.Empty);
        }

    }

}