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
            Weckauftrag laufender_Weckauftrag = null;

            _wecker_starten += weckauftrag => {
                laufender_Weckauftrag = weckauftrag;
                var ablaufdauer = weckauftrag.VerbleibendeZeit;
                _uhr.Countdown_starten(ablaufdauer);
            };
            
            _uhr.Countdown += c => {
                Restzeit(c);
                laufender_Weckauftrag.Weckzeit_erreicht(
                    () => Weckzeit_erreicht());
            };
        }


        private readonly Action<Weckauftrag> _wecker_starten;
        public void Wecker_starten(Weckauftrag weckauftrag) { _wecker_starten(weckauftrag); }

        internal event Action<TimeSpan> Restzeit;
        internal event Action Weckzeit_erreicht;
    }
}
