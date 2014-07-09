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
            ep.Restzeit += ui.Restzeit_anzeigen;
            ep.Weckzeit_erreicht += mp3.Abspielen;

            uhr.Uhrzeit += ui.Uhrzeit_anzeigen;

            uhr.Uhrzeit_starten();

            Application.Run(ui);
        }
    }
}
