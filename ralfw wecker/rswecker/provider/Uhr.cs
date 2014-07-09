using System;

namespace rswecker.provider
{
    class Uhr
    {
        private System.Threading.Timer _countdownTimer;
        private System.Threading.Timer _uhrzeitTimer;
        private int _verbleibendeSekunden;


        internal void Uhrzeit_starten()
        {
            _uhrzeitTimer = new System.Threading.Timer(_ => 
                Uhrzeit(DateTime.Now), 
                null, 0, 1000);
        }


        internal void Countdown_starten(TimeSpan ablaufdauer)
        {
            _verbleibendeSekunden = (int)ablaufdauer.TotalSeconds;

            _countdownTimer = new System.Threading.Timer(_ => {
                Countdown(TimeSpan.FromSeconds(_verbleibendeSekunden));
                _verbleibendeSekunden--;
                if (_verbleibendeSekunden < 0) {
                    _countdownTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
                    Countdown_abgelaufen();
                }
            }, null, 0, 1000);
        }

        internal void Countdown_stoppen() {
            _countdownTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
        }


        internal event Action<DateTime> Uhrzeit;
        internal event Action<TimeSpan> Countdown;
        internal event Action Countdown_abgelaufen;
    }
}
