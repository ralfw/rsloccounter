namespace Domäne
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using rsloc.contracts.domäne;

    public class Statistik: IStats
    {
        public void LOC_summieren(rsloc.contracts.daten.Quellcode quellcode)
        {
            throw new NotImplementedException();
        }

        public int SummeLOC
        {
            get { throw new NotImplementedException(); }
        }
    }
}
