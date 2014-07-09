using System.Windows.Forms;
using rswecker.portal;
using rswecker.provider;

namespace rswecker.integration
{
    class App
    {
        public App(UI ui, Uhr uhr, MP3 mp3, Entrypoints ep)
        {
            ui.Start_gefordert += ep.Wecker_starten;
            ui.Stopp_gefordert += ep.Wecker_stoppen;

            ep.Restzeit += ui.Restzeit_anzeigen;
            ep.Weckzeit_erreicht += mp3.Abspielen;

            ep.Wecker_läuft += ui.Wecker_läuft;
            ep.Wecker_gestoppt += ui.Wecker_läuft_nicht;

            uhr.Uhrzeit += ui.Uhrzeit_anzeigen;

            uhr.Uhrzeit_starten();

            Application.Run(ui);
        }
    }
}
