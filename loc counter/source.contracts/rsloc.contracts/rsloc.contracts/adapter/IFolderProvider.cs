using System;

namespace rsloc.contracts.adapter
{
    public interface IFolderProvider
    {
        void Ermittle_Dateinamen(string quellenangabe, Action<string> beiDateiname);
    }
}