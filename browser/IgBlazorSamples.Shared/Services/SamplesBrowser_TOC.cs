using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Samples.Shared.Services
{
    public partial class SampleBrowser
    {
        //public bool IsLoading { get; set; }
        private bool _IsLoading = true;
        public bool IsLoading
        {
            get { return _IsLoading; }
            set { _IsLoading = value; NotifyPropertyChanged(); }
        }

        public SampleGroup[] SampleGroups { get { return GroupsLookup.Values.ToArray(); } }
        protected Dictionary<string, SampleGroup> GroupsLookup = new Dictionary<string, SampleGroup>();
        protected List<SampleTOC> TocFiles = new List<SampleTOC>();

        protected List<string> Components = new List<string>();
        private int _ComponentsCount = 0;
        public int ComponentsCount
        {
            get { return _ComponentsCount; }
            set { _ComponentsCount = value; NotifyPropertyChanged(); }
        }

        protected List<string> Samples = new List<string>();
        private int _SamplesCount = 0;
        public int SamplesCount
        {
            get { return _SamplesCount; }
            set { _SamplesCount = value; NotifyPropertyChanged(); }
        }

        public async Task LoadTOC(string[] tocNames)
        {
            Console.WriteLine("SB.TOC loading...");

            this.IsLoading = true;
            this.Samples = new List<string>();

            //var tocNames = new string[] {
            //    "toc/radial-gauge-toc.json",
            //    "toc/linear-gauge-toc.json",
            //};

            foreach (var tocName in tocNames)
            {
                try
                {
                    //var toc = await HttpClient.GetJsonAsync<SampleTOC>(tocName);
                    //toc.File = tocName.Replace("toc/", "");
                    //this.TocFiles.Add(toc);
                }
                catch (System.Exception)
                {
                    //  Console.WriteLine("TOC failed on: " + toc + "\n" + ex.Message);
                }
            }

            foreach (var toc in this.TocFiles)
            {
                Parse(toc);
            }

            this.SamplesCount = this.Samples.Count;
            this.ComponentsCount = this.Components.Count;

            this.IsLoading = false;
            OnLoaded();
            await Task.Delay(1);
        }

        public void Parse(SampleTOC comp)
        {
            Console.WriteLine("SB.TOC parsing " + comp.File);

            foreach (var sample in comp.Samples)
            {
                sample.Path = "/samples" + sample.Path;
            }

            if (this.Components.Contains(comp.Name))
            {
                 Console.WriteLine("SB.TOC duplicate component: " + comp.Name);
                 return;
            }
            else
            {
                this.Components.Add(comp.Name);
            }

            if (!this.GroupsLookup.ContainsKey(comp.Group))
            {
                GroupsLookup.Add(comp.Group, new SampleGroup() { Name = comp.Group});
                Console.WriteLine("SB.TOC added group " + comp.Group);
            }
            comp.IsExpanded = TocFiles.Count == 1;
            // comp.Name += " (" + comp.Samples.Length + ")";
            // comp.Name += " Samples";

            var group = this.GroupsLookup[comp.Group];
            group.Add(comp);

            Console.WriteLine("SB.TOC added comp: " + comp.Name);

            foreach (var sample in comp.Samples)
            {
                sample.Component = comp.Name;

                if (this.Samples.Contains(sample.Path))
                    Console.WriteLine("SB.TOC duplicate: " + sample.Path.Replace("/samples", ""));
                else
                    this.Samples.Add(sample.Path);
            }

            Console.WriteLine("SB.TOC added samples " + comp.Samples.Length);
        }

        public event EventHandler<EventArgs> SamplesLoaded;
        public void OnLoaded()
        {
            Console.WriteLine("SB.TOC loading... done");

            this.SamplesLoaded?.Invoke(this, EventArgs.Empty);
        }

    }

}