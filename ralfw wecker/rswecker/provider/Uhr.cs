using System;

namespace rswecker.provider
{
    class Uhr
    {
        private System.Threading.Timer _timer;
        private int _verbleibendeSekunden;

        internal void Countdown_starten(TimeSpan ablaufdauer)
        {
            _verbleibendeSekunden = (int)ablaufdauer.TotalSeconds;
            _timer = new System.Threading.Timer(Run, null, 0, 1000);
        }

        private void Run(object state)
        {
            Countdown(TimeSpan.FromSeconds(_verbleibendeSekunden));
            _verbleibendeSekunden--;
            if (_verbleibendeSekunden < 0)
                _timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
        }

        internal event Action<TimeSpan> Countdown;
    }
}
