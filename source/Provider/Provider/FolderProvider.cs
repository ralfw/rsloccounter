using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using rsloc.contracts.adapter;
using rsloc.contracts.daten;

namespace rsloc.Provider
{
    public class FolderProvider : IFolderProvider
    {
        //TODO: Diese Methode sollte eigentlich integrieren: klassifizieren -> dateinamen bestimmen
        public void Ermittle_Dateinamen(string verzeichnisPfad, Action<string> beiDateiname)
        {
            var dirInfo = new DirectoryInfo(verzeichnisPfad);
            var fileInfos = dirInfo.EnumerateFiles("*.cs", SearchOption.AllDirectories);
            foreach (var fileInfo in fileInfos)
                beiDateiname(fileInfo.FullName);
        }
    }
}
