using System; 
using System.Timers;

namespace Infragistics.Samples.Core
{
    public class SampleTimer
    {
        private Timer _timer;

        public void Start(double interval)
        {
            _timer = new Timer(interval);
            _timer.Elapsed += OnElapsed;
            _timer.Enabled = true;
        }

        public void Stop()
        {
            if (_timer != null)
            {
                _timer.Enabled = false;
                _timer.Dispose();
            }            
        }

        public event Action OnTick;

        private void OnElapsed(Object source, ElapsedEventArgs e)
        {
            //System.Diagnostics.Debug.WriteLine("OnElapsed");
            OnTick?.Invoke();
        }
    }
}
