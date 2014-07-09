using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Integration;
using PortalLoc;
using rsloc.Domäne;
using rsloc.Provider;
using rsloc.contracts;

namespace rsloc.application
{
    class Program
    {
        static void Main(string[] args)
        {
            // build
            var portal = new Portal();
            var folderProvider = new FolderProvider();
            var csProvider = new CsProvider();
            var kommentarSchlucker = new KommentarSchlucker();
            var stats = new Statistik();
            // build + bind
            var interactors = new Interactors(folderProvider, csProvider, kommentarSchlucker, stats);
            var app = new Application(portal, interactors);
            // run
            app.Run();
        }
    }
}
