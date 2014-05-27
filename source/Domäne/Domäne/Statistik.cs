namespace rsloc.Domäne
{
    using System.Linq;

    using rsloc.contracts.domäne;
    using rsloc.contracts.daten;

    /// <summary>
    /// Klasse die Statistik auf Quellcode berechnet
    /// </summary>
    public class Statistik: IStats
    {
        private int summeLoc;

        public void LOC_summieren(Quellcode quellcode)
        {
            this.summeLoc += quellcode.Codezeilen.Length;
        }

        public int SummeLOC
        {
            get { return this.summeLoc; }
        }
    }
}
