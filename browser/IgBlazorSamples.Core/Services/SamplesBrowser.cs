using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Infragistics.Samples.Core
{
    public partial class SampleBrowser : ObservableObject
    {
        protected HttpClient HttpClient;
        protected IJSRuntime JSRuntime;
        protected NavigationManager NavManager;

        public SampleBrowser(NavigationManager navManager, IJSRuntime jsRuntime, HttpClient httpClient)
        {
            this.IsLoading = true;
            this.NavManager = navManager;
            this.HttpClient = httpClient;
            this.JSRuntime = jsRuntime;

            // Console.WriteLine("SB Const()");
            Console.WriteLine("SB URL: " + navManager.Uri);
            // NavManager = NavigationManager();
            // NavManager.LocationChanged += this.OnLocationChanged;
            // NavManager.LocationChanged += new EventHandler<LocationChangedEventArgs>(this.OnLocationChanged);
        }
    }

    public class ObservableObject
    {
        public event Action OnChange;
        protected void NotifyPropertyChanged() => OnChange?.Invoke();
    }



}
