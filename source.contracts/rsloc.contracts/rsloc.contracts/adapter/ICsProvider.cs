using System;
using rsloc.contracts.daten;

namespace rsloc.contracts.adapter
{
    public interface ICsProvider
    {
        void Quellcode_auslesen(string dateiname, Action<Quellcode> beiQuellcode);
    }
}