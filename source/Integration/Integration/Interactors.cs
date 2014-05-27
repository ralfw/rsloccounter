using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rsloc.contracts;
using rsloc.contracts.adapter;
using rsloc.contracts.daten;
using rsloc.contracts.domäne;

namespace Integration
{
    class Interactors : IInteractors
    {
        #region IInteractors Members

        private IFolderProvider folderProvider;
        private ICsProvider csProvider;
        private IKommentarschlucker kommentarSchlucker;
        private IStats stats;

        public Interactors(IFolderProvider folderProvider, 
                           ICsProvider csProvider, 
                           IKommentarschlucker kommentarSchlucker, 
                           IStats stats)
        {
            this.folderProvider = folderProvider;
            this.csProvider = csProvider;
            this.kommentarSchlucker = kommentarSchlucker;
            this.stats = stats;
        }

        public int LOC_zählen(string quellenangabe)
        {
            GetFiles(quellenangabe, 
                Zeilen_zählen);
            return stats.SummeLOC;
        }

        private void GetFiles(string path, Action<Quellcode> beiQuellcode)
        {
            folderProvider.Ermittle_Dateinamen(path,
                dateiname => csProvider.Quellcode_auslesen(dateiname,
                                            beiQuellcode));
        }

        private void Zeilen_zählen(Quellcode quellcode)
        {
            quellcode = kommentarSchlucker.Leerzeilen_schlucken(quellcode);
            quellcode = kommentarSchlucker.Einzeilige_Kommentare_schlucken(quellcode);
            quellcode = kommentarSchlucker.Mehrzeilige_Kommentare_schlucken(quellcode);
            stats.LOC_summieren(quellcode);
        }

        #endregion
    }
}
