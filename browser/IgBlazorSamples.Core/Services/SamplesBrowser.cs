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
            //Console.WriteLine("SB.APP URL: " + navManager.Uri);

            this.IsLoading = true;
            this.NavManager = navManager;
            this.HttpClient = httpClient;
            this.JSRuntime = jsRuntime;

            // NavManager = NavigationManager();
            // NavManager.LocationChanged += this.OnLocationChanged;
            // NavManager.LocationChanged += new EventHandler<LocationChangedEventArgs>(this.OnLocationChanged);

            Task task = Task.Run(() => InitTOC());
        }

        public async Task InitTOC()
        {
            if (IsWithNavigation())
            {
                await LoadTOC(); // needed only for navigation menu
            }

            await Task.Delay(1);
        }

        public bool IsWithNavigation()
        {
            if (NavManager.Uri.Contains("/samples")) return true;
            if (NavManager.Uri.EndsWith("/")) return true;
            if (NavManager.Uri.EndsWith("/blazor-client")) return true;
            if (NavManager.Uri.EndsWith("/blazor-client/")) return true;
            if (NavManager.Uri.EndsWith("/blazor-server")) return true;
            if (NavManager.Uri.EndsWith("/blazor-server/")) return true;
            //if (NavManager.Uri.Contains("localhost")) return true; //&&
            //if (NavManager.Uri + "/" == this.NavManager.BaseUri)  return true;

            return false;

            // return !NavManager.Uri.Contains("/samples") && NavManager.Uri != this.NavManager.BaseUri + "/";
        }
    }

    public class ObservableObject
    {
        public event Action OnChange;
        protected void NotifyPropertyChanged() => OnChange?.Invoke();
    }



}
