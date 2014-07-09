using System;
using rswecker.provider;

namespace rswecker.integration
{
    class Entrypoints
    {
        private readonly Uhr _uhr;

        public Entrypoints(Uhr uhr)
        {
            _uhr = uhr;

            _wecker_starten += weckauftrag => {
                var ablaufdauer = weckauftrag.VerbleibendeZeit;
                _uhr.Countdown_starten(ablaufdauer);
                this.Wecker_läuft();
            };

            _wecker_stoppen += () => {
                _uhr.Countdown_stoppen();
                Wecker_gestoppt();
            };

            _uhr.Countdown += r => Restzeit(r);
            _uhr.Countdown_abgelaufen += () => {
                Weckzeit_erreicht();
                Wecker_gestoppt();
            };
        }


        private readonly Action<Weckauftrag> _wecker_starten;
        public void Wecker_starten(Weckauftrag weckauftrag) { _wecker_starten(weckauftrag); }

        private readonly Action _wecker_stoppen;
        public void Wecker_stoppen() { _wecker_stoppen(); }


        internal event Action<TimeSpan> Restzeit;
        internal event Action Weckzeit_erreicht;

        internal event Action Wecker_läuft;
        internal event Action Wecker_gestoppt;
    }
}
