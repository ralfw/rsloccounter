namespace Domäne
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using rsloc.contracts.daten;
    using rsloc.contracts.domäne;

    public class KommentarSchlucker: IKommentarschlucker
    {
        public Quellcode Einzeilige_Kommentare_schlucken(Quellcode quellcode)
        {
            return quellcode;
        }

        public Quellcode Leerzeilen_schlucken(Quellcode quellcode)
        {
            return quellcode;
        }

        public Quellcode Mehrzeilige_Kommentare_schlucken(Quellcode quellcode)
        {
            return quellcode;
        }
    }
}
