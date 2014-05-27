using rsloc.contracts.daten;

namespace rsloc.contracts.domäne
{
    public interface IStats
    {
        void LOC_summieren(Quellcode quellcode);
        int SummeLOC { get; }
    }
}