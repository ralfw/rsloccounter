namespace Domäne
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using rsloc.contracts.domäne;

    public class KommentarSchlucker: IKommentarschlucker
    {
        public rsloc.contracts.daten.Quellcode Einzeilige_Kommentare_schlucken(rsloc.contracts.daten.Quellcode quellcode)
        {
            return quellcode;
        }

        public rsloc.contracts.daten.Quellcode Leerzeilen_schlucken(rsloc.contracts.daten.Quellcode quellcode)
        {
            return quellcode;
        }

        public rsloc.contracts.daten.Quellcode Mehrzeilige_Kommentare_schlucken(rsloc.contracts.daten.Quellcode quellcode)
        {
            return quellcode;
        }
    }
}
