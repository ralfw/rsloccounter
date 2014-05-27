namespace rsloc.Domäne
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using rsloc.contracts.domäne;
    using rsloc.contracts.daten;

    /// <summary>
    /// Klasse die Statistik auf Quellcode berechnet
    /// </summary>
    public class Statistik: IStats
    {
        private int summeLoc ;

        public void LOC_summieren(Quellcode quellcode)
        {
            throw new NotImplementedException();
        }

        public int SummeLOC
        {
            get { return this.summeLoc; }
        }
    }
}
