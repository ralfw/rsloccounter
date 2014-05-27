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
        public void Ermittle_Dateinamen(string pfad, Action<string> beiDateiname)
        {
            Klassifiziere_Quelle(pfad,
                beiDateiname,
                verzeichnis => Dateinamen_bestimmen(verzeichnis, beiDateiname));
        }


        private void Klassifiziere_Quelle(string pfad, Action<string> istDatei, Action<string> istVerzeichnis)
        {
            if (File.GetAttributes(pfad).HasFlag(FileAttributes.Directory))
            {
                istVerzeichnis(pfad);
            }
            else
            {
                istDatei(pfad);
            }
        }


        private void Dateinamen_bestimmen(string pfad, Action<string> beiDateiname)
        {
            var dirInfo = new DirectoryInfo(pfad);
            var fileInfos = dirInfo.EnumerateFiles("*.cs", SearchOption.AllDirectories);
            foreach (var fileInfo in fileInfos)
                beiDateiname(fileInfo.FullName);
        }
    }
}
