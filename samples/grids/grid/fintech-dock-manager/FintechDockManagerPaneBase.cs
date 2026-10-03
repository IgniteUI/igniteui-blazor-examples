using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Infragistics.Samples
{
    /// <summary>
    /// Base for the desk's panes (the Components folder). A pane renders from the shared desk and
    /// re-renders itself for the desk changes it shows (WatchedChanges), and only for those: the
    /// shell re-renders the Dock Manager's slots whenever the layout changes, and a pane whose only
    /// parameter is the same desk has nothing new to draw then.
    /// </summary>
    public abstract class FintechDockManagerPaneBase : ComponentBase, IDisposable
    {
        private FintechDockManagerDesk subscribed;
        private bool initialized;
        private bool skipRender;

        [Parameter]
        public FintechDockManagerDesk Desk { get; set; }

        /// <summary>A parent that changes what the pane shows bumps this, and the pane renders again.</summary>
        [Parameter]
        public int Revision { get; set; }

        /// <summary>The desk changes this pane shows.</summary>
        protected abstract FintechDockManagerChange WatchedChanges { get; }

        public override Task SetParametersAsync(ParameterView parameters)
        {
            // A parent re-render hands the pane the same desk again; the pane's own subscription keeps
            // it current, so that render is skipped.
            var revision = parameters.TryGetValue<int>(nameof(Revision), out var next) ? next : Revision;
            skipRender = initialized && revision == Revision;
            initialized = true;
            return base.SetParametersAsync(parameters);
        }

        protected override void OnParametersSet()
        {
            if (subscribed == Desk)
            {
                return;
            }

            if (subscribed != null)
            {
                subscribed.Changed -= OnDeskChanged;
            }

            subscribed = Desk;
            if (subscribed != null)
            {
                subscribed.Changed += OnDeskChanged;
            }
        }

        protected override bool ShouldRender()
        {
            if (skipRender)
            {
                skipRender = false;
                return false;
            }

            return true;
        }

        /// <summary>Runs before the pane re-renders for a change it watches.</summary>
        protected virtual void OnDeskChange(FintechDockManagerChange change)
        {
        }

        private void OnDeskChanged(FintechDockManagerChange change)
        {
            if ((change & WatchedChanges) == 0)
            {
                return;
            }

            OnDeskChange(change);
            Refresh();
        }

        /// <summary>Re-renders the pane for a change of its own (a skipped parent render must not swallow it).</summary>
        protected void Refresh()
        {
            skipRender = false;
            StateHasChanged();
        }

        public virtual void Dispose()
        {
            if (subscribed != null)
            {
                subscribed.Changed -= OnDeskChanged;
                subscribed = null;
            }
        }
    }

    /// <summary>
    /// Base for the tick-driven parts of the order ticket (the price ladder, the quick sizes and the
    /// estimate): they follow the tape and the book like a pane, and the ticket's form as it changes.
    /// </summary>
    public abstract class FintechDockManagerTicketPart : FintechDockManagerPaneBase
    {
        private FintechDockManagerTicketModel subscribedModel;

        [Parameter]
        public FintechDockManagerTicketModel Model { get; set; }

        protected override FintechDockManagerChange WatchedChanges =>
            FintechDockManagerChange.Tick | FintechDockManagerChange.Selection | FintechDockManagerChange.Ticket |
            FintechDockManagerChange.Book | FintechDockManagerChange.Orders | FintechDockManagerChange.Reset;

        protected override void OnParametersSet()
        {
            base.OnParametersSet();
            if (subscribedModel == Model)
            {
                return;
            }

            if (subscribedModel != null)
            {
                subscribedModel.Changed -= OnModelChanged;
            }

            subscribedModel = Model;
            if (subscribedModel != null)
            {
                subscribedModel.Changed += OnModelChanged;
            }
        }

        private void OnModelChanged() => Refresh();

        public override void Dispose()
        {
            base.Dispose();
            if (subscribedModel != null)
            {
                subscribedModel.Changed -= OnModelChanged;
                subscribedModel = null;
            }
        }
    }
}
