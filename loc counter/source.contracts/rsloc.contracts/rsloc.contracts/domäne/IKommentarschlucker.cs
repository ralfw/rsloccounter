using rsloc.contracts.daten;

namespace rsloc.contracts.domäne
{
    public interface IKommentarschlucker
    {
        Quellcode Leerzeilen_schlucken(Quellcode quellcode);
        Quellcode Einzeilige_Kommentare_schlucken(Quellcode quellcode);
        Quellcode Mehrzeilige_Kommentare_schlucken(Quellcode quellcode);
    }
}