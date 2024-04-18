using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using System.Runtime.ExceptionServices;
using System.Threading; 
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
            //Console.WriteLine("SB.ROT Update nav=" + fromNavigation + " Lazy=" + IsLazyLoading + " NeedsUpdate=" + NeedsUpdate);

            _NeedsUpdate = false;

            EnsureConnected();
            EnsureRouteMap();

            if (IsLazyLoading) { return; }

            var relativeUri = NavigationManager.ToBaseRelativePath(_currentLocation);
            if (!relativeUri.StartsWith("/"))
            {
                relativeUri = "/" + relativeUri;
            }
            var data = FindMatch(relativeUri);
            if (data != null)
            {
                //Console.WriteLine("SB.ROT Update pages=");
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

                //Console.WriteLine("SB.ROT Update pages=" + pages.Count());

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
                //Console.WriteLine("SB.ROT Update routes=" + _routeMap.Count);
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
            //Console.WriteLine("SB.ROT SetParametersAsync: _onNavigateFirst=" + _onNavigateFirst + " _onNavigateCalled=" + _onNavigateCalled);

            parameters.SetParameterProperties(this);

            if (AppAssembly == null)
            {
                throw new InvalidOperationException($"The CustomRouter component requires a value for the parameter {nameof(AppAssembly)}.");
            }

            // Found content is mandatory, because even though we could use something like <RouteView ...> as a
            // reasonable default, if it's not declared explicitly vin the template then people will have no way
            // to discover how to customize this (e.g., to add authorization).
            if (Found == null)
            {
                throw new InvalidOperationException($"The CustomRouter component requires a value for the parameter {nameof(Found)}.");
            }

            //if (!_onNavigateCalled)
            //{
            //    //Console.WriteLine("SB.ROT _onNavigateFirst: '" + _onNavigateFirst + "'");
            //    _onNavigateCalled = true;
            //    if (NavigationManager != null && _locationAbsolute != "" && !_onNavigateFirst)
            //    {
            //        //Console.WriteLine("SB.ROT _locationAbsolute: '" + _locationAbsolute + "'");
            //        //await RunOnNavigateAsync(NavigationManager.ToBaseRelativePath(_locationAbsolute), isNavigationIntercepted: false);
            //    }
            //    _onNavigateFirst = false;
            //}
            //else
            //{
            //    //Refresh(isNavigationIntercepted: false);
            //    //Update(false);
            //}

            Update(false); 
        }

        [Parameter] public EventCallback<string> OnNavigateChangedAsync { get; set; }

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
                NavigationManager.LocationChanged -= OnNavigationChanged;
            }
        }

        private void EnsureConnected()
        {
            if (!_connected)
            {
                _connected = true;
                NavigationManager.LocationChanged += OnNavigationChanged;
            }
        }

        public async Task OnAfterRenderAsync()
        {
            //Console.WriteLine("SB.ROT OnAfterRenderAsync ");
            if (!_navigationIntercepted)
            {
                _navigationIntercepted = true;
                await NavigationInterception.EnableNavigationInterceptionAsync();
            }
        }


#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
        private void OnNavigationChanged(object? sender, Components.Routing.LocationChangedEventArgs e)
#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
        {
            Console.WriteLine("SB.ROT " + e.Location);

            _currentLocation = e.Location;

            Task.Delay(1).ContinueWith((t) => OnNavigateChangedAsync.InvokeAsync(e.Location));

            //Update(true); // update is called when lazy loading is completed
        }

        [Parameter] public bool IsLazyLoading { get; set; }

        private bool _NeedsUpdate = false;
        [Parameter]
        public bool NeedsUpdate
        {
            get { return _NeedsUpdate; }
            set { _NeedsUpdate = value; if (_NeedsUpdate) { Update(true); } }
        }

        ///// <summary> Get or sets the content to display when asynchronous navigation is in progress. </summary>
        //#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
        // [Parameter] public RenderFragment? Navigating { get; set; }
        //#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.

        ///// <summary> Gets or sets a handler that should be called before navigating to a new page.  </summary> 
        //[Parameter] public EventCallback<NavigationContextArgs> OnNavigateContextAsync { get; set; }

        //private bool _onNavigateCalled;
        //private bool _onNavigateFirst = true;
        //private Task _previousOnNavigateTask = Task.CompletedTask;
        //private CancellationTokenSource _onNavigateCts;
        //string _locationAbsolute;

        //internal async ValueTask RunOnNavigateAsync(string path, bool isNavigationIntercepted)
        //{
        //    Console.WriteLine("SB.ROT RunOnNavigateAsync: ");
        //    // Cancel the CTS instead of disposing it, since disposing does not
        //    // actually cancel and can cause unintended Object Disposed Exceptions.
        //    // This effectively cancels the previously running task and completes it.
        //    _onNavigateCts?.Cancel();
        //    // Then make sure that the task has been completely cancelled or completed
        //    // before starting the next one. This avoid race conditions where the cancellation
        //    // for the previous task was set but not fully completed by the time we get to this
        //    // invocation.
        //    await _previousOnNavigateTask;
        //    Console.WriteLine("SB.ROT RunOnNavigateAsync._previousOnNavigateTask ");

        //    var tcs = new TaskCompletionSource(TaskCreationOptions.RunContinuationsAsynchronously);
        //    _previousOnNavigateTask = tcs.Task;

        //    if (!OnNavigateContextAsync.HasDelegate)
        //    {
        //        Console.WriteLine("SB.ROT RunOnNavigateAsync.HasDelegate ");
        //        //Refresh(isNavigationIntercepted);
        //    }

        //    _onNavigateCts = new CancellationTokenSource();
        //    //var d = new NavigationContext()
        //    var navigateContext = new NavigationContextArgs(path, _onNavigateCts.Token);
        //    Console.WriteLine("SB.ROT RunOnNavigateAsync.navigateContext ");

        //    var cancellationTcs = new TaskCompletionSource(TaskCreationOptions.RunContinuationsAsynchronously);
        //    navigateContext.CancellationToken.Register(state =>
        //        ((TaskCompletionSource)state).SetResult(), cancellationTcs);

        //    Console.WriteLine("SB.ROT RunOnNavigateAsync.TaskCompletionSource ");
        //    try
        //    {
        //        // Task.WhenAny returns a Task<Task> so we need to await twice to unwrap the exception
        //        var task = await Task.WhenAny(OnNavigateContextAsync.InvokeAsync(navigateContext), cancellationTcs.Task);
        //        await task;
        //        //tcs.SetResult();
        //        //Refresh(isNavigationIntercepted);
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("SB.ROT RunOnNavigateAsync error \n" + e.Message);
        //        _renderHandle.Render(builder => ExceptionDispatchInfo.Throw(e));
        //    }
        //} 

    }


    //public sealed class NavigationContextArgs
    //{
    //    internal NavigationContextArgs(string path, CancellationToken cancellationToken)
    //    {
    //        Path = path;
    //        CancellationToken = cancellationToken;
    //    }

    //    /// <summary> The target path for the navigation. </summary>
    //    public string Path { get; }

    //    /// <summary> The <see cref="CancellationToken"/> to use to cancel navigation.  </summary>
    //    public CancellationToken CancellationToken { get; }
    //}


}