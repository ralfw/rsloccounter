using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using rswecker.integration;
using rswecker.portal;
using rswecker.provider;

namespace rswecker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var ui = new UI();
            var mp3 = new MP3();
            var uhr = new Uhr();
            var ep = new Entrypoints(uhr);
            var app = new App(ui, uhr, mp3, ep);

            Application.Run(ui);
        }
    }
}
