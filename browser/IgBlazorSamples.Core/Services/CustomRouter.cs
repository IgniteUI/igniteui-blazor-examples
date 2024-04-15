using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Reflection;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Routing
{
    public class CustomRouter : IComponent, IDisposable, IHandleAfterRender
    {
        private bool disposedValue;

        private bool _connected = false;

        [Parameter]
        public RenderFragment NotFound { get; set; }

        [Parameter]
        public RenderFragment<Microsoft.AspNetCore.Components.RouteData> Found { get; set; }

        [Inject] private NavigationManager NavigationManager { get; set; }

        [Inject] private Components.Routing.INavigationInterception NavigationInterception { get; set; }

        [Parameter]
        public Assembly AppAssembly { get; set; }

        private RenderHandle _renderHandle;
        private string _currentLocation;

        private bool _navigationIntercepted = false;

        public void Update(bool fromNavigation)
        {
            EnsureConnected();
            EnsureRouteMap();

            var relativeUri = NavigationManager.ToBaseRelativePath(_currentLocation);
            if (!relativeUri.StartsWith("/"))
            {
                relativeUri = "/" + relativeUri;
            }
            var data = FindMatch(relativeUri);
            if (data != null)
            {
                _renderHandle.Render(Found(data));
            }
            else
            {
                _renderHandle.Render(NotFound);
            }
        }

        static readonly IReadOnlyDictionary<string, object> _emptyParameters = new Dictionary<string, object>();
        private Dictionary<string, Microsoft.AspNetCore.Components.RouteData> _routeMap = null;
        private void EnsureRouteMap()
        {
            if (_routeMap == null)
            {
                var pages = AppAssembly
                            .ExportedTypes
                            .Where(t => typeof(IComponent).IsAssignableFrom(t) && 
                                   t.IsDefined(typeof(RouteAttribute)));

                Console.WriteLine("SB.Router pages=" + pages.Count());

                _routeMap = new Dictionary<string, Microsoft.AspNetCore.Components.RouteData>();
                foreach (var page in pages)
                {
                    var routes = page.GetCustomAttributes(typeof(RouteAttribute), false);
                    for (var i = 0; i < routes.Length; i++)
                    {
                        var attribute = (RouteAttribute)routes[i];
                        var template = attribute.Template!;
                        var data = new Microsoft.AspNetCore.Components.RouteData(page, _emptyParameters);
                        _routeMap[template] = data;
                    }
                }
                Console.WriteLine("SB.Router routes=" + _routeMap.Count);
            }
        }

        private Microsoft.AspNetCore.Components.RouteData FindMatch(string relativeUri)
        {
            if (_routeMap.ContainsKey(relativeUri))
            {
                return _routeMap[relativeUri];
            }

            return null;
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        public void Attach(RenderHandle renderHandle)
        {
            _renderHandle = renderHandle;
            _currentLocation = NavigationManager.Uri;
            EnsureConnected();
        }

        public async Task SetParametersAsync(ParameterView parameters)
        {
            parameters.SetParameterProperties(this);
            //var dic = parameters.ToDictionary();
            Update(false);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    EnsureDisconnected();
                }

                disposedValue = true;
            }
        }

        private void EnsureDisconnected()
        {
            if (_connected)
            {
                _connected = false;
                NavigationManager.LocationChanged -= NavigationManager_LocationChanged;
            }
        }

        private void EnsureConnected()
        {
            if (!_connected)
            {
                _connected = true;
                NavigationManager.LocationChanged += NavigationManager_LocationChanged;
            }
        }

        public async Task OnAfterRenderAsync()
        {
            if (!_navigationIntercepted)
            {
                _navigationIntercepted = true;
                await NavigationInterception.EnableNavigationInterceptionAsync();
            }
        }

        private void NavigationManager_LocationChanged(object? sender, Components.Routing.LocationChangedEventArgs e)
        {
            var location = e.Location;
            _currentLocation = location;
            Update(true);
        }
    }
}