namespace rsloc.contracts.adapter
{
    public interface IPortal
    {
        string Quellenangabe_bestimmen();
        void LOC_ausgeben(int loc);
    }
}